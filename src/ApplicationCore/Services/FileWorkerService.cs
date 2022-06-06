using Metcom.XMLSummator.ApplicationCore.Entities;
using Metcom.XMLSummator.ApplicationCore.Entities.BalanceModel;
using Metcom.XMLSummator.ApplicationCore.Extensions;
using Metcom.XMLSummator.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Metcom.XMLSummator.ApplicationCore.Services
{
    public class FileWorkerService : IFileWorkerService
    {
        private IValidatorFile _validatorFile = new ValidatorFile();
        private IAmountBalances _amountBalances = new AmountBalance();

        public bool CreataAmountFiles(string firstFileName, string secondFileName)
        {

            // Now we can read the serialized book ...  
            XmlSerializer serialize = new XmlSerializer(typeof(RootXMLForm));
            StreamReader fileFirst = new StreamReader(firstFileName, Encoding.GetEncoding(1251));
            RootXMLForm formFirst = (RootXMLForm)serialize.Deserialize(fileFirst);
            fileFirst.Close();
            
            StreamReader fileSecond = new StreamReader(secondFileName, Encoding.GetEncoding(1251));
            RootXMLForm formSecond = (RootXMLForm)serialize.Deserialize(fileSecond);
            fileSecond.Close();


            RootXMLForm res = _amountBalances.Amount(formFirst, formSecond);

            XmlWriterSettings writerSettings = new XmlWriterSettings();
            writerSettings.Encoding = Encoding.GetEncoding(1251);
            writerSettings.Indent = true;
            
            FileStream writer = File.Create(firstFileName);
            XmlWriter xwriter = XmlWriter.Create(writer, writerSettings);
            xwriter.WriteProcessingInstruction("xml", "version=\"1.0\" encoding=\"windows - 1251\" standalone=\"yes\"");
            serialize.Serialize(xwriter, res);

            writer.Close();

            return false;
        }
    }
}
