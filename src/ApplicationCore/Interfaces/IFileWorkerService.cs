using Metcom.XMLSummator.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metcom.XMLSummator.ApplicationCore.Interfaces
{
    public interface IFileWorkerService
    {
        void DeserializeReportForms(ICollection<StreamReader> streams);
        void AmountForms();
        void CreateResultFile(FileStream resultFile);
    }
}
