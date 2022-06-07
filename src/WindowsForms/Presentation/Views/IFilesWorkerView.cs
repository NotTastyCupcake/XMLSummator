using Metcom.XMLSummator.WindowsForms.Presentation.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Metcom.XMLSummator.WindowsForms.Presentation.Views
{
    public interface IFilesWorkerView : IView
    {
        ICollection<StreamReader> StreamReaders { get; }
        FileStream ResultStream { get; }

        event Action CreataAmountFiles;

        void ShowError(string errorMessage);
    }
}
