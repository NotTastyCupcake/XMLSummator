using Metcom.XMLSummator.ApplicationCore.Entities.BalanceModel.BalanceAbstractModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Metcom.XMLSummator.ApplicationCore.Entities.BalanceModel
{
    [Serializable]
    [XmlRoot(ElementName = "Данные101", Namespace = "urn:cbr-ru:rep0409101:v1.0.4.5")]
    public class BalanceCollection
    {
        [XmlAttribute("Ид")]
        public int Id { get; set; }

        [XmlArray("Баланс")]
        [XmlArrayItem("Баланс", typeof(Balance))]
        public Balance[] Balances { get; set; }

        [XmlArray("ИтогоБаланс")]
        [XmlArrayItem("ИтогоБаланс", typeof(TotalBalance))]
        public TotalBalance[] TotalBalances { get; set; }

        [XmlArray("ИтогоДоверит")]
        [XmlArrayItem("ИтогоДовУпр", typeof(TotalTrust))]
        public TotalTrust[] TotalTrusts { get; set; }

        [XmlArray("Внебал")]
        [XmlArrayItem("ВнебалСч", typeof(BalanceOut))]
        public BalanceOut[] BalancesOut { get; set; }

        [XmlArray("ИтогВнебал")]
        [XmlArrayItem("ИтогоВнебалСч", typeof(TotalOutBalance))]
        public TotalOutBalance[] TotalOutBalances { get; set; }

        [XmlArray("Срочные")]
        [XmlArrayItem("Срочные", typeof(BalanceFaster))]
        public BalanceFaster[] BalancesFaster { get; set; }

        [XmlArray("ИтогоСрочные")]
        [XmlArrayItem("ИтогоСрочные", typeof(TotalFastBalance))]
        public TotalFastBalance[] TotalFastBalances { get; set; }
    }
}
