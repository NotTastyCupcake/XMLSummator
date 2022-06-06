using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Metcom.XMLSummator.ApplicationCore.Entities.BalanceModel.BalanceAbstractModel
{

    [Serializable]
    public abstract class BalanceTotalBaseEntity : ReportingBalanceBaseEntity
    {
        public override bool Equals(object obj)
        {
            return Equals(obj as BalanceTotalBaseEntity);
        }

        public bool Equals(BalanceTotalBaseEntity other)
        {
            return other != null &&
                   BalanceType == other.BalanceType &&
                   Currency == other.Currency &&
                   Feature == other.Feature;
        }

        public override int GetHashCode()
        {
            return BalanceType.GetHashCode() ^ Currency.GetHashCode() ^ Feature.GetHashCode();
        }
    }
}
