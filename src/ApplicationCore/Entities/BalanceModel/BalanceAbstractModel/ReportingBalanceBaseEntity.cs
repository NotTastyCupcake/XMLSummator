using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Metcom.XMLSummator.ApplicationCore.Entities.BalanceModel.BalanceAbstractModel
{
    public abstract class ReportingBalanceBaseEntity
    {
        [XmlIgnore]
        public string BalanceType;
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
        public long IncomingBalance { get; set; }

        /// <summary>
        /// Оборот по дебету - ОбДеб
        /// </summary>
        [XmlAttribute("ОбДеб")]
        public long DebitTurnover { get; set; }

        /// <summary>
        /// Оборот по кридиту - ОбКр
        /// </summary>
        [XmlAttribute("ОбКр")]
        public long LoanTurnover { get; set; }

        /// <summary>
        /// Исходящий остаток - ИсхОст
        /// </summary>
        [XmlAttribute("ИсхОст")]
        public long OutgoingBalance { get; set; }
    }
}
