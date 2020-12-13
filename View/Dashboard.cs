using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.View
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void wecomeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void patientRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var view = new View.Registration();
            var repository = new Repositories.PatientRepository();
            var Presenter = new DentalPractice.Presenter.PatientPresenter(view, repository);
            view.ShowDialog();
        }

        private void patientInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StaffInfo staffInfoForm = new StaffInfo();
            staffInfoForm.ShowDialog();
        }

        public void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
