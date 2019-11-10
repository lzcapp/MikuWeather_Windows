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

        private static string FormatTemp(string tempStr) {
            tempStr = tempStr.Replace("℃", "");
            var tempSplit = tempStr.Split('~');
            var tempLow = tempSplit[1];
            var tempHigh = tempSplit[0];
            var result = tempLow + " ~ " + tempHigh + "℃";
            return result;
        }

        public static string GetLocation() {
            const string url = "http://api.map.baidu.com/location/ip?ak=";
            var key = ConfigurationManager.AppSettings["apikey_baidu"];
            var requestUrl = url + key;
            var request = (HttpWebRequest)WebRequest.Create(requestUrl);
            request.Method = "GET";
            string result;
            try {
                var response = (HttpWebResponse)request.GetResponse();
                using (var reader = new StreamReader(response.GetResponseStream() ?? throw new InvalidOperationException(), Encoding.UTF8)) {
                    result = reader.ReadToEnd();
                }
            }
            catch (Exception) {
                return "Exception";
            }
            var resultJo = JObject.Parse(result);
            var status = (string)resultJo.SelectToken("status");
            if (status != "0") {
                return "status code ≠  0";
            }
            var contentToken = resultJo.SelectToken("content").SelectToken("address_detail");
            var cityToken = contentToken.SelectToken("city");
            var cityName = cityToken.ToString().Split(Convert.ToChar("市"))[0];
            return cityName;
        }
    }
}