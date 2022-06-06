using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Metcom.XMLSummator.ApplicationCore.Entities.BalanceModel.BalanceAbstractModel
{

    [Serializable]
    public abstract class BalanceBaseEntity : ReportingBalanceBaseEntity
    {
        [XmlAttribute("Счет2Пор")]
        /// <summary>
        /// Идентификатор клиента - Счет2Пор
        /// </summary>
        public int SecondOrderAccount { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as BalanceBaseEntity);
        }

        public bool Equals(BalanceBaseEntity other)
        {
            return other != null &&
                   BalanceType == other.BalanceType &&
                   SecondOrderAccount == other.SecondOrderAccount &&
                   Currency == other.Currency &&
                   Feature == other.Feature;
        }

        public override int GetHashCode()
        {
            return SecondOrderAccount.GetHashCode() ^ BalanceType.GetHashCode() ^ Currency.GetHashCode() ^ Feature.GetHashCode();
        }

    }
}
