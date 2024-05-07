// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo

namespace MikuWeather {
    public class RootBaidu {
        public string address { get; set; }
        public Content_Baidu content { get; set; }
        public int status { get; set; }
    }

    public class Content_Baidu {
        public Address_Detail address_detail { get; set; }
        public string address { get; set; }
        public Point point { get; set; }
    }

    public class Address_Detail {
        public string province { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public string street { get; set; }
        public string street_number { get; set; }
        public int city_code { get; set; }
        public string adcode { get; set; }
    }

    public class Point {
        public string x { get; set; }
        public string y { get; set; }
    }
}