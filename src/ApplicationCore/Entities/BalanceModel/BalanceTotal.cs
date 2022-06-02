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
    public class TotalBalance : TotalBalanceBaseEntity
    {
        [XmlElement("ИтогоБаланс")]
        public string BalanceType { get; set; } = "ИтогоБаланс";
    }
    [Serializable]
    public class TotalTrust : TotalBalanceBaseEntity
    {
        [XmlElement("ИтогоДовУпр")]
        public string BalanceType { get; set; } = "ИтогоБаланс";
    }
    [Serializable]
    public class TotalOutBalance : TotalBalanceBaseEntity
    {
        [XmlElement("ИтогоВнебалСч")]
        public string BalanceType { get; set; } = "ИтогоВнебалСч";
    }
    [Serializable]
    public class TotalFastBalance : TotalBalanceBaseEntity
    {
        [XmlElement("ИтогоСрочные")]
        public string BalanceType { get; set; } = "ИтогоСрочные";
    }
}
