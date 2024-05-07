// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo

namespace MikuWeather {
    public class RootCaiyun {
        public string status { get; set; }
        public string api_version { get; set; }
        public string api_status { get; set; }
        public string lang { get; set; }
        public string unit { get; set; }
        public int tzshift { get; set; }
        public string timezone { get; set; }
        public int server_time { get; set; }
        public float[] location { get; set; }
        public Result result { get; set; }
    }

    public class Result {
        public Alert alert { get; set; }
        public Realtime realtime { get; set; }
        public Minutely minutely { get; set; }
        public Hourly hourly { get; set; }
        public Daily daily { get; set; }
        public int primary { get; set; }
        public string forecast_keypoint { get; set; }
    }

    public class Alert {
        public string status { get; set; }
        public Content[] content { get; set; }
        public Adcode[] adcodes { get; set; }
    }

    public class Content {
        public string province { get; set; }
        public string status { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public string regionId { get; set; }
        public string county { get; set; }
        public int pubtimestamp { get; set; }
        public float[] latlon { get; set; }
        public string city { get; set; }
        public string alertId { get; set; }
        public string title { get; set; }
        public string adcode { get; set; }
        public string source { get; set; }
        public string location { get; set; }
        public string request_status { get; set; }
    }

    public class Adcode {
        public int adcode { get; set; }
        public string name { get; set; }
    }

    public class Realtime {
        public string status { get; set; }
        public float temperature { get; set; }
        public float humidity { get; set; }
        public float cloudrate { get; set; }
        public string skycon { get; set; }
        public float visibility { get; set; }
        public float dswrf { get; set; }
        public Wind wind { get; set; }
        public float pressure { get; set; }
        public float apparent_temperature { get; set; }
        public Precipitation precipitation { get; set; }
        public Air_Quality air_quality { get; set; }
        public Life_Index life_index { get; set; }
    }

    public class Wind {
        public float speed { get; set; }
        public float direction { get; set; }
    }

    public class Precipitation {
        public Local local { get; set; }
        public Nearest nearest { get; set; }
    }

    public class Local {
        public string status { get; set; }
        public string datasource { get; set; }
        public float intensity { get; set; }
    }

    public class Nearest {
        public string status { get; set; }
        public float distance { get; set; }
        public float intensity { get; set; }
    }

    public class Air_Quality {
        public int pm25 { get; set; }
        public int pm10 { get; set; }
        public int o3 { get; set; }
        public int so2 { get; set; }
        public int no2 { get; set; }
        public float co { get; set; }
        public Aqi aqi { get; set; }
        public Description description { get; set; }
    }

    public class Aqi {
        public int chn { get; set; }
        public int usa { get; set; }
    }

    public class Description {
        public string chn { get; set; }
        public string usa { get; set; }
    }

    public class Life_Index {
        public Ultraviolet ultraviolet { get; set; }
        public Comfort comfort { get; set; }
    }

    public class Ultraviolet {
        public float index { get; set; }
        public string desc { get; set; }
    }

    public class Comfort {
        public int index { get; set; }
        public string desc { get; set; }
    }

    public class Minutely {
        public string status { get; set; }
        public string datasource { get; set; }
        public float[] precipitation_2h { get; set; }
        public float[] precipitation { get; set; }
        public float[] probability { get; set; }
        public string description { get; set; }
    }

    public class Hourly {
        public string status { get; set; }
        public string description { get; set; }
        public Precipitation1[] precipitation { get; set; }
        public Temperature[] temperature { get; set; }
        public Apparent_Temperature[] apparent_temperature { get; set; }
        public Wind1[] wind { get; set; }
        public Humidity[] humidity { get; set; }
        public Cloudrate[] cloudrate { get; set; }
        public Skycon[] skycon { get; set; }
        public Pressure[] pressure { get; set; }
        public Visibility[] visibility { get; set; }
        public Dswrf[] dswrf { get; set; }
        public Air_Quality1 air_quality { get; set; }
    }

