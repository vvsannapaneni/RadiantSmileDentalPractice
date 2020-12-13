using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //var view = new View.Registration();

            //var repository = new Repositories.PatientRepository();
            //var Presenter = new DentalPractice.Presenter.PatientPresenter(view, repository);

            Application.Run(new View.Login());
        }
    }
}
