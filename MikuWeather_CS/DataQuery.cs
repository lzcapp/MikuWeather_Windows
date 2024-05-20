using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Globalization;

namespace MikuWeather {
    internal static class DataQuery {
        private const string BaiduKey = "edUWu66ddGavrmj9a6vcsa75";

        private const string CaiyunKey = "XX3OXGV581TJoQNP";

        // ReSharper disable once IdentifierTypo
        public static Dictionary<string, string> UpdateData_Caiyun(string coor) {
            var resultDict = new Dictionary<string, string>();

            // ReSharper disable once StringLiteralTypo
            var client = new RestClient("http://api.caiyunapp.com/v2.6/" + CaiyunKey + "/" + coor + "/weather?alert=true");
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

            var tomorrowTemp = Math.Round(daily.temperature_20h_32h[0].min, 0) + " °C ~ " +
                               Math.Round(daily.temperature_20h_32h[0].max, 0) + " °C";
            var tomorrowPic = daily.skycon_20h_32h[0].value;
            resultDict.Add("tomorrow temp", tomorrowTemp);
            resultDict.Add("tomorrow pic", tomorrowPic);

            var sunrise = daily.astro[0].sunrise.time;
            var sunset = daily.astro[0].sunset.time;
            resultDict.Add("sunrise", sunrise);
            resultDict.Add("sunset", sunset);

            var strAlertTitle = "";
            var strAlertDescription = "";
            if (jObject.result.alert != null) {
                if (jObject.result.alert.content.Length > 0) {
                    strAlertTitle = jObject.result.alert.content[0].title;
                    strAlertDescription = jObject.result.alert.content[0].description;
                }
            }

            resultDict.Add("AlertTitle", strAlertTitle);
            resultDict.Add("AlertDescription", strAlertDescription);

            return resultDict;
        }

        public static Dictionary<string, string> GetLocation() {
            try {
                var dictResult = new Dictionary<string, string>();

                // ReSharper disable once StringLiteralTypo
                var client = new RestClient("https://api.map.baidu.com/location/ip?ak=" + BaiduKey + "&coor=gcj02");
                var request = new RestRequest();
                var response = client.Execute(request);
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

                var content = jObject.content;
                var cityName = content.address_detail.city.Split(Convert.ToChar("市"))[0];
                var pointToken = content.point;
                var coordinate = pointToken.x + "," + pointToken.y;
                dictResult.Add("city", cityName);
                dictResult.Add("coordinate", coordinate);
                return dictResult;
            } catch (Exception) {
                return null;
            }
        }

        public static Dictionary<string, string> GetDeviceLocation() {
            try {
                var dictResult = new Dictionary<string, string>();
                var watcher = new GeoCoordinateWatcher();
                watcher.TryStart(false, TimeSpan.FromMilliseconds(5000));
                // ReSharper disable once IdentifierTypo
                var coor = watcher.Position.Location;
                if (coor.Longitude.ToString(CultureInfo.InvariantCulture) == "NaN" || coor.Latitude.ToString(CultureInfo.InvariantCulture) == "NaN") {
                    return null;
                }

                var coordinate = coor.Longitude + "," + coor.Latitude;
                dictResult.Add("coordinate", coordinate);
                return dictResult;
            } catch (Exception) {
                return null;
            }
        }
    }
}