    public class Air_Quality1 {
        public Aqi1[] aqi { get; set; }
        public Pm25[] pm25 { get; set; }
    }

    public class Aqi1 {
        public string datetime { get; set; }
        public Value value { get; set; }
    }

    public class Value {
        public int chn { get; set; }
        public int usa { get; set; }
    }

    public class Pm25 {
        public string datetime { get; set; }
        public int value { get; set; }
    }

    public class Precipitation1 {
        public string datetime { get; set; }
        public float value { get; set; }
        public int probability { get; set; }
    }

    public class Temperature {
        public string datetime { get; set; }
        public float value { get; set; }
    }

    public class Apparent_Temperature {
        public string datetime { get; set; }
        public float value { get; set; }
    }

    public class Wind1 {
        public string datetime { get; set; }
        public float speed { get; set; }
        public float direction { get; set; }
    }

    public class Humidity {
        public string datetime { get; set; }
        public float value { get; set; }
    }

    public class Cloudrate {
        public string datetime { get; set; }
        public float value { get; set; }
    }

    public class Skycon {
        public string datetime { get; set; }
        public string value { get; set; }
    }

    public class Pressure {
        public string datetime { get; set; }
        public float value { get; set; }
    }

    public class Visibility {
        public string datetime { get; set; }
        public float value { get; set; }
    }

    public class Dswrf {
        public string datetime { get; set; }
        public float value { get; set; }
    }

    public class Daily {
        public string status { get; set; }
        public Astro[] astro { get; set; }
        public Precipitation_08H_20H[] precipitation_08h_20h { get; set; }
        public Precipitation_20H_32H[] precipitation_20h_32h { get; set; }
        public Precipitation2[] precipitation { get; set; }
        public Temperature1[] temperature { get; set; }
        public Temperature_08H_20H[] temperature_08h_20h { get; set; }
        public Temperature_20H_32H[] temperature_20h_32h { get; set; }
        public Wind2[] wind { get; set; }
        public Wind_08H_20H[] wind_08h_20h { get; set; }
        public Wind_20H_32H[] wind_20h_32h { get; set; }
        public Humidity1[] humidity { get; set; }
        public Cloudrate1[] cloudrate { get; set; }
        public Pressure1[] pressure { get; set; }
        public Visibility1[] visibility { get; set; }
        public Dswrf1[] dswrf { get; set; }
        public Air_Quality2 air_quality { get; set; }
        public Skycon1[] skycon { get; set; }
        public Skycon_08H_20H[] skycon_08h_20h { get; set; }
        public Skycon_20H_32H[] skycon_20h_32h { get; set; }
        public Life_Index1 life_index { get; set; }
    }

    public class Air_Quality2 {
        public Aqi2[] aqi { get; set; }
        public Pm251[] pm25 { get; set; }
    }

    public class Aqi2 {
        public string date { get; set; }
        public Max max { get; set; }
        public Avg avg { get; set; }
        public Min min { get; set; }
    }

    public class Max {
        public int chn { get; set; }
        public int usa { get; set; }
    }

    public class Avg {
        public int chn { get; set; }
        public int usa { get; set; }
    }

    public class Min {
        public int chn { get; set; }
        public int usa { get; set; }
    }

    public class Pm251 {
        public string date { get; set; }
        public int max { get; set; }
        public int avg { get; set; }
        public int min { get; set; }
    }

    public class Life_Index1 {
        public Ultraviolet1[] ultraviolet { get; set; }
        public Carwashing[] carWashing { get; set; }
        public Dressing[] dressing { get; set; }
        public Comfort1[] comfort { get; set; }
        public Coldrisk[] coldRisk { get; set; }
    }

    public class Ultraviolet1 {
        public string date { get; set; }
        public string index { get; set; }
        public string desc { get; set; }
    }

    public class Carwashing {
        public string date { get; set; }
        public string index { get; set; }
        public string desc { get; set; }
    }

    public class Dressing {
        public string date { get; set; }
        public string index { get; set; }
        public string desc { get; set; }
    }

