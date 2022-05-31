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
        [XmlElement]
        /// <summary>
        /// Вид баланса (Баланс, ИтогоБаланс, ИтогоДовУпр, ВнебалСч и т.д)
        /// </summary>
        public string BalanceType { get; set; }

        [XmlAttribute]
        /// <summary>
        /// Валюта
        /// </summary>
        public string Currency { get; set; }
        [XmlAttribute]
        /// <summary>
        /// ПризнакАП
        /// </summary>
        public string Feature { get; set; }
        [XmlAttribute]
        /// <summary>
        /// Входящий остаток - ВхОст
        /// </summary>
        public int IncomingBalance { get; set; }
        [XmlAttribute]
        /// <summary>
        /// Оборот по дебету - ОбДеб
        /// </summary>
        public int DebitTurnover { get; set; }
        [XmlAttribute]
        /// <summary>
        /// Оборот по кридиту - ОбКр
        /// </summary>
        public int LoanTurnover { get; set; }
        [XmlAttribute]
        /// <summary>
        /// Исходящий остаток - ИсхОст
        /// </summary>
        public int OutgoingBalance { get; set; }
    }
}
