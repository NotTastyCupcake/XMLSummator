using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Metcom.XMLSummator.ApplicationCore.Entities
{
    [Serializable]
    [XmlRoot(ElementName = "Составитель", Namespace = "urn:cbr-ru:rep0409101:v1.0.4.5")]
    public class Data
    {
        [XmlAnyAttribute]
        public XmlAttribute[] Attrebutes { get; set; }

        [XmlAnyElement]
        public XmlElement[] XmlElements { get; set; }
    }

    [Serializable]
    [XmlRoot(ElementName = "ИнфПК", Namespace = "urn:cbr-ru:rep0409101:v1.0.4.5")]
    public class Footer
    {
        [XmlAnyAttribute]
        public XmlAttribute[] Attrebutes { get; set; }

        [XmlAnyElement]
        public XmlElement[] XmlElements { get; set; }
    }
}
