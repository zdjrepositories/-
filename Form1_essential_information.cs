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
    public partial class Form1_essential_information : Form
    {

        public Form1_essential_information()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
        }


        public static Student student = new Student();



        
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void 大学生体质测评系统_Load(object sender, EventArgs e)
        {
            student.gender = "男";
            student.grade = "大一";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            student.name = textBox_name.Text.ToString();
        }

        private void textBox_sno_TextChanged(object sender, EventArgs e)
        {
            student.sno = textBox_Sno.Text.ToString();
        }



        private void radioButton_boy_CheckedChanged(object sender, EventArgs e)
        {
            student.gender = "男";
        }

        private void radioButton_girl_CheckedChanged(object sender, EventArgs e)
        {
            student.gender = "女";
        }

        private void radioButton_freshman_CheckedChanged(object sender, EventArgs e)
        {
            student.grade = "大一";
        }

        private void radioButton_sophomore_CheckedChanged_1(object sender, EventArgs e)
        {
            student.grade = "大二";
        }

        private void radioButton_junior_CheckedChanged(object sender, EventArgs e)
        {
            student.grade = "大三";
        }

        private void radioButton_senior_CheckedChanged(object sender, EventArgs e)
        {
            student.grade = "大四";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void button_confirm_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text == null || textBox_name.Text.Equals(""))
            {
                MessageBox.Show("请输入姓名！");
            }
            else if (textBox_Sno.Text == null || textBox_Sno.Text.Equals(""))
            {
                MessageBox.Show("请输入学号！");
            }
            else 
            {
                Form2_freshman_girl form2 = new Form2_freshman_girl();
                form2.Show();
                this.Hide();

            }
             
           
           
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            textBox_name.Text = "";
            textBox_Sno.Text = "";
        }

        
    }


    public class Student {

        public string name;

        public string gender; //性别

        public string grade;

        public string sno;

        public float height;
        public int height_score;
        public string height_evaluate;

        public float weight;
        public int weight_score;
        public string weight_evaluate;
        /*float achievement = this.achievement_50m;
                int score;
                string evaluate;
           if (this.gender == "女") { 
                if (this.grade == "大一" || this.grade == "大二") { }
                if (this.grade == "大一" || this.grade == "大二") { }
            }
            if (this.gender == "男") {
                if (this.grade == "大一" || this.grade == "大二") { }
                if (this.grade == "大一" || this.grade == "大二") { }
            }
         */
        public float bmi;
        public int bmi_score;
        public string bmi_evaluate;
        public void set_bmi_score() {
            float achievement = this.bmi = this.weight / this.height /this.height;
            if (this.gender == "女") {
                if (achievement <= 17.1) {
                    this.bmi_score = 80;
                    this.bmi_evaluate = "低体重";
                }
                else
                    if (achievement <= 23.9) {
                        this.bmi_score = 100;
                        this.bmi_evaluate = "正常";
                    }
                    else
                        if (achievement <= 27.9) {
                            this.bmi_score = 80;
                            this.bmi_evaluate = "超重";
                        }
                        else
                            if (achievement >= 28) {
                                this.bmi_score = 60;
                                this.bmi_evaluate = "肥胖";
                            }
               
            }
            if (this.gender == "男") {
                if (achievement <= 17.8)
                {
                    this.bmi_score = 80;
                    this.bmi_evaluate = "低体重";
                }
                else
                    if (achievement <= 23.9)
                    {
                        this.bmi_score = 100;
                        this.bmi_evaluate = "正常";
                    }
                    else
                        if (achievement <= 27.9)
                        {
                            this.bmi_score = 80;
                            this.bmi_evaluate = "超重";
                        }
                        else
                            if (achievement >= 28)
                            {
                                this.bmi_score = 60;
                                this.bmi_evaluate = "肥胖";
                            }
               
            }
            
        }

        public float achievement_50m;
        public int achievement_50m_score;
        public void set_achievement_50m_Score() {
                float achievement = this.achievement_50m;
                int score;
                string evaluate;
                if (this.gender == "女"){
                    if (this.grade == "大一"||this.grade == "大二") {

                        if (achievement <= 7.5)
                            score = 100;
                        else
                            if (achievement <= 7.6)
                                score = 95;
                            else
                                if (achievement <= 7.7)
                                    score = 90;
                                else
                                    if (achievement <= 8.0)
                                        score = 85;
                                    else
                                        if (achievement <= 8.3)
                                            score = 80;
                                        else
                                            if (achievement <= 8.5)
                                                score = 78;
                                            else
                                                if (achievement <= 8.7)
                                                    score = 76;
                                                else
                                                    if (achievement <= 8.9)
                                                        score = 74;
                                                    else
                                                        if (achievement <= 9.1)
                                                            score = 72;
                                                        else
                                                            if (achievement <= 9.3)
                                                                score = 70;
                                                            else
                                                                if (achievement <= 9.5)
                                                                    score = 68;
                                                                else
                                                                    if (achievement <= 9.7)
                                                                        score = 66;
                                                                    else
                                                                        if (achievement <= 9.9)
                                                                            score = 64;
                                                                        else
                                                                            if (achievement <= 10.1)
                                                                                score = 62;
                                                                            else
                                                                                if (achievement <= 10.3)
                                                                                    score = 60;
                                                                                else
                                                                                    if (achievement <= 10.5)
                                                                                        score = 50;
                                                                                    else
                                                                                        if (achievement <= 10.7)
                                                                                            score = 40;
                                                                                        else
                                                                                            if (achievement <= 10.9)
                                                                                                score = 30;
                                                                                            else
                                                                                                if (achievement <= 11.1)
                                                                                                    score = 20;
                                                                                                else
                                                                                                    if (achievement <= 11.3)
                                                                                                        score = 10;
                                                                                                    else
                                                                                                        score = 10;

                        if (score >= 90)
                            evaluate = "优秀";
                        else
                            if (score >= 80)
                                evaluate = "良好";
                            else
                                if (score >= 60)
                                    evaluate = "及格";
                                else
                                    evaluate = "不及格";
                        this.achievement_50m_score = score;
                        this.achievement_50m_evaluate = evaluate;

                    }
                    
                    if (this.grade == "大三"||this.grade == "大四") {

                        if (achievement <= 7.4)
                            score = 100;
                        else
                            if (achievement <= 7.5)
                                score = 95;
                            else
                                if (achievement <= 7.6)
                                    score = 90;
                                else
                                    if (achievement <= 7.9)
                                        score = 85;
                                    else
                                        if (achievement <= 8.2)
                                            score = 80;
                                        else
                                            if (achievement <= 8.4)
                                                score = 78;
                                            else
                                                if (achievement <= 8.6)
                                                    score = 76;
                                                else
                                                    if (achievement <= 8.8)
                                                        score = 74;
                                                    else
                                                        if (achievement <= 9.0)
                                                            score = 72;
                                                        else
                                                            if (achievement <= 9.2)
                                                                score = 70;
                                                            else
                                                                if (achievement <= 9.4)
                                                                    score = 68;
                                                                else
                                                                    if (achievement <= 9.6)
                                                                        score = 66;
                                                                    else
                                                                        if (achievement <= 9.8)
                                                                            score = 64;
                                                                        else
                                                                            if (achievement <= 10)
                                                                                score = 62;
                                                                            else
                                                                                if (achievement <= 10.2)
                                                                                    score = 60;
                                                                                else
                                                                                    if (achievement <= 10.4)
                                                                                        score = 50;
                                                                                    else
                                                                                        if (achievement <= 10.6)
                                                                                            score = 40;
                                                                                        else
                                                                                            if (achievement <= 10.8)
                                                                                                score = 30;
                                                                                            else
                                                                                                if (achievement <= 11)
                                                                                                    score = 20;
                                                                                                else
                                                                                                    if (achievement <= 11.2)
                                                                                                        score = 10;
                                                                                                    else
                                                                                                        score = 10;

                        if (score >= 90)
                            evaluate = "优秀";
                        else
                            if (score >= 80)
                                evaluate = "良好";
                            else
                                if (score >= 60)
                                    evaluate = "及格";
                                else
                                    evaluate = "不及格";
                        this.achievement_50m_score = score;
                        this.achievement_50m_evaluate = evaluate;
                    }
                }
                if (this.gender == "男") {
                    if (this.grade == "大一"||this.grade == "大二") {
                        if (achievement <= 6.7)
                            score = 100;
                        else
                            if (achievement <= 6.8)
                                score = 95;
                            else
                                if (achievement <= 6.9)
                                    score = 90;
                                else
                                    if (achievement <= 7.0)
                                        score = 85;
                                    else
                                        if (achievement <= 7.1)
                                            score = 80;
                                        else
                                            if (achievement <= 7.3)
                                                score = 78;
                                            else
                                                if (achievement <= 7.5)
                                                    score = 76;
                                                else
                                                    if (achievement <= 7.7)
                                                        score = 74;
                                                    else
                                                        if (achievement <= 7.9)
                                                            score = 72;
                                                        else
                                                            if (achievement <= 8.1)
                                                                score = 70;
                                                            else
                                                                if (achievement <= 8.3)
                                                                    score = 68;
                                                                else
                                                                    if (achievement <= 8.5)
                                                                        score = 66;
                                                                    else
                                                                        if (achievement <= 8.7)
                                                                            score = 64;
                                                                        else
                                                                            if (achievement <= 8.9)
                                                                                score = 62;
                                                                            else
                                                                                if (achievement <= 9.1)
                                                                                    score = 60;
                                                                                else
                                                                                    if (achievement <= 9.3)
                                                                                        score = 50;
                                                                                    else
                                                                                        if (achievement <= 9.5)
                                                                                            score = 40;
                                                                                        else
                                                                                            if (achievement <= 9.7)
                                                                                                score = 30;
                                                                                            else
                                                                                                if (achievement <= 9.9)
                                                                                                    score = 20;
                                                                                                else
                                                                                                    if (achievement <= 10.1)
                                                                                                        score = 10;
                                                                                                    else
                                                                                                        score = 10;

                        if (score >= 90)
                            evaluate = "优秀";
                        else
                            if (score >= 80)
                                evaluate = "良好";
                            else
                                if (score >= 60)
                                    evaluate = "及格";
                                else
                                    evaluate = "不及格";
                        this.achievement_50m_score = score;
                        this.achievement_50m_evaluate = evaluate;
                    }
                    
                    if (this.grade == "大三"||this.grade == "大四") {
                        if (achievement <= 6.6)
                            score = 100;
                        else
                            if (achievement <= 6.7)
                                score = 95;
                            else
                                if (achievement <= 6.8)
                                    score = 90;
                                else
                                    if (achievement <= 6.9)
                                        score = 85;
                                    else
                                        if (achievement <= 7.0)
                                            score = 80;
                                        else
                                            if (achievement <= 7.2)
                                                score = 78;
                                            else
                                                if (achievement <= 7.4)
                                                    score = 76;
                                                else
                                                    if (achievement <= 7.6)
                                                        score = 74;
                                                    else
                                                        if (achievement <= 7.8)
                                                            score = 72;
                                                        else
                                                            if (achievement <= 8)
                                                                score = 70;
                                                            else
                                                                if (achievement <= 8.2)
                                                                    score = 68;
                                                                else
                                                                    if (achievement <= 8.4)
                                                                        score = 66;
                                                                    else
                                                                        if (achievement <= 8.6)
                                                                            score = 64;
                                                                        else
                                                                            if (achievement <= 8.8)
                                                                                score = 62;
                                                                            else
                                                                                if (achievement <= 9)
                                                                                    score = 60;
                                                                                else
                                                                                    if (achievement <= 9.2)
                                                                                        score = 50;
                                                                                    else
                                                                                        if (achievement <= 9.4)
                                                                                            score = 40;
                                                                                        else
                                                                                            if (achievement <= 9.6)
                                                                                                score = 30;
                                                                                            else
                                                                                                if (achievement <= 9.8)
                                                                                                    score = 20;
                                                                                                else
                                                                                                    if (achievement <= 10)
                                                                                                        score = 10;
                                                                                                    else
                                                                                                        score = 10;

                        if (score >= 90)
                            evaluate = "优秀";
                        else
                            if (score >= 80)
                                evaluate = "良好";
                            else
                                if (score >= 60)
                                    evaluate = "及格";
                                else
                                    evaluate = "不及格";

                        this.achievement_50m_score = score;
                        this.achievement_50m_evaluate = evaluate;
                    }
                }
        }
        public string achievement_50m_evaluate;


        public float vital_capacity; // 肺活量
        public int vital_capacity_score;
        public string vital_capacity_evaluate;
        public void set_vital_capacity_score() {
            float achievement = this.vital_capacity;
            int score;
            string evaluate;
            if (this.gender == "女")
            {
                if (this.grade == "大一" || this.grade == "大二") {
                    if (achievement >= 3400)
                        score = 100;
                    else
                        if (achievement >= 3350)
                            score = 95;
                        else
                            if (achievement >= 3300)
                                score = 90;
                            else
                                if (achievement >= 3150)
                                    score = 85;
                                else
                                    if (achievement >= 3000)
                                        score = 80;
                                    else
                                        if (achievement >= 2900)
                                            score = 78;
                                        else
                                            if (achievement >= 2800)
                                                score = 76;
                                            else
                                                if (achievement >= 2700)
                                                    score = 74;
                                                else
                                                    if (achievement >= 2600)
                                                        score = 72;
                                                    else
                                                        if (achievement >= 2500)
                                                            score = 70;
                                                        else
                                                            if (achievement >= 2400)
                                                                score = 68;
                                                            else
                                                                if (achievement >= 2300)
                                                                    score = 66;
                                                                else
                                                                    if (achievement >= 2200)
                                                                        score = 64;
                                                                    else
                                                                        if (achievement >= 2100)
                                                                            score = 62;
                                                                        else
                                                                            if (achievement >= 2000)
                                                                                score = 60;
                                                                            else
                                                                                if (achievement >= 1960)
                                                                                    score = 50;
                                                                                else
                                                                                    if (achievement >= 1920)
                                                                                        score = 40;
                                                                                    else
                                                                                        if (achievement >= 1880)
                                                                                            score = 30;
                                                                                        else
                                                                                            if (achievement >= 1840)
                                                                                                score = 20;
                                                                                            else
                                                                                                if (achievement >= 1880)
                                                                                                    score = 10;
                                                                                                else
                                                                                                    score = 10;

                    if (score >= 90)
                        evaluate = "优秀";
                    else
                        if (score >= 80)
                            evaluate = "良好";
                        else
                            if (score >= 60)
                                evaluate = "及格";
                            else
                                evaluate = "不及格";
                    this.vital_capacity_score = score;
                    this.vital_capacity_evaluate = evaluate;
                }
                if (this.grade == "大一" || this.grade == "大二") {
                    if (achievement >= 3450)
                        score = 100;
                    else
                        if (achievement >= 3400)
                            score = 95;
                        else
                            if (achievement >= 3350)
                                score = 90;
                            else
                                if (achievement >= 3200)
                                    score = 85;
                                else
                                    if (achievement >= 3050)
                                        score = 80;
                                    else
                                        if (achievement >= 2950)
                                            score = 78;
                                        else
                                            if (achievement >= 2850)
                                                score = 76;
                                            else
                                                if (achievement >= 2750)
                                                    score = 74;
                                                else
                                                    if (achievement >= 2650)
                                                        score = 72;
                                                    else
                                                        if (achievement >= 2550)
                                                            score = 70;
                                                        else
                                                            if (achievement >= 2450)
                                                                score = 68;
                                                            else
                                                                if (achievement >= 2350)
                                                                    score = 66;
                                                                else
                                                                    if (achievement >= 2250)
                                                                        score = 64;
                                                                    else
                                                                        if (achievement >= 2150)
                                                                            score = 62;
                                                                        else
                                                                            if (achievement >= 2050)
                                                                                score = 60;
                                                                            else
                                                                                if (achievement >= 2010)
                                                                                    score = 50;
                                                                                else
                                                                                    if (achievement >= 1970)
                                                                                        score = 40;
                                                                                    else
                                                                                        if (achievement >= 1930)
                                                                                            score = 30;
                                                                                        else
                                                                                            if (achievement >= 1890)
                                                                                                score = 20;
                                                                                            else
                                                                                                if (achievement >= 1850)
                                                                                                    score = 10;
                                                                                                else
                                                                                                    score = 10;

                    if (score >= 90)
                        evaluate = "优秀";
                    else
                        if (score >= 80)
                            evaluate = "良好";
                        else
                            if (score >= 60)
                                evaluate = "及格";
                            else
                                evaluate = "不及格";
                    this.vital_capacity_score = score;
                    this.vital_capacity_evaluate = evaluate;
                }
            }
            if (this.gender == "男")
            {
                if (this.grade == "大一" || this.grade == "大二")
                {
                        if (achievement >= 5040)
                            score = 100;
                        else
                            if (achievement >= 4920)
                                score = 95;
                            else
                                if (achievement >= 4800)
                                    score = 90;
                                else
                                    if (achievement >= 4550)
                                        score = 85;
                                    else
                                        if (achievement >= 4300)
                                            score = 80;
                                        else
                                            if (achievement >= 4180)
                                                score = 78;
                                            else
                                                if (achievement >= 4060)
                                                    score = 76;
                                                else
                                                    if (achievement >= 3940)
                                                        score = 74;
                                                    else
                                                        if (achievement >= 3820)
                                                            score = 72;
                                                        else
                                                            if (achievement >= 3700)
                                                                score = 70;
                                                            else
                                                                if (achievement >= 3580)
                                                                    score = 68;
                                                                else
                                                                    if (achievement >= 3460)
                                                                        score = 66;
                                                                    else
                                                                        if (achievement >= 3340)
                                                                            score = 64;
                                                                        else
                                                                            if (achievement >= 3220)
                                                                                score = 62;
                                                                            else
                                                                                if (achievement >= 3100)
                                                                                    score = 60;
                                                                                else
                                                                                    if (achievement >= 2940)
                                                                                        score = 50;
                                                                                    else
                                                                                        if (achievement >= 2780)
                                                                                            score = 40;
                                                                                        else
                                                                                            if (achievement >= 2620)
                                                                                                score = 30;
                                                                                            else
                                                                                                if (achievement >= 2460)
                                                                                                    score = 20;
                                                                                                else
                                                                                                    if (achievement >= 2300)
                                                                                                        score = 10;
                                                                                                    else
                                                                                                        score = 10;

                        if (score >= 90)
                            evaluate = "优秀";
                        else
                            if (score >= 80)
                                evaluate = "良好";
                            else
                                if (score >= 60)
                                    evaluate = "及格";
                                else
                                    evaluate = "不及格";
                        this.vital_capacity_score = score;
                        this.vital_capacity_evaluate = evaluate;
                    }
                    if (this.grade == "三" || this.grade == "大四")
                    {
                        if (achievement >= 5140)
                            score = 100;
                        else
                            if (achievement >= 5020)
                                score = 95;
                            else
                                if (achievement >= 4900)
                                    score = 90;
                                else
                                    if (achievement >= 4650)
                                        score = 85;
                                    else
                                        if (achievement >= 4400)
                                            score = 80;
                                        else
                                            if (achievement >= 4280)
                                                score = 78;
                                            else
                                                if (achievement >= 4160)
                                                    score = 76;
                                                else
                                                    if (achievement >= 4040)
                                                        score = 74;
                                                    else
                                                        if (achievement >= 3920)
                                                            score = 72;
                                                        else
                                                            if (achievement >= 3800)
                                                                score = 70;
                                                            else
                                                                if (achievement >= 3680)
                                                                    score = 68;
                                                                else
                                                                    if (achievement >= 3560)
                                                                        score = 66;
                                                                    else
                                                                        if (achievement >= 3440)
                                                                            score = 64;
                                                                        else
                                                                            if (achievement >= 3320)
                                                                                score = 62;
                                                                            else
                                                                                if (achievement >= 3200)
                                                                                    score = 60;
                                                                                else
                                                                                    if (achievement >= 3030)
                                                                                        score = 50;
                                                                                    else
                                                                                        if (achievement >= 2860)
                                                                                            score = 40;
                                                                                        else
                                                                                            if (achievement >= 2690)
                                                                                                score = 30;
                                                                                            else
                                                                                                if (achievement >= 2520)
                                                                                                    score = 20;
                                                                                                else
                                                                                                    if (achievement >= 2350)
                                                                                                        score = 10;
                                                                                                    else
                                                                                                        score = 10;

                        if (score >= 90)
                            evaluate = "优秀";
                        else
                            if (score >= 80)
                                evaluate = "良好";
                            else
                                if (score >= 60)
                                    evaluate = "及格";
                                else
                                    evaluate = "不及格";
                        this.vital_capacity_score = score;
                        this.vital_capacity_evaluate = evaluate;
                    }
                }
            
            
        }

        public float standing_long_jump;
        public int standing_long_jump_score;
        public string standing_long_jump_evaluate;
        public void set_standing_long_jump_score() {
            float achievement = standing_long_jump;
            int score;
            string evaluate;
            
            if (this.gender == "女")
            {
                if (this.grade == "大一" || this.grade == "大二") {
                    if (achievement >= 207)
                        score = 100;
                    else
                        if (achievement >= 201)
                            score = 95;
                        else
                            if (achievement >= 195)
                                score = 90;
                            else
                                if (achievement >= 188)
                                    score = 85;
                                else
                                    if (achievement >= 181)
                                        score = 80;
                                    else
                                        if (achievement >= 178)
                                            score = 78;
                                        else
                                            if (achievement >= 175)
                                                score = 76;
                                            else
                                                if (achievement >= 172)
                                                    score = 74;
                                                else
                                                    if (achievement >= 169)
                                                        score = 72;
                                                    else
                                                        if (achievement >= 166)
                                                            score = 70;
                                                        else
                                                            if (achievement >= 163)
                                                                score = 68;
                                                            else
                                                                if (achievement >= 160)
                                                                    score = 66;
                                                                else
                                                                    if (achievement >= 157)
                                                                        score = 64;
                                                                    else
                                                                        if (achievement >= 154)
                                                                            score = 62;
                                                                        else
                                                                            if (achievement >= 151)
                                                                                score = 60;
                                                                            else
                                                                                if (achievement >= 146)
                                                                                    score = 50;
                                                                                else
                                                                                    if (achievement >= 141)
                                                                                        score = 40;
                                                                                    else
                                                                                        if (achievement >= 136)
                                                                                            score = 30;
                                                                                        else
                                                                                            if (achievement >= 131)
                                                                                                score = 20;
                                                                                            else
                                                                                                if (achievement >= 126)
                                                                                                    score = 10;
                                                                                                else
                                                                                                    score = 10;

                    if (score >= 90)
                        evaluate = "优秀";
                    else
                        if (score >= 80)
                            evaluate = "良好";
                        else
                            if (score >= 60)
                                evaluate = "及格";
                            else
                                evaluate = "不及格";
                    this.standing_long_jump_score = score;
                    this.standing_long_jump_evaluate = evaluate;
                }
                if (this.grade == "大三" || this.grade == "大四") {
                    if (achievement >= 208)
                        score = 100;
                    else
                        if (achievement >= 202)
                            score = 95;
                        else
                            if (achievement >= 196)
                                score = 90;
                            else
                                if (achievement >= 189)
                                    score = 85;
                                else
                                    if (achievement >= 182)
                                        score = 80;
                                    else
                                        if (achievement >= 179)
                                            score = 78;
                                        else
                                            if (achievement >= 176)
                                                score = 76;
                                            else
                                                if (achievement >= 173)
                                                    score = 74;
                                                else
                                                    if (achievement >= 170)
                                                        score = 72;
                                                    else
                                                        if (achievement >= 167)
                                                            score = 70;
                                                        else
                                                            if (achievement >= 164)
                                                                score = 68;
                                                            else
                                                                if (achievement >= 161)
                                                                    score = 66;
                                                                else
                                                                    if (achievement >= 158)
                                                                        score = 64;
                                                                    else
                                                                        if (achievement >= 155)
                                                                            score = 62;
                                                                        else
                                                                            if (achievement >= 152)
                                                                                score = 60;
                                                                            else
                                                                                if (achievement >= 147)
                                                                                    score = 50;
                                                                                else
                                                                                    if (achievement >= 142)
                                                                                        score = 40;
                                                                                    else
                                                                                        if (achievement >= 137)
                                                                                            score = 30;
                                                                                        else
                                                                                            if (achievement >= 132)
                                                                                                score = 20;
                                                                                            else
                                                                                                if (achievement >= 127)
                                                                                                    score = 10;
                                                                                                else
                                                                                                    score = 10;

                    if (score >= 90)
                        evaluate = "优秀";
                    else
                        if (score >= 80)
                            evaluate = "良好";
                        else
                            if (score >= 60)
                                evaluate = "及格";
                            else
                                evaluate = "不及格";
                    this.standing_long_jump_score = score;
                    this.standing_long_jump_evaluate = evaluate;
                }
            }
            if (this.gender == "男")
            {
                if (this.grade == "大一" || this.grade == "大二") {
                    if (achievement >= 273)
                        score = 100;
                    else
                        if (achievement >= 268)
                            score = 95;
                        else
                            if (achievement >= 263)
                                score = 90;
                            else
                                if (achievement >= 256)
                                    score = 85;
                                else
                                    if (achievement >= 248)
                                        score = 80;
                                    else
                                        if (achievement >= 244)
                                            score = 78;
                                        else
                                            if (achievement >= 240)
                                                score = 76;
                                            else
                                                if (achievement >= 236)
                                                    score = 74;
                                                else
                                                    if (achievement >= 232)
                                                        score = 72;
                                                    else
                                                        if (achievement >= 228)
                                                            score = 70;
                                                        else
                                                            if (achievement >= 224)
                                                                score = 68;
                                                            else
                                                                if (achievement >= 220)
                                                                    score = 66;
                                                                else
                                                                    if (achievement >= 216)
                                                                        score = 64;
                                                                    else
                                                                        if (achievement >= 212)
                                                                            score = 62;
                                                                        else
                                                                            if (achievement >= 208)
                                                                                score = 60;
                                                                            else
                                                                                if (achievement >= 203)
                                                                                    score = 50;
                                                                                else
                                                                                    if (achievement >= 198)
                                                                                        score = 40;
                                                                                    else
                                                                                        if (achievement >= 193)
                                                                                            score = 30;
                                                                                        else
                                                                                            if (achievement >= 188)
                                                                                                score = 20;
                                                                                            else
                                                                                                if (achievement >= 183)
                                                                                                    score = 10;
                                                                                                else
                                                                                                    score = 10;

                    if (score >= 90)
                        evaluate = "优秀";
                    else
                        if (score >= 80)
                            evaluate = "良好";
                        else
                            if (score >= 60)
                                evaluate = "及格";
                            else
                                evaluate = "不及格";
                    this.standing_long_jump_score = score;
                    this.standing_long_jump_evaluate = evaluate;
                }
                if (this.grade == "大三" || this.grade == "大四") {
                    if (achievement >= 275)
                        score = 100;
                    else
                        if (achievement >= 270)
                            score = 95;
                        else
                            if (achievement >= 265)
                                score = 90;
                            else
                                if (achievement >= 258)
                                    score = 85;
                                else
                                    if (achievement >= 250)
                                        score = 80;
                                    else
                                        if (achievement >= 246)
                                            score = 78;
                                        else
                                            if (achievement >= 242)
                                                score = 76;
                                            else
                                                if (achievement >= 238)
                                                    score = 74;
                                                else
                                                    if (achievement >= 234)
                                                        score = 72;
                                                    else
                                                        if (achievement >= 230)
                                                            score = 70;
                                                        else
                                                            if (achievement >= 226)
                                                                score = 68;
                                                            else
                                                                if (achievement >= 222)
                                                                    score = 66;
                                                                else
                                                                    if (achievement >= 218)
                                                                        score = 64;
                                                                    else
                                                                        if (achievement >= 214)
                                                                            score = 62;
                                                                        else
                                                                            if (achievement >= 210)
                                                                                score = 60;
                                                                            else
                                                                                if (achievement >= 205)
                                                                                    score = 50;
                                                                                else
                                                                                    if (achievement >= 200)
                                                                                        score = 40;
                                                                                    else
                                                                                        if (achievement >= 195)
                                                                                            score = 30;
                                                                                        else
                                                                                            if (achievement >= 190)
                                                                                                score = 20;
                                                                                            else
                                                                                                if (achievement >= 185)
                                                                                                    score = 10;
                                                                                                else
                                                                                                    score = 10;

                    if (score >= 90)
                        evaluate = "优秀";
                    else
                        if (score >= 80)
                            evaluate = "良好";
                        else
                            if (score >= 60)
                                evaluate = "及格";
                            else
                                evaluate = "不及格";
                    this.standing_long_jump_score = score;
                    this.standing_long_jump_evaluate = evaluate;
                }
            }
        }

        public float achievement_endurance_run;
        public int achievement_endurance_run_score;
        public string achievement_endurance_run_evaluate;
        public void set_achievement_endurance_run() {
            float achievement = this.achievement_endurance_run;
            int score;
            string evaluate;
            
            if (this.gender == "女")
            {
                if (this.grade == "大一" || this.grade == "大二") {
                    if (achievement <= 3.18)
                        score = 100;
                    else
                        if (achievement <= 3.24)
                            score = 95;
                        else
                            if (achievement <= 3.30)
                                score = 90;
                            else
                                if (achievement <= 3.37)
                                    score = 85;
                                else
                                    if (achievement <= 3.44)
                                        score = 80;
                                    else
                                        if (achievement <= 3.49)
                                            score = 78;
                                        else
                                            if (achievement <= 3.54)
                                                score = 76;
                                            else
                                                if (achievement <= 3.59)
                                                    score = 74;
                                                else
                                                    if (achievement <= 4.04)
                                                        score = 72;
                                                    else
                                                        if (achievement <= 4.09)
                                                            score = 70;
                                                        else
                                                            if (achievement <= 4.14)
                                                                score = 68;
                                                            else
                                                                if (achievement <= 4.19)
                                                                    score = 66;
                                                                else
                                                                    if (achievement <= 4.24)
                                                                        score = 64;
                                                                    else
                                                                        if (achievement <= 4.29)
                                                                            score = 62;
                                                                        else
                                                                            if (achievement <= 4.34)
                                                                                score = 60;
                                                                            else
                                                                                if (achievement <= 4.44)
                                                                                    score = 50;
                                                                                else
                                                                                    if (achievement <= 4.54)
                                                                                        score = 40;
                                                                                    else
                                                                                        if (achievement <= 5.04)
                                                                                            score = 30;
                                                                                        else
                                                                                            if (achievement <= 5.14)
                                                                                                score = 20;
                                                                                            else
                                                                                                if (achievement <= 5.24)
                                                                                                    score = 10;
                                                                                                else
                                                                                                    score = 10;

                    if (score >= 90)
                        evaluate = "优秀";
                    else
                        if (score >= 80)
                            evaluate = "良好";
                        else
                            if (score >= 60)
                                evaluate = "及格";
                            else
                                evaluate = "不及格";
                    this.achievement_endurance_run_score = score;
                    this.achievement_endurance_run_evaluate = evaluate;
                }
                if (this.grade == "大三" || this.grade == "大四") {
                    if (achievement <= 3.16)
                        score = 100;
                    else
                        if (achievement <= 3.22)
                            score = 95;
                        else
                            if (achievement <= 3.28)
                                score = 90;
                            else
                                if (achievement <= 3.35)
                                    score = 85;
                                else
                                    if (achievement <= 3.42)
                                        score = 80;
                                    else
                                        if (achievement <= 3.47)
                                            score = 78;
                                        else
                                            if (achievement <= 3.52)
                                                score = 76;
                                            else
                                                if (achievement <= 3.57)
                                                    score = 74;
                                                else
                                                    if (achievement <= 4.02)
                                                        score = 72;
                                                    else
                                                        if (achievement <= 4.07)
                                                            score = 70;
                                                        else
                                                            if (achievement <= 4.12)
                                                                score = 68;
                                                            else
                                                                if (achievement <= 4.17)
                                                                    score = 66;
                                                                else
                                                                    if (achievement <= 4.22)
                                                                        score = 64;
                                                                    else
                                                                        if (achievement <= 4.27)
                                                                            score = 62;
                                                                        else
                                                                            if (achievement <= 4.32)
                                                                                score = 60;
                                                                            else
                                                                                if (achievement <= 4.42)
                                                                                    score = 50;
                                                                                else
                                                                                    if (achievement <= 4.52)
                                                                                        score = 40;
                                                                                    else
                                                                                        if (achievement <= 5.02)
                                                                                            score = 30;
                                                                                        else
                                                                                            if (achievement <= 5.12)
                                                                                                score = 20;
                                                                                            else
                                                                                                if (achievement <= 5.22)
                                                                                                    score = 10;
                                                                                                else
                                                                                                    score = 10;

                    if (score >= 90)
                        evaluate = "优秀";
                    else
                        if (score >= 80)
                            evaluate = "良好";
                        else
                            if (score >= 60)
                                evaluate = "及格";
                            else
                                evaluate = "不及格";
                    this.achievement_endurance_run_score = score;
                    this.achievement_endurance_run_evaluate = evaluate;
                }
            }
            if (this.gender == "男")
            {
                if (this.grade == "大一" || this.grade == "大二") {
                    if (achievement <= 3.17)
                        score = 100;
                    else
                        if (achievement <= 3.22)
                            score = 95;
                        else
                            if (achievement <= 3.27)
                                score = 90;
                            else
                                if (achievement <= 3.34)
                                    score = 85;
                                else
                                    if (achievement <= 3.42)
                                        score = 80;
                                    else
                                        if (achievement <= 3.47)
                                            score = 78;
                                        else
                                            if (achievement <= 3.52)
                                                score = 76;
                                            else
                                                if (achievement <= 3.57)
                                                    score = 74;
                                                else
                                                    if (achievement <= 4.02)
                                                        score = 72;
                                                    else
                                                        if (achievement <= 4.07)
                                                            score = 70;
                                                        else
                                                            if (achievement <= 4.12)
                                                                score = 68;
                                                            else
                                                                if (achievement <= 4.17)
                                                                    score = 66;
                                                                else
                                                                    if (achievement <= 4.22)
                                                                        score = 64;
                                                                    else
                                                                        if (achievement <= 4.27)
                                                                            score = 62;
                                                                        else
                                                                            if (achievement <= 4.32)
                                                                                score = 60;
                                                                            else
                                                                                if (achievement <= 4.52)
                                                                                    score = 50;
                                                                                else
                                                                                    if (achievement <= 5.12)
                                                                                        score = 40;
                                                                                    else
                                                                                        if (achievement <= 5.32)
                                                                                            score = 30;
                                                                                        else
                                                                                            if (achievement <= 5.52)
                                                                                                score = 20;
                                                                                            else
                                                                                                if (achievement <= 6.12)
                                                                                                    score = 10;
                                                                                                else
                                                                                                    score = 10;

                    if (score >= 90)
                        evaluate = "优秀";
                    else
                        if (score >= 80)
                            evaluate = "良好";
                        else
                            if (score >= 60)
                                evaluate = "及格";
                            else
                                evaluate = "不及格";
                    this.achievement_endurance_run_score = score;
                    this.achievement_endurance_run_evaluate = evaluate;
                }
                if (this.grade == "大三" || this.grade == "大四") {
                    if (achievement <= 3.15)
                        score = 100;
                    else
                        if (achievement <= 3.20)
                            score = 95;
                        else
                            if (achievement <= 3.25)
                                score = 90;
                            else
                                if (achievement <= 3.32)
                                    score = 85;
                                else
                                    if (achievement <= 3.40)
                                        score = 80;
                                    else
                                        if (achievement <= 3.45)
                                            score = 78;
                                        else
                                            if (achievement <= 3.50)
                                                score = 76;
                                            else
                                                if (achievement <= 3.55)
                                                    score = 74;
                                                else
                                                    if (achievement <= 4.00)
                                                        score = 72;
                                                    else
                                                        if (achievement <= 4.05)
                                                            score = 70;
                                                        else
                                                            if (achievement <= 4.10)
                                                                score = 68;
                                                            else
                                                                if (achievement <= 4.15)
                                                                    score = 66;
                                                                else
                                                                    if (achievement <= 4.2)
                                                                        score = 64;
                                                                    else
                                                                        if (achievement <= 4.25)
                                                                            score = 62;
                                                                        else
                                                                            if (achievement <= 4.30)
                                                                                score = 60;
                                                                            else
                                                                                if (achievement <= 4.5)
                                                                                    score = 50;
                                                                                else
                                                                                    if (achievement <= 5.1)
                                                                                        score = 40;
                                                                                    else
                                                                                        if (achievement <= 5.3)
                                                                                            score = 30;
                                                                                        else
                                                                                            if (achievement <= 5.5)
                                                                                                score = 20;
                                                                                            else
                                                                                                if (achievement <= 6.1)
                                                                                                    score = 10;
                                                                                                else
                                                                                                    score = 10;

                    if (score >= 90)
                        evaluate = "优秀";
                    else
                        if (score >= 80)
                            evaluate = "良好";
                        else
                            if (score >= 60)
                                evaluate = "及格";
                            else
                                evaluate = "不及格";
                    this.achievement_endurance_run_score = score;
                    this.achievement_endurance_run_evaluate = evaluate;
                }
            }
        }

        public float three_dimensional_flexion; // 立体前屈
        public int three_dimensional_flexion_score;
        public string three_dimensional_flexion_evaluate;
        public void set_three_dimensional_flexion_score() {
            float achievement = this.three_dimensional_flexion;
            int score;
            string evaluate;
            
            if (this.gender == "女")
            {
                if (this.grade == "大一" || this.grade == "大二") {
                    if (achievement >= 25.8)
                        score = 100;
                    else
                        if (achievement >= 24.0)
                            score = 95;
                        else
                            if (achievement >= 22.2)
                                score = 90;
                            else
                                if (achievement >= 20.6)
                                    score = 85;
                                else
                                    if (achievement >= 19.0)
                                        score = 80;
                                    else
                                        if (achievement >= 17.7)
                                            score = 78;
                                        else
                                            if (achievement >= 16.4)
                                                score = 76;
                                            else
                                                if (achievement >= 15.1)
                                                    score = 74;
                                                else
                                                    if (achievement >= 13.8)
                                                        score = 72;
                                                    else
                                                        if (achievement >= 12.5)
                                                            score = 70;
                                                        else
                                                            if (achievement >= 11.2)
                                                                score = 68;
                                                            else
                                                                if (achievement >= 9.9)
                                                                    score = 66;
                                                                else
                                                                    if (achievement >= 8.6)
                                                                        score = 64;
                                                                    else
                                                                        if (achievement >= 7.3)
                                                                            score = 62;
                                                                        else
                                                                            if (achievement >= 6.0)
                                                                                score = 60;
                                                                            else
                                                                                if (achievement >= 5.2)
                                                                                    score = 50;
                                                                                else
                                                                                    if (achievement >= 4.4)
                                                                                        score = 40;
                                                                                    else
                                                                                        if (achievement >= 3.6)
                                                                                            score = 30;
                                                                                        else
                                                                                            if (achievement >= 2.8)
                                                                                                score = 20;
                                                                                            else
                                                                                                if (achievement >= 2.0)
                                                                                                    score = 10;
                                                                                                else
                                                                                                    score = 10;

                    if (score >= 90)
                        evaluate = "优秀";
                    else
                        if (score >= 80)
                            evaluate = "良好";
                        else
                            if (score >= 60)
                                evaluate = "及格";
                            else
                                evaluate = "不及格";
                    this.three_dimensional_flexion_score = score;
                    this.three_dimensional_flexion_evaluate = evaluate;
                }
                if (this.grade == "大三" || this.grade == "大四") {
                    if (achievement >= 26.3)
                        score = 100;
                    else
                        if (achievement >= 24.4)
                            score = 95;
                        else
                            if (achievement >= 22.4)
                                score = 90;
                            else
                                if (achievement >= 21.0)
                                    score = 85;
                                else
                                    if (achievement >= 19.5)
                                        score = 80;
                                    else
                                        if (achievement >= 18.2)
                                            score = 78;
                                        else
                                            if (achievement >= 16.9)
                                                score = 76;
                                            else
                                                if (achievement >= 15.6)
                                                    score = 74;
                                                else
                                                    if (achievement >= 14.3)
                                                        score = 72;
                                                    else
                                                        if (achievement >= 13.0)
                                                            score = 70;
                                                        else
                                                            if (achievement >= 11.7)
                                                                score = 68;
                                                            else
                                                                if (achievement >= 10.4)
                                                                    score = 66;
                                                                else
                                                                    if (achievement >= 9.1)
                                                                        score = 64;
                                                                    else
                                                                        if (achievement >= 7.8)
                                                                            score = 62;
                                                                        else
                                                                            if (achievement >= 6.5)
                                                                                score = 60;
                                                                            else
                                                                                if (achievement >= 5.7)
                                                                                    score = 50;
                                                                                else
                                                                                    if (achievement >= 4.9)
                                                                                        score = 40;
                                                                                    else
                                                                                        if (achievement >= 4.1)
                                                                                            score = 30;
                                                                                        else
                                                                                            if (achievement >= 3.3)
                                                                                                score = 20;
                                                                                            else
                                                                                                if (achievement >= 2.5)
                                                                                                    score = 10;
                                                                                                else
                                                                                                    score = 10;

                    if (score >= 90)
                        evaluate = "优秀";
                    else
                        if (score >= 80)
                            evaluate = "良好";
                        else
                            if (score >= 60)
                                evaluate = "及格";
                            else
                                evaluate = "不及格";
                    this.three_dimensional_flexion_score = score;
                    this.three_dimensional_flexion_evaluate = evaluate;
                }
            }
            if (this.gender == "男")
            {
                if (this.grade == "大一" || this.grade == "大二") {
                    if (achievement >= 24.9)
                        score = 100;
                    else
                        if (achievement >= 23.1)
                            score = 95;
                        else
                            if (achievement >= 21.3)
                                score = 90;
                            else
                                if (achievement >= 19.5)
                                    score = 85;
                                else
                                    if (achievement >= 17.7)
                                        score = 80;
                                    else
                                        if (achievement >= 16.3)
                                            score = 78;
                                        else
                                            if (achievement >= 14.9)
                                                score = 76;
                                            else
                                                if (achievement >= 13.5)
                                                    score = 74;
                                                else
                                                    if (achievement >= 12.1)
                                                        score = 72;
                                                    else
                                                        if (achievement >= 10.7)
                                                            score = 70;
                                                        else
                                                            if (achievement >= 9.3)
                                                                score = 68;
                                                            else
                                                                if (achievement >= 7.9)
                                                                    score = 66;
                                                                else
                                                                    if (achievement >= 6.5)
                                                                        score = 64;
                                                                    else
                                                                        if (achievement >= 5.1)
                                                                            score = 62;
                                                                        else
                                                                            if (achievement >= 3.7)
                                                                                score = 60;
                                                                            else
                                                                                if (achievement >= 2.7)
                                                                                    score = 50;
                                                                                else
                                                                                    if (achievement >= 1.7)
                                                                                        score = 40;
                                                                                    else
                                                                                        if (achievement >= 0.7)
                                                                                            score = 30;
                                                                                        else
                                                                                            if (achievement >= -0.3)
                                                                                                score = 20;
                                                                                            else
                                                                                                if (achievement >= -1.3)
                                                                                                    score = 10;
                                                                                                else
                                                                                                    score = 10;

                    if (score >= 90)
                        evaluate = "优秀";
                    else
                        if (score >= 80)
                            evaluate = "良好";
                        else
                            if (score >= 60)
                                evaluate = "及格";
                            else
                                evaluate = "不及格";
                    this.three_dimensional_flexion_score = score;
                    this.three_dimensional_flexion_evaluate = evaluate;
                }
                if (this.grade == "大三" || this.grade == "大四") {
                    if (achievement >= 25.1)
                        score = 100;
                    else
                        if (achievement >= 23.3)
                            score = 95;
                        else
                            if (achievement >= 21.5)
                                score = 90;
                            else
                                if (achievement >= 19.9)
                                    score = 85;
                                else
                                    if (achievement >= 18.2)
                                        score = 80;
                                    else
                                        if (achievement >= 16.8)
                                            score = 78;
                                        else
                                            if (achievement >= 15.4)
                                                score = 76;
                                            else
                                                if (achievement >= 14.0)
                                                    score = 74;
                                                else
                                                    if (achievement >= 12.6)
                                                        score = 72;
                                                    else
                                                        if (achievement >= 11.2)
                                                            score = 70;
                                                        else
                                                            if (achievement >= 9.8)
                                                                score = 68;
                                                            else
                                                                if (achievement >= 8.4)
                                                                    score = 66;
                                                                else
                                                                    if (achievement >= 7.0)
                                                                        score = 64;
                                                                    else
                                                                        if (achievement >= 5.6)
                                                                            score = 62;
                                                                        else
                                                                            if (achievement >= 4.2)
                                                                                score = 60;
                                                                            else
                                                                                if (achievement >= 3.2)
                                                                                    score = 50;
                                                                                else
                                                                                    if (achievement >= 2.2)
                                                                                        score = 40;
                                                                                    else
                                                                                        if (achievement >= 1.2)
                                                                                            score = 30;
                                                                                        else
                                                                                            if (achievement >= 0.2)
                                                                                                score = 20;
                                                                                            else
                                                                                                if (achievement >= -0.8)
                                                                                                    score = 10;
                                                                                                else
                                                                                                    score = 10;

                    if (score >= 90)
                        evaluate = "优秀";
                    else
                        if (score >= 80)
                            evaluate = "良好";
                        else
                            if (score >= 60)
                                evaluate = "及格";
                            else
                                evaluate = "不及格";
                    this.three_dimensional_flexion_score = score;
                    this.three_dimensional_flexion_evaluate = evaluate;
                }
            }
        }

        public int pull_up_or_abdominal_curl; // 引体向上 / 仰卧起坐 
        public int pull_up_or_abdominal_curl_score;
        public string pull_up_or_abdominal_curl_evaluate;
        public void set_pull_up_or_abdominal_curl_score() {
            int achievement = this.pull_up_or_abdominal_curl;
            int score;
            string evaluate;
            
            if (this.gender == "女")
            {
                if (this.grade == "大一" || this.grade == "大二") {
                    if (achievement >= 56)
                        score = 100;
                    else
                        if (achievement >= 54)
                            score = 95;
                        else
                            if (achievement >= 52)
                                score = 90;
                            else
                                if (achievement >= 49)
                                    score = 85;
                                else
                                    if (achievement >= 46)
                                        score = 80;
                                    else
                                        if (achievement >= 44)
                                            score = 78;
                                        else
                                            if (achievement >= 42)
                                                score = 76;
                                            else
                                                if (achievement >= 40)
                                                    score = 74;
                                                else
                                                    if (achievement >= 38)
                                                        score = 72;
                                                    else
                                                        if (achievement >= 36)
                                                            score = 70;
                                                        else
                                                            if (achievement >= 34)
                                                                score = 68;
                                                            else
                                                                if (achievement >= 32)
                                                                    score = 66;
                                                                else
                                                                    if (achievement >= 30)
                                                                        score = 64;
                                                                    else
                                                                        if (achievement >= 28)
                                                                            score = 62;
                                                                        else
                                                                            if (achievement >= 26)
                                                                                score = 60;
                                                                            else
                                                                                if (achievement >= 24)
                                                                                    score = 50;
                                                                                else
                                                                                    if (achievement >= 22)
                                                                                        score = 40;
                                                                                    else
                                                                                        if (achievement >= 20)
                                                                                            score = 30;
                                                                                        else
                                                                                            if (achievement >= 18)
                                                                                                score = 20;
                                                                                            else
                                                                                                if (achievement >= 16)
                                                                                                    score = 10;
                                                                                                else
                                                                                                    score = 10;

                    if (score >= 90)
                        evaluate = "优秀";
                    else
                        if (score >= 80)
                            evaluate = "良好";
                        else
                            if (score >= 60)
                                evaluate = "及格";
                            else
                                evaluate = "不及格";
                    this.pull_up_or_abdominal_curl_score = score;
                    this.pull_up_or_abdominal_curl_evaluate = evaluate;
                }
                if (this.grade == "大三" || this.grade == "大四") {
                    if (achievement >= 57)
                        score = 100;
                    else
                        if (achievement >= 55)
                            score = 95;
                        else
                            if (achievement >= 53)
                                score = 90;
                            else
                                if (achievement >= 50)
                                    score = 85;
                                else
                                    if (achievement >= 47)
                                        score = 80;
                                    else
                                        if (achievement >= 45)
                                            score = 78;
                                        else
                                            if (achievement >= 43)
                                                score = 76;
                                            else
                                                if (achievement >= 41)
                                                    score = 74;
                                                else
                                                    if (achievement >= 39)
                                                        score = 72;
                                                    else
                                                        if (achievement >= 37)
                                                            score = 70;
                                                        else
                                                            if (achievement >= 35)
                                                                score = 68;
                                                            else
                                                                if (achievement >= 33)
                                                                    score = 66;
                                                                else
                                                                    if (achievement >= 31)
                                                                        score = 64;
                                                                    else
                                                                        if (achievement >= 29)
                                                                            score = 62;
                                                                        else
                                                                            if (achievement >= 27)
                                                                                score = 60;
                                                                            else
                                                                                if (achievement >= 25)
                                                                                    score = 50;
                                                                                else
                                                                                    if (achievement >= 23)
                                                                                        score = 40;
                                                                                    else
                                                                                        if (achievement >= 21)
                                                                                            score = 30;
                                                                                        else
                                                                                            if (achievement >= 19)
                                                                                                score = 20;
                                                                                            else
                                                                                                if (achievement >= 17)
                                                                                                    score = 10;
                                                                                                else
                                                                                                    score = 10;

                    if (score >= 90)
                        evaluate = "优秀";
                    else
                        if (score >= 80)
                            evaluate = "良好";
                        else
                            if (score >= 60)
                                evaluate = "及格";
                            else
                                evaluate = "不及格";
                    this.pull_up_or_abdominal_curl_score = score;
                    this.pull_up_or_abdominal_curl_evaluate = evaluate;
                }
            }
            if (this.gender == "男")
            {
                if (this.grade == "大一" || this.grade == "大二") {
                    if (achievement >= 19)
                        score = 100;
                    else
                        if (achievement >= 18)
                            score = 95;
                        else
                            if (achievement >= 17)
                                score = 90;
                            else
                                if (achievement >= 16)
                                    score = 85;
                                else
                                    if (achievement >= 15)
                                        score = 80;
                                    else
                                        if (achievement >= 14)
                                            score = 76;
                                        else
                                            if (achievement >= 13)
                                                score = 72;
                                            else
                                                if (achievement >= 12)
                                                    score = 68;
                                                else
                                                    if (achievement >= 11)
                                                        score = 64;
                                                    else
                                                        if (achievement >= 10)
                                                            score = 60;
                                                        else
                                                            if (achievement >= 9)
                                                                score = 50;
                                                            else
                                                                if (achievement >= 8)
                                                                    score = 40;
                                                                else
                                                                    if (achievement >= 7)
                                                                        score = 30;
                                                                    else
                                                                        if (achievement >= 6)
                                                                            score = 20;
                                                                        else
                                                                            if (achievement >= 5)
                                                                                score = 10;
                                                                            else
                                                                                score = 10;

                    if (score >= 90)
                        evaluate = "优秀";
                    else
                        if (score >= 80)
                            evaluate = "良好";
                        else
                            if (score >= 60)
                                evaluate = "及格";
                            else
                                evaluate = "不及格";
                    this.pull_up_or_abdominal_curl_score = score;
                    this.pull_up_or_abdominal_curl_evaluate = evaluate;
                }
                if (this.grade == "大三" || this.grade == "大四") {
                    if (achievement >= 20)
                        score = 100;
                    else
                        if (achievement >= 19)
                            score = 95;
                        else
                            if (achievement >= 18)
                                score = 90;
                            else
                                if (achievement >= 17)
                                    score = 85;
                                else
                                    if (achievement >= 16)
                                        score = 80;
                                    else
                                        if (achievement >= 15)
                                            score = 76;
                                        else
                                            if (achievement >= 14)
                                                score = 72;
                                            else
                                                if (achievement >= 13)
                                                    score = 68;
                                                else
                                                    if (achievement >= 12)
                                                        score = 64;
                                                    else
                                                        if (achievement >= 11)
                                                            score = 60;
                                                        else
                                                            if (achievement >= 10)
                                                                score = 50;
                                                            else
                                                                if (achievement >= 9)
                                                                    score = 40;
                                                                else
                                                                    if (achievement >= 8)
                                                                        score = 30;
                                                                    else
                                                                        if (achievement >= 7)
                                                                            score = 20;
                                                                        else
                                                                            if (achievement >= 6)
                                                                                score = 10;
                                                                            else
                                                                                score = 10;

                    if (score >= 90)
                        evaluate = "优秀";
                    else
                        if (score >= 80)
                            evaluate = "良好";
                        else
                            if (score >= 60)
                                evaluate = "及格";
                            else
                                evaluate = "不及格";
                    this.pull_up_or_abdominal_curl_score = score;
                    this.pull_up_or_abdominal_curl_evaluate = evaluate;
                }
            }
        }

        public float evaluation_results;
        public string evaluation_results_evaluate;
        public void set_evaluation_results() {
            this.evaluation_results = (this.bmi_score + this.achievement_50m_score + this.achievement_endurance_run_score + this.pull_up_or_abdominal_curl_score
                + this.standing_long_jump_score + this.three_dimensional_flexion_score + this.vital_capacity_score)/7;
            if (this.evaluation_results >= 90)
                this.evaluation_results_evaluate = "优秀";
            else
                if (this.evaluation_results >= 80)
                    this.evaluation_results_evaluate = "良好";
                else
                    if (this.evaluation_results >= 60)
                        this.evaluation_results_evaluate = "及格";
                    else
                        this.evaluation_results_evaluate = "不及格";
        
        }

    }
}