    public class Comfort1 {
        public string date { get; set; }
        public string index { get; set; }
        public string desc { get; set; }
    }

    public class Coldrisk {
        public string date { get; set; }
        public string index { get; set; }
        public string desc { get; set; }
    }

    public class Astro {
        public string date { get; set; }
        public Sunrise sunrise { get; set; }
        public Sunset sunset { get; set; }
    }

    public class Sunrise {
        public string time { get; set; }
    }

    public class Sunset {
        public string time { get; set; }
    }

    public class Precipitation_08H_20H {
        public string date { get; set; }
        public float max { get; set; }
        public float min { get; set; }
        public float avg { get; set; }
        public int probability { get; set; }
    }

    public class Precipitation_20H_32H {
        public string date { get; set; }
        public float max { get; set; }
        public float min { get; set; }
        public float avg { get; set; }
        public int probability { get; set; }
    }

    public class Precipitation2 {
        public string date { get; set; }
        public float max { get; set; }
        public float min { get; set; }
        public float avg { get; set; }
        public int probability { get; set; }
    }

    public class Temperature1 {
        public string date { get; set; }
        public float max { get; set; }
        public float min { get; set; }
        public float avg { get; set; }
    }

    public class Temperature_08H_20H {
        public string date { get; set; }
        public float max { get; set; }
        public float min { get; set; }
        public float avg { get; set; }
    }

    public class Temperature_20H_32H {
        public string date { get; set; }
        public float max { get; set; }
        public float min { get; set; }
        public float avg { get; set; }
    }

    public class Wind2 {
        public string date { get; set; }
        public Max1 max { get; set; }
        public Min1 min { get; set; }
        public Avg1 avg { get; set; }
    }

    public class Max1 {
        public float speed { get; set; }
        public float direction { get; set; }
    }

    public class Min1 {
        public float speed { get; set; }
        public float direction { get; set; }
    }

    public class Avg1 {
        public float speed { get; set; }
        public float direction { get; set; }
    }

    public class Wind_08H_20H {
        public string date { get; set; }
        public Max2 max { get; set; }
        public Min2 min { get; set; }
        public Avg2 avg { get; set; }
    }

    public class Max2 {
        public float speed { get; set; }
        public float direction { get; set; }
    }

    public class Min2 {
        public float speed { get; set; }
        public float direction { get; set; }
    }

    public class Avg2 {
        public float speed { get; set; }
        public float direction { get; set; }
    }

    public class Wind_20H_32H {
        public string date { get; set; }
        public Max3 max { get; set; }
        public Min3 min { get; set; }
        public Avg3 avg { get; set; }
    }

    public class Max3 {
        public float speed { get; set; }
        public float direction { get; set; }
    }

    public class Min3 {
        public float speed { get; set; }
        public float direction { get; set; }
    }

    public class Avg3 {
        public float speed { get; set; }
        public float direction { get; set; }
    }

    public class Humidity1 {
        public string date { get; set; }
        public float max { get; set; }
        public float min { get; set; }
        public float avg { get; set; }
    }

    public class Cloudrate1 {
        public string date { get; set; }
        public float max { get; set; }
        public float min { get; set; }
        public float avg { get; set; }
    }

    public class Pressure1 {
        public string date { get; set; }
        public float max { get; set; }
        public float min { get; set; }
        public float avg { get; set; }
    }

    public class Visibility1 {
        public string date { get; set; }
        public float max { get; set; }
        public float min { get; set; }
        public float avg { get; set; }
    }

    public class Dswrf1 {
        public string date { get; set; }
        public float max { get; set; }
        public float min { get; set; }
        public float avg { get; set; }
    }

    public class Skycon1 {
        public string date { get; set; }
        public string value { get; set; }
    }

    public class Skycon_08H_20H {
        public string date { get; set; }
        public string value { get; set; }
    }

    public class Skycon_20H_32H {
        public string date { get; set; }
        public string value { get; set; }
    }
}