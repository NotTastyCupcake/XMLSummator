using Metcom.XMLSummator.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metcom.XMLSummator.ApplicationCore.Extensions
{
    public class ValidatorFile : IValidatorFile
    {
        public bool IsValidFormat()
        {
            throw new NotImplementedException();
        }

        public bool IsNotValidNameFile(string fileName) => string.IsNullOrWhiteSpace(fileName) & !fileName.EndsWith(".xml");

        public bool IsValidSizeFile(int fileSize)
        {
            throw new NotImplementedException();
        }
    }
}
