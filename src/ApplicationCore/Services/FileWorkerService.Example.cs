using Metcom.XMLSummator.ApplicationCore.Entities;
using Metcom.XMLSummator.ApplicationCore.Extensions;
using Metcom.XMLSummator.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Metcom.XMLSummator.ApplicationCore.Services
{
    public class FileWorkerService : IFileWorkerService
    {
        private IValidatorFile _validatorFile = new ValidatorFile();
        private IAmountBalances _amountBalances = new AmountBalance();

        public void CreataAmountFiles(string firstFileName, string secondFileName)
        {
            XDocument firstXDoc = XDocument.Load(firstFileName);
            // получаем корневой узел
            XElement firstPeople = firstXDoc.Element("people");
            if (firstPeople != null)
{
                // проходим по всем элементам person
                foreach (XElement person in firstPeople.Elements("person"))
                {

                    XAttribute name = person.Attribute("name");
                    XElement company = person.Element("company");
                    XElement age = person.Element("age");

                }
            }

            XDocument xdoc = XDocument.Load(secondFileName);
            // получаем корневой узел
            XElement people = firstXDoc.Element("people");
            if (firstPeople != null)
            {
                // проходим по всем элементам person
                foreach (XElement person in firstPeople.Elements("person"))
                {

                    XAttribute name = person.Attribute("name");
                    XElement company = person.Element("company");
                    XElement age = person.Element("age");

                }
            }
        }
    }
}
