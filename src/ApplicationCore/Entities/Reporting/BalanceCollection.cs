using Metcom.XMLSummator.ApplicationCore.Entities.ReportingModel;
using Metcom.XMLSummator.ApplicationCore.Entities.ReportingModel.BalanceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Metcom.XMLSummator.ApplicationCore.Entities.ReportingModel
{
    [Serializable]
    [XmlRoot(ElementName = "Данные101", Namespace = "")]
    public class BalanceCollection
    {
        [XmlArray("Баланс")]
        [XmlArrayItem(typeof(ReportingBalance))]
        public ICollection<ReportingBalance> Balance { get; set; }
        
        public ICollection<ReportingTotalBalance> TotalBalance { get; set; }

    }
}
