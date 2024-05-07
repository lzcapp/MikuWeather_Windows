using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;

namespace MikuWeather {
    internal static class DataQuery {
        private const string BaiduKey = "edUWu66ddGavrmj9a6vcsa75";
        private const string CaiyunKey = "XX3OXGV581TJoQNP";

        public static Dictionary<string, string> UpdateData_Caiyun(string coor) {
            var resultDict = new Dictionary<string, string>();

            var baseUrl = "https://api.caiyunapp.com/v2.6/" + CaiyunKey + "/" + coor + "/weather?alert=true";
            var client = new RestClient(baseUrl);
            var request = new RestRequest();
            RestResponse response = client.Execute(request);
            var result = response.Content;
            if (result == null) {
                resultDict.Add("exception", "error code");
                return resultDict;
            }

            var jObject = JsonConvert.DeserializeObject<RootCaiyun>(result);

            Alert alert = jObject.result.alert;
            var status = alert.status;
            if (status != "ok") {
                resultDict.Add("exception", "error code");
                return resultDict;
            }

            Realtime realtime = jObject.result.realtime;
            status = realtime.status;
            if (status != "ok") {
                resultDict.Add("exception", "error code");
                return resultDict;
            }

            var todayTemp = realtime.temperature + "℃";
            var todayPic = realtime.skycon;
            resultDict.Add("today temp", todayTemp);
            resultDict.Add("today pic", todayPic);

            Daily daily = jObject.result.daily;
            status = daily.status;
            if (status != "ok") {
                resultDict.Add("exception", "error code");
                return resultDict;
            }

            var tomorrowTemp = Math.Round(daily.temperature_20h_32h[0].min, 0) + "℃ - " + Math.Round(daily.temperature_20h_32h[0].max, 0) + "℃";
            var tomorrowPic = daily.skycon_20h_32h[0].value;
            resultDict.Add("tomorrow temp", tomorrowTemp);
            resultDict.Add("tomorrow pic", tomorrowPic);

            var sunrise = daily.astro[0].sunrise.time;
            var sunset = daily.astro[0].sunset.time;
            resultDict.Add("sunrise", sunrise);
            resultDict.Add("sunset", sunset);
            return resultDict;
        }

        public static Dictionary<string, string> GetLocation() {
            var dictResult = new Dictionary<string, string>();

            var client = new RestClient("https://api.map.baidu.com/location/ip?ak=" + BaiduKey + "&coor=gcj02");

            var request = new RestRequest();
            RestResponse response = client.Execute(request);
            var result = response.Content;
            if (result == null) {
                dictResult.Add("exception", "fetch api error");
                return dictResult;
            }

            var jObject = JsonConvert.DeserializeObject<RootBaidu>(result);

            var status = jObject.status;
            if (status != 0) {
                dictResult.Add("exception", "status code ≠ 0");
                return dictResult;
            }

            Content_Baidu content = jObject.content;
            var cityName = content.address_detail.city.Split(Convert.ToChar("市"))[0];
            Point pointToken = content.point;
            var coordinate = pointToken.x + "," + pointToken.y;
            dictResult.Add("city", cityName);
            dictResult.Add("coordinate", coordinate);
            return dictResult;
        }
    }
}