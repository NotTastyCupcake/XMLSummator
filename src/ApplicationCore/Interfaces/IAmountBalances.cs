using Metcom.XMLSummator.ApplicationCore.Entities;
using Metcom.XMLSummator.ApplicationCore.Entities.ReportingAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Metcom.XMLSummator.ApplicationCore.Interfaces
{
    public interface IAmountBalances
    {
        BalanceData Amount(BalanceData FirstBalance, BalanceData SecondBalance); 
    }
}
