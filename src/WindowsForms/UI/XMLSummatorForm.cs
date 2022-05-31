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
        public XMLSummatorForm()
        {
            InitializeComponent();
        }

        public string FirstFileName => throw new NotImplementedException();

        public string SecondFileName => throw new NotImplementedException();

        public event Action CreataAmountFiles;

        public void ShowError(string errorMessage)
        {
            throw new NotImplementedException();
        }
    }
}
