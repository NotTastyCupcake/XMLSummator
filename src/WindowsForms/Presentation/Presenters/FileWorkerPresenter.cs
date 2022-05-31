using Metcom.XMLSummator.ApplicationCore.Interfaces;
using Metcom.XMLSummator.WindowsForms.Presentation.Common;
using Metcom.XMLSummator.WindowsForms.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metcom.XMLSummator.WindowsForms.Presentation.Presenters
{
    public class FileWorkerPresenter : BasePresenter<IFilesWorkerView>
    {
        private readonly IFileWorkerService _service;

        public FileWorkerPresenter(IApplicationController controller, IFilesWorkerView view, IFileWorkerService service) : base(controller, view)
        {
            _service = service;

            View.CreataAmountFiles += () => CreataAmountFiles(View.FirstFileName, View.SecondFileName);
        }

        private void CreataAmountFiles(string firstFileName, string secondFileName)
        {
            if (string.IsNullOrWhiteSpace(firstFileName))
            {
                throw new ArgumentNullException(firstFileName);
            }
            if (string.IsNullOrWhiteSpace(secondFileName))
            {
                throw new ArgumentNullException(secondFileName);
            }



        }
    }
}
