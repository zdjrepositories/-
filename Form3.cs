using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 大学生体质测评系统
{
    public partial class Form3 : Form
    {
        Form2_freshman_girl _form2;
        public Form3(Form2_freshman_girl form2)
        {
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            InitializeComponent();
            _form2 = form2;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label_name.Text = Form1_essential_information.student.name;
            label_sno.Text = Form1_essential_information.student.sno;
            label_grade.Text = Form1_essential_information.student.grade;
            label_gender.Text = Form1_essential_information.student.gender;
            label_score_50m.Text = Form1_essential_information.student.achievement_50m_score.ToString();
            label_evaluate_50m.Text = Form1_essential_information.student.achievement_50m_evaluate.ToString();
            label_score_bmi.Text = Form1_essential_information.student.bmi_score.ToString();
            label_evaluate_bmi.Text = Form1_essential_information.student.bmi_evaluate.ToString();
            label_score_abdominal_curl.Text = Form1_essential_information.student.pull_up_or_abdominal_curl_score.ToString();
            label_evaluate_abdominal_curl.Text = Form1_essential_information.student.pull_up_or_abdominal_curl_evaluate.ToString();
            label_score_endurance_run.Text = Form1_essential_information.student.achievement_endurance_run_score.ToString();
            label_evaluate_endurance_run.Text = Form1_essential_information.student.achievement_endurance_run_evaluate.ToString();
            label_score_standing_long_jump.Text = Form1_essential_information.student.standing_long_jump_score.ToString();
            label_evaluate_standing_long_jump.Text = Form1_essential_information.student.standing_long_jump_evaluate.ToString();
            label_score_three_dimensional_flexion.Text = Form1_essential_information.student.three_dimensional_flexion_score.ToString();
            label_evaluate_three_dimensional_flexion.Text = Form1_essential_information.student.three_dimensional_flexion_evaluate.ToString();
            label_score_vital_capacity.Text = Form1_essential_information.student.vital_capacity_score.ToString();
            //label_evaluate_vital_capacity.Text = Form1_essential_information.student.vital_capacity_evaluate.ToString();
            Form1_essential_information.student.set_evaluation_results();
            label_score_evaluation_results.Text = Form1_essential_information.student.evaluation_results.ToString();
            label_evaluate_evaluation_results.Text = Form1_essential_information.student.evaluation_results_evaluate.ToString();


        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
            _form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1_essential_information form1 = new Form1_essential_information();
            form1.Show();
            this.Close();
        }
    }
}
