using DentalPractice.Model;
using DentalPractice.Presenter;
using DentalPractice.View;
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
    public partial class StaffInfo : Form, IStaffView
    {
        public StaffInfo()
        {
            InitializeComponent();
        }
        public IList<PracticeStaff> StaffList
        {

            get { return (IList<PracticeStaff>)this.dataGridView1.DataSource; }
            set { this.dataGridView1.DataSource = value; }

        }
        public int StaffId
        {
            get { return Convert.ToInt32(this.textStaffId.Text); }
            set { this.textStaffId.Text = value.ToString(); }
        }
        public string StaffName { get { return this.txtStaffName.Text; } set { this.txtStaffName.Text = value; } }
        public int Specialization
        {
            get { return Convert.ToInt32(this.cmbSpecialzation.Text); }
            set { this.cmbSpecialzation.Text = value.ToString(); }
        }
        public int Status
        {
            get { return Convert.ToInt32(this.cmbStatus.Text); }
            set { this.cmbStatus.Text = value.ToString(); }
        }
        public bool ApplyLeave { get { return Convert.ToBoolean(chkIsLeave.Text); } set { this.chkIsLeave.Text = value.ToString(); } }
        public DateTime? LeaveFrom
        {
            get { return Convert.ToDateTime(dtLevaeFrom.Text); }
            set { this.dtLevaeFrom.Text = value.ToString(); }
        }
        public DateTime? LeaveTo
        {
            get { return Convert.ToDateTime(dtLeaveTo.Text); }
            set { this.dtLeaveTo.Text = value.ToString(); }
        }
        public  string StatusDescription { get; set; }
        public string SpecializationDesc { get; set; }
        public List<string> SevicesList { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<string> StatusList { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public StaffPresenter StaffPresenter { get; set; }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.addStaffToolStripMenuItem_Click(sender, e);
        }

        private void StaffInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
