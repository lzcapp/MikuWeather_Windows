using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Text;

namespace MikuWeather {

    internal static class DataQuery {

        public static Dictionary<string, string> UpdateData_Baidu(string city) {
            var resultDict = new Dictionary<string, string>();
            const string url = "http://api.map.baidu.com/telematics/v3/weather?location=";
            var key = ConfigurationManager.AppSettings["apikey_baidu"];
            var requestUrl = url + city + "&output=json&ak=" + key;
            var request = (HttpWebRequest)WebRequest.Create(requestUrl);
            request.Method = "GET";
            string result;
            try {
                var response = (HttpWebResponse)request.GetResponse();
                using (var reader =
                    new StreamReader(response.GetResponseStream() ?? throw new InvalidOperationException(),
                        Encoding.UTF8)) {
                    result = reader.ReadToEnd();
                }
            }
            catch (Exception exception) {
                resultDict.Add("exception", exception.Message);
                return resultDict;
            }

            var resultJo = JObject.Parse(result);
            var status = (string)resultJo.SelectToken("error");
            if (status != "0") {
                resultDict.Add("exception", "error code");
                return resultDict;
            }
            var resultToken = resultJo.SelectToken("results")[0];
            var pm25 = resultToken.SelectToken("pm25").ToString();
            resultDict.Add("pm25", pm25);

            var weatherToken = resultToken.SelectToken("weather_data");

            var todayToken = weatherToken[0];
            var todayTemp = todayToken.SelectToken("temperature").ToString();
            var todayTempFormat = FormatTemp(todayTemp);
            var todayWeather = todayToken.SelectToken("weather").ToString();
            var todayDayPicUrl = todayToken.SelectToken("dayPictureUrl").ToString();
            var todayNightPicUrl = todayToken.SelectToken("nightPictureUrl").ToString();
            resultDict.Add("today temp", todayTempFormat);
            resultDict.Add("today weather", todayWeather);
            resultDict.Add("today day pic url", todayDayPicUrl);
            resultDict.Add("today night pic url", todayNightPicUrl);

            var tomorrowToken = weatherToken[1];
            var tomorrowTemp = tomorrowToken.SelectToken("temperature").ToString();
            var tomorrowTempFormat = FormatTemp(tomorrowTemp);
            var tomorrowWeather = tomorrowToken.SelectToken("weather").ToString();
            var tomorrowDayPicUrl = tomorrowToken.SelectToken("dayPictureUrl").ToString();
            var tomorrowNightPicUrl = tomorrowToken.SelectToken("nightPictureUrl").ToString();
            resultDict.Add("tomorrow temp", tomorrowTempFormat);
            resultDict.Add("tomorrow weather", tomorrowWeather); ;
            resultDict.Add("tomorrow day pic url", tomorrowDayPicUrl);
            resultDict.Add("tomorrow night pic url", tomorrowNightPicUrl);

            return resultDict;
        }

        public static Dictionary<string, string> UpdateData_Caiyun() {

        }

        private static string FormatTemp(string tempStr) {
            tempStr = tempStr.Replace("℃", "");
            var tempSplit = tempStr.Split('~');
            var tempLow = tempSplit[1];
            var tempHigh = tempSplit[0];
            var result = tempLow + " ~ " + tempHigh + "℃";
            return result;
        }

        public static Dictionary<string, string> GetLocation() {
            var dictResult = new Dictionary<string, string>();
            const string url = "http://api.map.baidu.com/location/ip?ak=";
            var key = ConfigurationManager.AppSettings["apikey_baidu"];
            var requestUrl = url + key + "&coor=gcj02";
            var request = (HttpWebRequest)WebRequest.Create(requestUrl);
            request.Method = "GET";
            string result;
            try {
                var response = (HttpWebResponse)request.GetResponse();
                using (var reader = new StreamReader(response.GetResponseStream() ?? throw new InvalidOperationException(), Encoding.UTF8)) {
                    result = reader.ReadToEnd();
                }
            }
            catch (Exception ex) {
                dictResult.Add("exception", ex.Message);
                return dictResult;
            }
            var resultJo = JObject.Parse(result);
            var status = (string)resultJo.SelectToken("status");
            if (status != "0") {
                dictResult.Add("exception", "status code ≠  0");
                return dictResult;
            }
            var contentToken = resultJo.SelectToken("content");
            var addressToken = contentToken.SelectToken("address_detail");
            var cityToken = addressToken.SelectToken("city");
            var cityName = cityToken.ToString().Split(Convert.ToChar("市"))[0];
            var pointToken = contentToken.SelectToken("point");
            var coordinate = pointToken.SelectToken("x").ToString() + "," + pointToken.SelectToken("y");
            dictResult.Add("city", cityName);
            dictResult.Add("coor", coordinate);
            return dictResult;
        }
    }
}