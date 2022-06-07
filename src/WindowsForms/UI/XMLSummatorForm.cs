using Metcom.XMLSummator.WindowsForms.Presentation.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metcom.XMLSummator.WindowsForms.UI
{
    public partial class XMLSummatorForm : Form, IFilesWorkerView
    {
        private readonly StreamReader[] _streamReaders;
        private FileStream _resultStream;
        private readonly ApplicationContext _context;

        public XMLSummatorForm(ApplicationContext context)
        {
            _streamReaders = new StreamReader[2];
            _context = context;
            InitializeComponent();

            btnFileDialog.Click += (sender, args) => InvokeFileDialogFirst();
            btnFileDialog2.Click += (sender, args) => InvokeFileDialogSecond();

            btnSaveFile.Click += (sender, args) => InvokeSaveFileDialog();

            btnCreate.Click += (sender, args) => Invoke(CreataAmountFiles);
        }

        public new void Show()
        {
            _context.MainForm = this;
            Application.Run(_context);
        }

        public ICollection<StreamReader> StreamReaders { get { return _streamReaders; } }
        public FileStream ResultStream { get { return _resultStream; } }

        public event Action CreataAmountFiles;

        public void ShowError(string errorMessage)
        {
            labError.Visible = true;
            labError.Text = errorMessage;
        }

        private void Invoke(Action action)
        {
            if (action != null) action();
        }

        #region Нужно вынести
        private void InvokeFileDialogFirst()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "XML files (*.xml)|*.xml";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    txtFileNameFirst.Text = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                    _streamReaders[0] = new StreamReader(fileStream, Encoding.GetEncoding(1251));
                }
            }
        }

        private void InvokeFileDialogSecond()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "XML files (*.xml)|*.xml";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFileNameSecond.Text = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                    _streamReaders[1] = new StreamReader(fileStream, Encoding.GetEncoding(1251));
                }
            }
        }

        private void InvokeSaveFileDialog()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "XML files (*.xml)|*.xml";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtResultFileName.Text = saveFileDialog.FileName;

                    _resultStream = File.Create(saveFileDialog.FileName);
                }
            }
        }
        #endregion

    }
}
