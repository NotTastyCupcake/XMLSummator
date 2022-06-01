using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Metcom.XMLSummator.ApplicationCore.Entities.ReportingModel.BalanceModel
{
    public class ReportingBalance : ReportingBalanceBaseEntity
    {
        [XmlAttribute("Счет2Пор")]
        /// <summary>
        /// Идентификатор клиента - Счет2Пор
        /// </summary>
        public int SecondOrderAccount { get; set; }

    }
}
