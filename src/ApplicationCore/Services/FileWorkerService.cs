using Metcom.XMLSummator.ApplicationCore.Entities;
using Metcom.XMLSummator.ApplicationCore.Extensions;
using Metcom.XMLSummator.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metcom.XMLSummator.ApplicationCore.Services
{
    public class FileWorkerService : IFileWorkerService
    {
        private IValidatorFile _validatorFile = new ValidatorFile();
        private IAmountBalances _amountBalances = new AmountBalance();

        public void CreataAmountFiles(string firstFileName, string secondFileName)
        {

        }
    }
}
