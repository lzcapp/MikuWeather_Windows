using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace MikuWeather {
    internal static class DataQuery {
        private const string baidu_key = "edUWu66ddGavrmj9a6vcsa75";
        private const string caiyun_key = "XX3OXGV581TJoQNP";

        public static Dictionary<string, string> GetAstro_Caiyun(string coor) {
            var resultDict = new Dictionary<string, string>();
            const string url = "http://api.caiyunapp.com/v2/";
            var key = caiyun_key;
            var requestUrl = url + key + "/" + coor + "/daily";

            var requestToday = (HttpWebRequest)WebRequest.Create(requestUrl);
            requestToday.Method = "GET";
            string result;
            try {
                var response = (HttpWebResponse)requestToday.GetResponse();
                using (var reader =
                    new StreamReader(response.GetResponseStream() ?? throw new InvalidOperationException(),
                        Encoding.UTF8)) {
                    result = reader.ReadToEnd();
                }
            } catch (Exception exception) {
                resultDict.Add("exception", exception.Message);
                return resultDict;
            }

            var resultTodayJo = JObject.Parse(result);
            var status = (string)resultTodayJo.SelectToken("status");
            if (status != "ok") {
                resultDict.Add("exception", "error code");
                return resultDict;
            }

            var resultToken = resultTodayJo.SelectToken("result").SelectToken("daily").SelectToken("astro")[0];
            var sunrise = resultToken.SelectToken("sunrise").SelectToken("time").ToString();
            var sunset = resultToken.SelectToken("sunset").SelectToken("time").ToString();
            resultDict.Add("sunrise", sunrise);
            resultDict.Add("sunset", sunset);
            return resultDict;
        }

        public static Dictionary<string, string> UpdateData_Caiyun(string coor) {
            var resultDict = new Dictionary<string, string>();

            var client = new RestClient("http://api.caiyunapp.com/v2.6/" + caiyun_key + "/" + coor + "/weather?realtime&dailysteps=1");
            var request = new RestRequest();
            var response = client.Execute(request);
            var result = response.Content;
            if (result == null) {
                resultDict.Add("exception", "error code");
                return resultDict;
            }

            var jObject = JsonConvert.DeserializeObject<RootCaiyun>(result);

            var realtime = jObject.result.realtime;
            var status = realtime.status;
            if (status != "ok") {
                resultDict.Add("exception", "error code");
                return resultDict;
            }

            var todayTemp = realtime.temperature + " °C";
            var todayPic = realtime.skycon;
            resultDict.Add("today temp", todayTemp);
            resultDict.Add("today pic", todayPic);

            var daily = jObject.result.daily;
            status = daily.status;
            if (status != "ok") {
                return resultDict;
            }

            var tomorrowTempToken = daily.temperature_20h_32h;
            var tomorrowTemp = Math.Round(tomorrowTempToken[0].min, 0) + " °C ~ " +
                               Math.Round(tomorrowTempToken[0].max, 0) + " °C";
            var tomorrowPic = daily.skycon_20h_32h[0].value;
            resultDict.Add("tomorrow temp", tomorrowTemp);
            resultDict.Add("tomorrow pic", tomorrowPic);

            return resultDict;
        }

        public static Dictionary<string, string> GetLocation() {
            var dictResult = new Dictionary<string, string>();
            var key = baidu_key;

            var client = new RestClient("https://api.map.baidu.com/location/ip?ak=" + key + "&coor=gcj02");
            var request = new RestRequest();
            var response = client.Execute(request);
            var result = response.Content;
            if (result == null) {
                dictResult.Add("exception", "error code");
                return dictResult;
            }

            var jObject = JsonConvert.DeserializeObject<RootBaidu>(result);

            var status = jObject.status;
            if (status != 0) {
                dictResult.Add("exception", "status code ≠ 0");
                return dictResult;
            }

            var content = jObject.content;
            var cityName = content.address_detail.city.Split(Convert.ToChar("市"))[0];
            var pointToken = content.point;
            var coordinate = pointToken.x + "," + pointToken.y;
            dictResult.Add("city", cityName);
            dictResult.Add("coor", coordinate);
            return dictResult;
        }
    }
}