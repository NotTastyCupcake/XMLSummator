using Metcom.XMLSummator.ApplicationCore.Entities.BalanceModel.BalanceAbstractModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Metcom.XMLSummator.ApplicationCore.Entities.BalanceModel
{
    [Serializable]
    public class Balance : BalanceBaseEntity
    {
        [XmlElement("Баланс")]
        public string BalanceType { get; set; } = "Баланс";
    }
    [Serializable]
    public class BalanceOut : BalanceBaseEntity
    {
        [XmlElement("ВнебалСч")]
        public string BalanceType { get; set; } = "ВнебалСч";
    }
    [Serializable]
    public class BalanceFaster : BalanceBaseEntity
    {
        [XmlElement("Сречные")]
        public string BalanceType { get; set; } = "Сречные";
    }
}
