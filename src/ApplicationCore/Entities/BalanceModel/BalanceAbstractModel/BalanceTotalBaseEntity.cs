using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Metcom.XMLSummator.ApplicationCore.Entities.BalanceModel.BalanceAbstractModel
{
    public abstract class TotalBalanceBaseEntity : ReportingBalanceBaseEntity
    {
        [XmlElement("Баланс")]
        public new virtual string BalanceType { get; set; }
    }
}
