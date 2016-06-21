using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public class resultOil
    {
        public string resultcode { get; set; }
        public string reason { get; set; }
        public Tresult result { get; set; }
        public string error_code { get; set; }
    }
    public class Tresult
    {
        public Pageinfo pageinfo { get; set; }
        public List<Tdata> data { get; set; }
    }
    public class Pageinfo
    {
        public string pnums { get; set; }
        public string current { get; set; }
        public string allpage { get; set; }
    }
    public class Tdata
    {
        public string id { get; set; }
        public string name { get; set; }
        public string area { get; set; }
        public string areaname { get; set; }
        public string address { get; set; }
        public string brandname { get; set; }
        public string type { get; set; }
        public string discount { get; set; }
        public string exhaust { get; set; }
        public string position { get; set; }
        public string lon { get; set; }
        public string lat { get; set; }
        public Price price { get; set; }
        public Gastprice gastprice { get; set; }
        public string fwlsmc { get; set; }
    }
    public class Price
    {
        public string E90 { get; set; }
        public string E93 { get; set; }
        public string E97 { get; set; }
        public string E0 { get; set; }
    }
    public class Gastprice
    {
        public string T92 { get; set; }
        public string T95 { get; set; }
        public string T0 { get; set; }
    }
}
