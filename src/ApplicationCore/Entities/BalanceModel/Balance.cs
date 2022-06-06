using Metcom.XMLSummator.ApplicationCore.Entities.BalanceModel.BalanceAbstractModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Metcom.XMLSummator.ApplicationCore.Entities.BalanceModel
{
    public class Balance : BalanceBaseEntity
    {
        public Balance()
        {
            base.BalanceType = "Баланс";
        }
    }
    public class BalanceOut : BalanceBaseEntity
    {
        public BalanceOut()
        {
            base.BalanceType = "ВнебалСч";
        }
    }

    public class BalanceFaster : BalanceBaseEntity
    {
        public BalanceFaster()
        {
            base.BalanceType = "Срочные";
        }
    
    }
}
