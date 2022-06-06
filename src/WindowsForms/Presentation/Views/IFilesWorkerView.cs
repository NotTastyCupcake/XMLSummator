using Metcom.XMLSummator.WindowsForms.Presentation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Metcom.XMLSummator.WindowsForms.Presentation.Views
{
    public interface IFilesWorkerView : IView
    {
        string FirstFileName { get; }
        string SecondFileName { get; }
        string ResultFileName { get; }

        event Action CreataAmountFiles;
        void ShowError(string errorMessage);
    }
}
