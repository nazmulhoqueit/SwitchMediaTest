using System;
using System.Xml.Serialization;
using Realms;

namespace SwitchMediaTest.Model
{
    public class Image : RealmObject 
    {
        [XmlElement("imageUrl")]
        public string imageUrl { get; set; }
        public string sTitle { get; set; }
        public byte[] imageBytes { get; set; }
    }
}
