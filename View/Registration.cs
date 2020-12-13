using DentalPractice.Model;
using DentalPractice.Presenter;
using DentalPractice.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.View
{
    public partial class Registration : Form, IRegistraionView
    {

        public Registration()
        {
            InitializeComponent();
            this.PatientId = 0;
            this.IsNhs = false;
        }

        public IList<Patients> PatientList
        {
            get { return (IList<Patients>)this.dataGridView1.DataSource; }
            set { this.dataGridView1.DataSource = value; }
        }

        public int PatientId
        {
            get { return Convert.ToInt32(this.txtPatientId.Text); }
            set { this.txtPatientId.Text = value.ToString(); }
        }
        public string PatientName { get { return this.txtPatientName.Text; } set { this.txtPatientName.Text = value; } }
        public string Address { get { return this.txtPatientAddress.Text; } set { this.txtPatientAddress.Text = value; } }
        public DateTime? DateOfBirth { get { return Convert.ToDateTime(dateTimePicker1.Text); } set { this.dateTimePicker1.Text = value.ToString(); } }
        public bool IsNhs { get { return Convert.ToBoolean(chkIsNhs.Text); } set { this.chkIsNhs.Text = value.ToString(); } }
        public int SelectedPatient { get { return PatientId; } set { PatientId = value; } }
        public string MedicalHistory { get { return Convert.ToString(txtPatientHistory.Text); } set { this.txtPatientHistory.Text = value; } }
        public string Email { get { return Convert.ToString(txtPatientEmail.Text); } set { this.txtPatientEmail.Text = value.ToString(); } }
        public DateTime LastVisitedDate { get => new DateTime(); set => this.LastVisitedDate = value; }
        public string GpName { get { return txtGpName.Text; } set { txtGpName.Text = value ; } }
        public string GpAddress { get { return txtGpAddress.Text; } set { txtGpAddress.Text = value; } }
        public PatientPresenter Presenter { get; set; }


        private void Registration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dentalPracticeDataSet1.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.dentalPracticeDataSet1.Patients);
            // TODO: This line of code loads data into the 'dentalPracticeDataSet2.Patients' table. You can move, or remove it, as needed.
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            this.chkIsNhs.Checked = chkIsNhs.Checked ? true : false;
            this.txtPatientId.Hide();
            this.label5.Hide();

            var editButton = new DataGridViewButtonColumn();
            editButton.Name = "dataGridViewDeleteButton";
            editButton.HeaderText = "Edit";
            editButton.Text = "Edit";
            editButton.UseColumnTextForButtonValue = true;
            this.dataGridView1.Columns.Add(editButton);

            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            this.dataGridView1.Columns.Add(deleteButton);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowId = e.RowIndex;
            var columnId = e.ColumnIndex;
            var selectedID = dataGridView1.Rows[rowId].Cells[0].Value;

            if (columnId == 10)
            {
                chkIsNhs.Checked = Convert.ToBoolean(dataGridView1.Rows[rowId].Cells[6].Value);
                txtPatientId.Text = selectedID?.ToString();
                Presenter.Edit(Convert.ToInt32(selectedID));
            }
            else if (columnId == 11)
            {
                int isDeleted = Presenter.Delete(Convert.ToInt32(selectedID));
                if (isDeleted > 0)
                {
                    MessageBox.Show("Patient Record Deleted Successfully..!");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                Presenter.Save();
                ClearAll();
            }

        }

        private bool ValidateForm()
        {
            bool error = false;
            if (string.IsNullOrEmpty(this.txtPatientName.Text))
            {
                error = true;
            }
            else if (string.IsNullOrEmpty(this.txtPatientAddress.Text))
            {
                error = true;
            }
            else if (string.IsNullOrEmpty(this.dateTimePicker1.Text))
            {
                error = true;
            }
            else if (string.IsNullOrEmpty(this.txtPatientHistory.Text))
            {
                error = true;
            }
            else if (string.IsNullOrEmpty(this.txtPatientEmail.Text))
            {
                error = true;
            }
            if (error)
                MessageBox.Show("Please Enter All the Values");
            return error;
        }

        private void ClearAll()
        {
            this.txtPatientName.Clear();
            this.txtPatientAddress.Clear();
            this.txtPatientHistory.Clear();
            this.txtPatientName.Clear();
            this.txtPatientEmail.Clear();
            this.chkIsNhs.Checked = false;
            this.dateTimePicker1.Text = DateTime.Now.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                int isDataSaved = Presenter.Save();
                if (isDataSaved > 0)
                {
                    string message = "Data Saved Successfully..!";
                    string title = "Alert";
                    MessageBox.Show(message, title);
                    ClearAll();
                }

            }
        }

        private void ChkIsNhs_CheckedChanged(object sender, EventArgs e)
        {
            this.chkIsNhs.Checked = this.chkIsNhs.Checked ? true : false;
            this.IsNhs = chkIsNhs.Checked ? true : false;
        }

        //private void fillByToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.patientsTableAdapter1.FillBy(this.dentalPracticeDataSet1.Patients);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        //private void fillByToolStripButton1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.patientsTableAdapter.FillBy(this.dentalPracticeDataSet.Patients);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        //private void fillByToolStripButton2_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.patientsTableAdapter.FillBy(this.dentalPracticeDataSet.Patients);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}
    }
}
