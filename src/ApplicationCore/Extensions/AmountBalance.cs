using Metcom.XMLSummator.ApplicationCore.Entities;
using Metcom.XMLSummator.ApplicationCore.Entities.BalanceModel;
using Metcom.XMLSummator.ApplicationCore.Entities.BalanceModel.BalanceAbstractModel;
using Metcom.XMLSummator.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Metcom.XMLSummator.ApplicationCore.Extensions
{
    public class AmountBalance : IAmountBalances
    {


        public RootXMLForm Amount(RootXMLForm firstFileData, RootXMLForm secondFileData)
        {
            RootXMLForm res = new RootXMLForm()
            {
                MainFormAttrebute = firstFileData.MainFormAttrebute,
                PersonData = firstFileData.PersonData,
                FooterData = firstFileData.FooterData,
            };

            return null;

        }

        private T Entity<T>(ReportingBalanceBaseEntity reportingBalanceBaseEntity, ReportingBalanceBaseEntity reportingBalanceBaseEntityTwo)
            where T : ReportingBalanceBaseEntity
        {
            return null;
            
        }

    }
}
