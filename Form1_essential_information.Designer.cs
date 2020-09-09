namespace 大学生体质测评系统
{
    partial class Form1_essential_information
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_essential_information));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Sno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton_boy = new System.Windows.Forms.RadioButton();
            this.radioButton_girl = new System.Windows.Forms.RadioButton();
            this.radioButton_freshman = new System.Windows.Forms.RadioButton();
            this.radioButton_sophomore = new System.Windows.Forms.RadioButton();
            this.radioButton_junior = new System.Windows.Forms.RadioButton();
            this.radioButton_senior = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.button_confirm = new System.Windows.Forms.Button();
            this.panel_grade = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.panel_grade.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(92, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(92, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "年级：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(92, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "姓名：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_Sno
            // 
            this.textBox_Sno.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Sno.Location = new System.Drawing.Point(167, 314);
            this.textBox_Sno.Name = "textBox_Sno";
            this.textBox_Sno.Size = new System.Drawing.Size(203, 28);
            this.textBox_Sno.TabIndex = 4;
            this.textBox_Sno.TextChanged += new System.EventHandler(this.textBox_sno_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(92, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "性别：";
            // 
            // radioButton_boy
            // 
            this.radioButton_boy.AutoSize = true;
            this.radioButton_boy.Checked = true;
            this.radioButton_boy.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_boy.Location = new System.Drawing.Point(29, 11);
            this.radioButton_boy.Name = "radioButton_boy";
            this.radioButton_boy.Size = new System.Drawing.Size(51, 25);
            this.radioButton_boy.TabIndex = 2;
            this.radioButton_boy.TabStop = true;
            this.radioButton_boy.Text = "男";
            this.radioButton_boy.UseVisualStyleBackColor = true;
            this.radioButton_boy.CheckedChanged += new System.EventHandler(this.radioButton_boy_CheckedChanged);
            // 
            // radioButton_girl
            // 
            this.radioButton_girl.AutoSize = true;
            this.radioButton_girl.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_girl.Location = new System.Drawing.Point(138, 12);
            this.radioButton_girl.Name = "radioButton_girl";
            this.radioButton_girl.Size = new System.Drawing.Size(51, 25);
            this.radioButton_girl.TabIndex = 3;
            this.radioButton_girl.Text = "女";
            this.radioButton_girl.UseVisualStyleBackColor = true;
            this.radioButton_girl.CheckedChanged += new System.EventHandler(this.radioButton_girl_CheckedChanged);
            // 
            // radioButton_freshman
            // 
            this.radioButton_freshman.AutoSize = true;
            this.radioButton_freshman.Checked = true;
            this.radioButton_freshman.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_freshman.Location = new System.Drawing.Point(18, 3);
            this.radioButton_freshman.Name = "radioButton_freshman";
            this.radioButton_freshman.Size = new System.Drawing.Size(71, 25);
            this.radioButton_freshman.TabIndex = 4;
            this.radioButton_freshman.TabStop = true;
            this.radioButton_freshman.Text = "大一";
            this.radioButton_freshman.UseVisualStyleBackColor = true;
            this.radioButton_freshman.CheckedChanged += new System.EventHandler(this.radioButton_freshman_CheckedChanged);
            // 
            // radioButton_sophomore
            // 
            this.radioButton_sophomore.AutoSize = true;
            this.radioButton_sophomore.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_sophomore.Location = new System.Drawing.Point(138, 0);
            this.radioButton_sophomore.Name = "radioButton_sophomore";
            this.radioButton_sophomore.Size = new System.Drawing.Size(71, 25);
            this.radioButton_sophomore.TabIndex = 5;
            this.radioButton_sophomore.Text = "大二";
            this.radioButton_sophomore.UseVisualStyleBackColor = true;
            this.radioButton_sophomore.CheckedChanged += new System.EventHandler(this.radioButton_sophomore_CheckedChanged_1);
            // 
            // radioButton_junior
            // 
            this.radioButton_junior.AutoSize = true;
            this.radioButton_junior.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_junior.Location = new System.Drawing.Point(18, 58);
            this.radioButton_junior.Name = "radioButton_junior";
            this.radioButton_junior.Size = new System.Drawing.Size(71, 25);
            this.radioButton_junior.TabIndex = 6;
            this.radioButton_junior.Text = "大三";
            this.radioButton_junior.UseVisualStyleBackColor = true;
            this.radioButton_junior.CheckedChanged += new System.EventHandler(this.radioButton_junior_CheckedChanged);
            // 
            // radioButton_senior
            // 
            this.radioButton_senior.AutoSize = true;
            this.radioButton_senior.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_senior.Location = new System.Drawing.Point(138, 58);
            this.radioButton_senior.Name = "radioButton_senior";
            this.radioButton_senior.Size = new System.Drawing.Size(71, 25);
            this.radioButton_senior.TabIndex = 7;
            this.radioButton_senior.Text = "大四";
            this.radioButton_senior.UseVisualStyleBackColor = true;
            this.radioButton_senior.CheckedChanged += new System.EventHandler(this.radioButton_senior_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("隶书", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(42, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(415, 43);
            this.label5.TabIndex = 13;
            this.label5.Text = "大学生体质测评系统";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button_confirm.Font = new System.Drawing.Font("楷体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_confirm.ForeColor = System.Drawing.Color.Black;
            this.button_confirm.Location = new System.Drawing.Point(167, 379);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(192, 58);
            this.button_confirm.TabIndex = 5;
            this.button_confirm.Text = "确认";
            this.button_confirm.UseVisualStyleBackColor = false;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // panel_grade
            // 
            this.panel_grade.BackColor = System.Drawing.Color.Transparent;
            this.panel_grade.Controls.Add(this.radioButton_freshman);
            this.panel_grade.Controls.Add(this.radioButton_sophomore);
            this.panel_grade.Controls.Add(this.radioButton_junior);
            this.panel_grade.Controls.Add(this.radioButton_senior);
            this.panel_grade.Location = new System.Drawing.Point(159, 207);
            this.panel_grade.Name = "panel_grade";
            this.panel_grade.Size = new System.Drawing.Size(211, 85);
            this.panel_grade.TabIndex = 3;
            this.panel_grade.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.radioButton_boy);
            this.panel2.Controls.Add(this.radioButton_girl);
            this.panel2.Location = new System.Drawing.Point(159, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 38);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_name.Location = new System.Drawing.Point(167, 105);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(203, 28);
            this.textBox_name.TabIndex = 1;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // Form1_essential_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(523, 471);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Sno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_grade);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1_essential_information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " 大学生体质测评系统";
            this.Load += new System.EventHandler(this.大学生体质测评系统_Load);
            this.panel_grade.ResumeLayout(false);
            this.panel_grade.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_boy;
        private System.Windows.Forms.RadioButton radioButton_girl;
        private System.Windows.Forms.RadioButton radioButton_freshman;
        private System.Windows.Forms.RadioButton radioButton_sophomore;
        private System.Windows.Forms.RadioButton radioButton_junior;
        private System.Windows.Forms.RadioButton radioButton_senior;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Panel panel_grade;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_Sno;
        private System.Windows.Forms.TextBox textBox_name;
    }
}

