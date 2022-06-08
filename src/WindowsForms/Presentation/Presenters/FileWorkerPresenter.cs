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

            View.FileDialogFirst += () => FileDialogFirst();
            View.FileDialogSecond += () => FileDialogSecond();
            View.FileDialogSave += () => SaveFileDialog();

            View.CreataAmountFiles += () => CreateAmountFiles(View.FileNameFirst, View.FileNameSecond, View.FileNameSave);
        }

        private void FileDialogFirst()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "XML files (*.xml)|*.xml";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    View.FileNameFirst = openFileDialog.FileName;
                }
            }
        }

        private void FileDialogSecond()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "XML files (*.xml)|*.xml";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    View.FileNameSecond = openFileDialog.FileName;
                }
            }
        }

        private void SaveFileDialog()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "XML files (*.xml)|*.xml";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    View.FileNameSave = saveFileDialog.FileName;
                }
            }
        }

        private void CreateAmountFiles(string fileNameFirst, string fileNameSecond, string fileNameSave)
        {
            if (string.IsNullOrWhiteSpace(fileNameFirst) || string.IsNullOrWhiteSpace(fileNameSecond))
            {
                View.ShowError("Файлы не выбраны");
                return;
            }

            if (string.IsNullOrWhiteSpace(fileNameSave))
            {
                View.ShowError("Путь для сохранения не выбран");
                return;
            }


            if ( fileNameFirst == fileNameSecond )
            {
                DialogResult res = MessageBox.Show("Вы выбрали один и тот же файл. Продолжить?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.Cancel)
                {
                    return;
                }
            }

            StreamReader[] streamReaders = null;
            FileStream fileStream = null;

            try
            {

                streamReaders = new StreamReader[]
                {
                new StreamReader(fileNameSecond, Encoding.GetEncoding(1251)),
                new StreamReader(fileNameSecond, Encoding.GetEncoding(1251))
                };

                fileStream = File.Create(fileNameSave);
                _service.DeserializeReportForms(streamReaders);
                _service.AmountForms();
                _service.CreateResultFile(fileStream);
                View.ShowSuccess("Файл успешно создан");

            }
            catch (Exception ex)
            {
                
                View.ShowError(ex.Message);
            }
            finally
            {
                if (streamReaders != null) { Array.ForEach(streamReaders, sr => sr.Close()); }
                if (fileStream != null) { fileStream.Close(); }                
            }

        }
        

    }

}
