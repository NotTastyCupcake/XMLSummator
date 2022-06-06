using Metcom.XMLSummator.ApplicationCore.Entities;
using Metcom.XMLSummator.ApplicationCore.Entities.BalanceModel;
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
        ReportForm Amount(ReportForm firstFileData, ReportForm secondFileData);
        ReportForm Amount(ICollection<ReportForm> reportForms);
    }
}
