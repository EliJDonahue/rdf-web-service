using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aras.IOM;

namespace RDFWebApp.Models
{
    public class ArasCall
    {
        public static string USER = "admin";
        public static string PWD = "innovator";
        public static string URL = "http://edonahue02/11SP10/";
        public static string DB = "RDF";

        public string Name { get; set; }
        public string Action { get; set; }
        public string ItemType { get; set; }
        public string Body { get; set; }
        public Innovator Inn { get; set; }
        public HttpServerConnection Conn { get; set; }
    }
}