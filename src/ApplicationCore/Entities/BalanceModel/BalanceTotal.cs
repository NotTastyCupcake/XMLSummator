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
    public class TotalBalance : BalanceTotalBaseEntity
    {
        public TotalBalance()
        {
            base.BalanceType = "ИтогоБаланс";
        }
    }
    [Serializable]
    public class TotalTrust : BalanceTotalBaseEntity
    {
        public TotalTrust()
        {
            base.BalanceType = "ИтогоДовУпр";
        }

    }
    [Serializable]
    public class TotalOutBalance : BalanceTotalBaseEntity
    {
        public TotalOutBalance()
        {
            base.BalanceType = "ИтогоВнебалСч";
        }
    }
    [Serializable]
    public class TotalFastBalance : BalanceTotalBaseEntity
    {
        public TotalFastBalance()
        {
            base.BalanceType = "ИтогоСрочные";
        }
    }
}
