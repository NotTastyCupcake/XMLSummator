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
        private readonly ApplicationContext _context;

        public XMLSummatorForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();

            btnFileDialog.Click += (sender, args) => Invoke(FileDialogFirst);
            btnFileDialog2.Click += (sender, args) => Invoke(FileDialogSecond);

            btnSaveFile.Click += (sender, args) => Invoke(FileDialogSave);

            btnCreate.Click += (sender, args) => Invoke(CreataAmountFiles);
        }

        public new void Show()
        {
            _context.MainForm = this;
            Application.Run(_context);
        }
        
        public string FileNameFirst { get { return txtFileNameFirst.Text; } set { txtFileNameFirst.Text = value; } }
        public string FileNameSecond { get { return txtFileNameSecond.Text; } set { txtFileNameSecond.Text = value; } }
        public string FileNameSave { get { return txtResultFileName.Text; } set { txtResultFileName.Text = value; } }

        public event Action CreataAmountFiles;
        public event Action FileDialogFirst;
        public event Action FileDialogSecond;
        public event Action FileDialogSave;

        public void ShowError(string errorMessage)
        {
            labError.Visible = true;
            labError.Text = errorMessage;
        }

        private void Invoke(Action action)
        {
            action?.Invoke();
        }

    }
}
