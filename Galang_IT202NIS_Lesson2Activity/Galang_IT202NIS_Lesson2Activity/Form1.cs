using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galang_IT202NIS_Lesson2Activity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 8;

            dataGridView1.Columns[0].Name = "#";
            dataGridView1.Columns[1].Name = "Course Code";
            dataGridView1.Columns[2].Name = "Course Desc";
            dataGridView1.Columns[3].Name = "Unit Lec";
            dataGridView1.Columns[4].Name = "Unit Lab";
            dataGridView1.Columns[5].Name = "Credit Units";
            dataGridView1.Columns[6].Name = "Time";
            dataGridView1.Columns[7].Name = "Day";

            dataGridView1.AllowUserToAddRows = false;

            Program_cmbx.Items.Add("BSIT");
            Program_cmbx.Items.Add("BSCS");
            Program_cmbx.Items.Add("BSIS");

            labF_txtbx.Text = "1000";
            total_mscl_fee_txtbx.Text = "2000";
            cisco_lab_fee_txtbx.Text = "1500";
            exm_bklt_fee_txtbx.Text = "500";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {
           
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            unit_lecture_txtbx.Clear();
            unit_lab_txtbx.Clear();
            CreditsU_txtbx.Clear();
            course_code_txtbx.Clear();
            course_txtbx2.Clear();
            time_txtbx.Clear();
            day_txtbx.Clear();

            ttl_no_of_units_txtbx.Clear();
            ttl_tuitionFee_txtbx.Clear();
            ttl_tuitionNfee_txtbx.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double lec = 0;
            double lab = 0;

            double.TryParse(unit_lecture_txtbx.Text, out lec);
            double.TryParse(unit_lab_txtbx.Text, out lab);

            double credit = lec + lab;
            CreditsU_txtbx.Text = credit.ToString();

            dataGridView1.Rows.Add(
                dataGridView1.Rows.Count + 1,
                course_code_txtbx.Text,
                course_txtbx2.Text,
                lec,
                lab,
                credit,
                time_txtbx.Text,
                day_txtbx.Text
            );

            ComputeTotals();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void ttl_other_schlFee_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExmBklt_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void CSCLF_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void comlabF_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void ttl_tuitionNfee_txtbx2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ttl_no_of_units2_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void ttl_msclF2_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void ttl_tuitionFee_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void ttl_tuitionNfee_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void exm_bklt_fee_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void cisco_lab_fee_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void total_mscl_fee_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void ttl_tuitionF_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void labF_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void ttl_no_of_units_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreditsU_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void day_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void time_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void unit_lab_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void unit_lecture_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void course_code_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void course_txtbx2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void schlr_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void year_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void stdntN_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void Program_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void course_txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void browse_btn_Click(object sender, EventArgs e)
        {

        }
        private void ComputeTotals()
        {
            double totalUnits = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                totalUnits += Convert.ToDouble(row.Cells[5].Value);
            }

            ttl_no_of_units_txtbx.Text = totalUnits.ToString();
            ttl_no_of_units2_txtbx.Text = totalUnits.ToString();

            double tuitionPerUnit = 1500;                
            double tuition = totalUnits * tuitionPerUnit;

            ttl_tuitionFee_txtbx.Text = tuition.ToString();
            ttl_tuitionF_txtbx.Text = tuition.ToString();

            double misc = 2000;
            double lab = 1000;
            double cisco = 1500;
            double exam = 500;

            double grandTotal = tuition + misc + lab + cisco + exam;

            ttl_tuitionNfee_txtbx.Text = grandTotal.ToString();
            ttl_tuitionNfee_txtbx2.Text = grandTotal.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
