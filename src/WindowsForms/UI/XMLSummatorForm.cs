using Metcom.XMLSummator.WindowsForms.Presentation.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            btnCreate.Click += (sender, args) => Invoke(CreataAmountFiles);
        }

        public new void Show()
        {
            _context.MainForm = this;
            Application.Run(_context);
        }

        public string FirstFileName { get { return txtFileNameFirst.Text; } }

        public string SecondFileName { get { return txtFileNameSecond.Text; } }
        public event Action CreataAmountFiles;

        public void ShowError(string errorMessage)
        {
            _context.MainForm = this;
            base.Show();
        }
        private void Invoke(Action action)
        {
            if (action != null) action();
        }
    }
}
