using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metcom.XMLSummator.ApplicationCore.Entities
{
    public class ReportingBaseEntity : BaseEntity
    {
        /// <summary>
        /// Вид баланса (Баланс, ИтогоБаланс, ИтогоДовУпр, ВнебалСч и т.д)
        /// </summary>
        public string BalanceType { get; set; }

        /// <summary>
        /// Валюта
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// ПризнакАП
        /// </summary>
        public string Feature { get; set; }

        /// <summary>
        /// Входящий остаток - ВхОст
        /// </summary>
        public int IncomingBalance { get; set; }

        /// <summary>
        /// Оборот по дебету - ОбДеб
        /// </summary>
        public int DebitTurnover { get; set; }

        /// <summary>
        /// Оборот по кридиту - ОбКр
        /// </summary>
        public int LoanTurnover { get; set; }

        /// <summary>
        /// Исходящий остаток - ИсхОст
        /// </summary>
        public int OutgoingBalance { get; set; }
    }
}
