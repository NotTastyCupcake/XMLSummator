using Metcom.XMLSummator.ApplicationCore.Interfaces;
using Metcom.XMLSummator.ApplicationCore.Services;
using Metcom.XMLSummator.WindowsForms.Presentation.Common;
using Metcom.XMLSummator.WindowsForms.Presentation.Presenters;
using Metcom.XMLSummator.WindowsForms.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metcom.XMLSummator.WindowsForms.UI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var controller = new ApplicationController(new LightInjectAdapder())
    .RegisterView<IFilesWorkerView, XMLSummatorForm>()
    .RegisterService<IFileWorkerService, FileWorkerService>()
    .RegisterInstance(new ApplicationContext());

            controller.Run<FileWorkerPresenter>();
        }
    }
}
