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
        string FileNameFirst { get; set; }
        string FileNameSecond { get; set; }
        string FileNameSave { get; set; }

        event Action CreataAmountFiles;
        event Action FileDialogFirst;
        event Action FileDialogSecond;
        event Action FileDialogSave;

        void ShowError(string errorMessage);
        void ShowSuccess(string successMessage);
    }
}
