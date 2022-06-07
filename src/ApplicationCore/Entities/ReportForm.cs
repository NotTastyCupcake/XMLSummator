using Metcom.XMLSummator.ApplicationCore.Entities.BalanceModel;
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
    [XmlRoot(ElementName = "Ф0409101", Namespace = "urn:cbr-ru:rep0409101:v1.0.4.5")]
    public class ReportForm
    {
        [XmlAnyAttribute]
        public XmlAttribute[] MainFormAttrebute { get; set; }

        [XmlElement("Составитель")]
        public ContactData PersonData { get; set; }

        [XmlElement("Данные101")]
        public BalanceCollection BalanceCollection {get; set;}

        [XmlElement(ElementName ="ИнфПК", Namespace = "urn:cbr-ru:rep0409101:v1.0.4.5")]
        public Footer FooterData { get; set; }
    }
}
