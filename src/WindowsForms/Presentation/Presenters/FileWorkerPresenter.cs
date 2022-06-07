using Metcom.XMLSummator.ApplicationCore.Interfaces;
using Metcom.XMLSummator.WindowsForms.Presentation.Common;
using Metcom.XMLSummator.WindowsForms.Presentation.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metcom.XMLSummator.WindowsForms.Presentation.Presenters
{
    public class FileWorkerPresenter : BasePresenter<IFilesWorkerView>
    {
        private readonly IFileWorkerService _service;

        public FileWorkerPresenter(IApplicationController controller, IFilesWorkerView view, IFileWorkerService service) : base(controller, view)
        {
            _service = service;

            View.CreataAmountFiles += () => CreateAmountFiles(View.StreamReaders, View.ResultStream);
        }

        private void CreateAmountFiles(ICollection<StreamReader> streamReaders, FileStream fileStream)
        {
            if (fileStream == null)
            {
                View.ShowError("Путь для сохранения не выбран");
                return;
            }

            if (streamReaders == null || streamReaders.Contains(null))
            {
                View.ShowError("Файлы не выбраны");
                return;
            }
            

            if(streamReaders.Distinct().Count() == streamReaders.Count())
            {
                DialogResult res = MessageBox.Show("Вы выбрали один и тот же файл. Продолжить?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.Cancel)
                {
                    return;
                }
            }


            _service.DeserializeReportForms(streamReaders);
            _service.AmountForms();
            _service.CreateResultFile(fileStream);
            View.Close();
        }
    }
}
