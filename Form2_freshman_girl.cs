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

    public partial class Form2_freshman_girl : Form
    {

        public Form2_freshman_girl()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label_name.Text = Form1_essential_information.student.name;
            label_sno.Text = Form1_essential_information.student.sno;
            label_grade.Text = Form1_essential_information.student.grade;
            label_gender.Text = Form1_essential_information.student.gender;
            if (Form1_essential_information.student.gender == "女")
            {
                label_1_endurance_run.Text = "800m";
                label_1_abdominal_curl.Text = "仰卧起坐";
            }

        }


        private void textBox_height_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Form1_essential_information.student.height = float.Parse(textBox_height.Text.ToString());
            }
            catch
            {
                textBox_height.Text = "";
            }
        }

        private void textBox_weight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox_weight.Text == "" && "".Equals(textBox_weight.Text))
                {
                    label_bmi.Text = "BMI: ";
                    label_evaluate_bmi.Text = "";
                    label_bmi.Text = "";
                    label_evaluate_bmi.Text = "";
                }
                else
                {
                    Form1_essential_information.student.weight = float.Parse(textBox_weight.Text.ToString());
                    Form1_essential_information.student.set_bmi_score();
                    label_bmi.Text = "BMI: " + Form1_essential_information.student.bmi.ToString("N1");
                    label_evaluate_bmi.Text = Form1_essential_information.student.bmi_evaluate;
                }

            }
            catch
            {
                textBox_weight.Text = "";
            }
        }

        private void textBox_50m_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox_50m.Text.ToString() != "" && !"".Equals(textBox_50m.Text.ToString()))
                {
                    Form1_essential_information.student.achievement_50m = (float)(Convert.ToSingle(textBox_50m.Text.ToString()));
                    float achievement = Form1_essential_information.student.achievement_50m;
                    Form1_essential_information.student.set_achievement_50m_Score();
                    label_score_50m.Text = Form1_essential_information.student.achievement_50m_score.ToString();
                    label_evaluate_50m.Text = Form1_essential_information.student.achievement_50m_evaluate;
                }
                else
                {
                    label_score_50m.Text = "";
                    label_evaluate_50m.Text = "";
                }
            }
            catch
            {
                textBox_50m.Text = "";
            }

        }

        private void textBox_vital_capacity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox_vital_capacity.Text.ToString() != "" && !"".Equals(textBox_vital_capacity.Text.ToString()))
                {
                    textBox_50m.LostFocus += textBox_50m_LostFocus;
                    float achievement = Form1_essential_information.student.vital_capacity = (float)Convert.ToSingle(textBox_vital_capacity.Text.ToString());
                    Form1_essential_information.student.set_vital_capacity_score();
                    label_score_vital_capacity.Text = Form1_essential_information.student.vital_capacity_score.ToString();
                    label_evaluate_vital_capacity.Text = Form1_essential_information.student.vital_capacity_evaluate;
                }
                else
                {
                    label_score_vital_capacity.Text = "";
                    label_evaluate_vital_capacity.Text = "";

                }
            }
            catch (Exception e2)
            {
                if (e2 == null)
                    textBox_vital_capacity.Text = "";
            }

        }

        void textBox_50m_LostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_50m.Text))
            {
                label_score_50m.Text = "";
                label_evaluate_50m.Text = "";
            }

        }

        private void textBox_Standing_long_jump_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Standing_long_jump.Text.ToString() != "" && !"".Equals(textBox_Standing_long_jump.Text.ToString()))
                {

                    Form1_essential_information.student.standing_long_jump = float.Parse(textBox_Standing_long_jump.Text.ToString());
                    Form1_essential_information.student.set_standing_long_jump_score();
                    label_score_Standing_long_jump.Text = Form1_essential_information.student.standing_long_jump_score.ToString();
                    label_evaluate_Standing_long_jump.Text = Form1_essential_information.student.standing_long_jump_evaluate.ToString();
                }
                else
                {
                    label_score_Standing_long_jump.Text = "";
                    label_evaluate_Standing_long_jump.Text = "";
                }
            }

            catch
            {
                textBox_Standing_long_jump.Text = "";
            }

        }


        private void textBox_800m_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox_endurance_run.Text.ToString() != "" && !"".Equals(textBox_endurance_run.Text.ToString()))
                {
                    Form1_essential_information.student.achievement_endurance_run = float.Parse(textBox_endurance_run.Text.ToString());
                    Form1_essential_information.student.set_achievement_endurance_run();
                    label_score_endurance_run.Text = Form1_essential_information.student.achievement_endurance_run_score.ToString();
                    label_evaluate_endurance_run.Text = Form1_essential_information.student.achievement_endurance_run_evaluate.ToString();
                }
                else
                {
                    label_score_endurance_run.Text = "";
                    label_evaluate_endurance_run.Text = "";
                }

            }
            catch
            {
                textBox_endurance_run.Text = "";
            }
        }

        private void textBox_Three_dimensional_flexion_TextChanged(object sender, EventArgs e)
        {

            textBox_Three_dimensional_flexion.LostFocus += textBox_Three_dimensional_flexion_LostFocus;

        }



        private void textBox_abdominal_curl_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox_abdominal_curl.Text.ToString() != "" && !"".Equals(textBox_abdominal_curl.Text.ToString()))
                {

                    Form1_essential_information.student.pull_up_or_abdominal_curl = Convert.ToInt32(textBox_abdominal_curl.Text.ToString());
                    Form1_essential_information.student.set_pull_up_or_abdominal_curl_score();
                    label_score_abdominal_curl.Text = Form1_essential_information.student.pull_up_or_abdominal_curl_score.ToString();
                    label_evaluate_abdominal_curl.Text = Form1_essential_information.student.pull_up_or_abdominal_curl_evaluate.ToString();
                }
                else
                {
                    label_score_abdominal_curl.Text = "";
                    label_evaluate_abdominal_curl.Text = "";
                }
            }
            catch
            {
                textBox_abdominal_curl.Text = "";
            }
        }
        void textBox_Three_dimensional_flexion_LostFocus(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Three_dimensional_flexion.Text.ToString() != "" && !"".Equals(textBox_Three_dimensional_flexion.Text.ToString()))
                {
                    int i = 1;
                    string text = textBox_Three_dimensional_flexion.Text.ToString();
                    if (text.Substring(0, 1) == "-")
                    {
                        i = -1;
                        text = text.Remove(0, 1);
                    }
                    Form1_essential_information.student.three_dimensional_flexion = float.Parse(text) * i;
                    Form1_essential_information.student.set_three_dimensional_flexion_score();
                    label_score_Three_dimensional_flexion.Text = Form1_essential_information.student.three_dimensional_flexion_score.ToString();
                    label_evaluate_Three_dimensional_flexion.Text = Form1_essential_information.student.three_dimensional_flexion_evaluate.ToString();
                }
                else {
                    label_score_Three_dimensional_flexion.Text = "";
                    label_evaluate_Three_dimensional_flexion.Text = "";
                }
            }
            catch { }
        }

        private void button_refuse_Click(object sender, EventArgs e)
        {
            textBox_50m.Text = "";
            textBox_abdominal_curl.Text = "";
            textBox_endurance_run.Text = "";
            textBox_height.Text = "";
            textBox_Standing_long_jump.Text = "";
            textBox_Three_dimensional_flexion.Text = "";
            textBox_vital_capacity.Text = "";
            textBox_weight.Text = "";
            label_bmi.Text = "";
            label_evaluate_bmi.Text = "";
            label_score_50m.Text = "";
            label_score_abdominal_curl.Text = "";
            label_score_endurance_run.Text = "";
            label_score_Standing_long_jump.Text = "";
            label_score_Three_dimensional_flexion.Text = "";
            label_score_vital_capacity.Text = "";
            label_evaluate_50m.Text = "";
            label_evaluate_abdominal_curl.Text = "";
            label_evaluate_endurance_run.Text = "";
            label_evaluate_Standing_long_jump.Text = "";
            label_evaluate_Three_dimensional_flexion.Text = "";
            label_evaluate_vital_capacity.Text = "";

        }
        public void button_confirm_Click(object sender, EventArgs e)
        {

            if (textBox_50m.Text == "" ||
            textBox_abdominal_curl.Text == "" ||
            textBox_endurance_run.Text == "" ||
            textBox_height.Text == "" ||
            textBox_Standing_long_jump.Text == "" ||
            textBox_Three_dimensional_flexion.Text == "" ||
            textBox_vital_capacity.Text == "" ||
            textBox_weight.Text == "")
            {
                MessageBox.Show("数据不可缺少！", "提示");
            }
            else
            {
                Form3 form3 = new Form3(this);
                form3.Show();
                this.Hide();
            }
        }
        private void button_back_Click(object sender, EventArgs e)
        {
            Form1_essential_information form1 = new Form1_essential_information();
            form1.Show();
            this.Close();
        }
    }
}
