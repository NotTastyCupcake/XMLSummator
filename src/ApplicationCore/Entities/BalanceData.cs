using Metcom.XMLSummator.ApplicationCore.Entities.ReportingAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metcom.XMLSummator.ApplicationCore.Entities
{
    public class BalanceData
    {
        public ICollection<ReportingBalance> Balance { get; set; }
        
        public ICollection<ReportingTotalBalance> TotalBalance { get; set; }

    }
}
