using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json.Linq;

namespace MikuWeather
{
    internal static class DataQuery
    {
        public static Dictionary<string, string> UpdateData_Baidu(string city)
        {
            Dictionary<string, string> resultDict = new Dictionary<string, string>();
            const string url = "http://api.map.baidu.com/telematics/v3/weather?location=";
            var key = ConfigurationManager.AppSettings["apikey_baidu"];
            var requestUrl = url + city + "&output=json&ak=" + key;
            var request = (HttpWebRequest) WebRequest.Create(requestUrl);
            request.Method = "GET";
            string result;
            try
            {
                var response = (HttpWebResponse) request.GetResponse();
                using (var reader =
                    new StreamReader(response.GetResponseStream() ?? throw new InvalidOperationException(),
                        Encoding.UTF8))
                {
                    result = reader.ReadToEnd();
                }
            }
            catch (Exception exception)
            {
                resultDict.Add("Exception", exception.Message);
                return resultDict;
            }

            var resultJo = JObject.Parse(result);
            var status = (string) resultJo.SelectToken("error");
            if (status != "0")
            {
                resultDict.Add("Exception", "error code");
                return resultDict;
            }
            var pm25Str = resultJo.SelectToken("pm25").ToString();
            var resultToken = resultJo.SelectToken("results")[0];
            var weatherToken = resultToken.SelectToken("weather_data");
            return resultDict;
        }

        public static string GetLocation()
        {
            const string url = "http://api.map.baidu.com/location/ip?ak=";
            var key = ConfigurationManager.AppSettings["apikey_baidu"];
            var requestUrl = url + key;
            var request = (HttpWebRequest)WebRequest.Create(requestUrl);
            request.Method = "GET";
            string result;
            try
            {
                var response = (HttpWebResponse)request.GetResponse();
                using (var reader = new StreamReader(response.GetResponseStream() ?? throw new InvalidOperationException(), Encoding.UTF8))
                {
                    result = reader.ReadToEnd();
                }
            }
            catch (Exception)
            {
                return "Exception";
            }
            var resultJo = JObject.Parse(result);
            var status = (string)resultJo.SelectToken("status");
            if (status != "0")
            {
                return "status code ≠  0";
            }
            var contentToken = resultJo.SelectToken("content").SelectToken("address_detail");
            var cityToken = contentToken.SelectToken("city");
            var cityName = cityToken.ToString().Split(Convert.ToChar("市"))[0];
            return cityName;
        }
    }
}
