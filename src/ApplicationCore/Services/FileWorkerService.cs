using Metcom.XMLSummator.ApplicationCore.Entities;
using Metcom.XMLSummator.ApplicationCore.Entities.ReportingModel;
using Metcom.XMLSummator.ApplicationCore.Extensions;
using Metcom.XMLSummator.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Metcom.XMLSummator.ApplicationCore.Services
{
    public class FileWorkerService : IFileWorkerService
    {
        private IValidatorFile _validatorFile = new ValidatorFile();
        private IAmountBalances _amountBalances = new AmountBalance();

        public void CreataAmountFiles(string firstFileName, string secondFileName)
        {
            // Now we can read the serialized book ...  
            XmlSerializer reader = new XmlSerializer(typeof(BalanceCollection));
            StreamReader file = new StreamReader(firstFileName);
            BalanceCollection overview = (BalanceCollection)reader.Deserialize(file);
            file.Close();
        }
    }
}
