using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Metcom.XMLSummator.ApplicationCore.Entities
{
    public class ReportingBaseEntity : BaseEntity
    {
        /// <summary>
        /// Вид баланса (Баланс, ИтогоБаланс, ИтогоДовУпр, ВнебалСч и т.д)
        /// </summary>
        [XmlElement]
        public string BalanceType { get; set; }
        /// <summary>
        /// Валюта
        /// </summary>
        [XmlAttribute("Валюта")]
        public string Currency { get; set; }
        /// <summary>
        /// ПризнакАП
        /// </summary>
        [XmlAttribute("ПризнакАП")]
        public string Feature { get; set; }
        /// <summary>
        /// Входящий остаток - ВхОст
        /// </summary>
        [XmlAttribute("ВхОст")]
        public int IncomingBalance { get; set; }
        /// <summary>
        /// Оборот по дебету - ОбДеб
        /// </summary>
        [XmlAttribute("ОбДеб")]
        public int DebitTurnover { get; set; }
        /// <summary>
        /// Оборот по кридиту - ОбКр
        /// </summary>
        [XmlAttribute("ОбКр")]
        public int LoanTurnover { get; set; }
        /// <summary>
        /// Исходящий остаток - ИсхОст
        /// </summary>
        [XmlAttribute("ИсхОст")]
        public int OutgoingBalance { get; set; }
    }
}
