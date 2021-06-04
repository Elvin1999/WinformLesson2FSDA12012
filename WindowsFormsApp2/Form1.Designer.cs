
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameTxtb = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.undoBtn = new System.Windows.Forms.Button();
            this.redoBtn = new System.Windows.Forms.Button();
            this.cutBtn = new System.Windows.Forms.Button();
            this.copyBtn = new System.Windows.Forms.Button();
            this.pasteBtn = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.engRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameTxtb
            // 
            this.usernameTxtb.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtb.Location = new System.Drawing.Point(73, 45);
            this.usernameTxtb.MaxLength = 20;
            this.usernameTxtb.Name = "usernameTxtb";
            this.usernameTxtb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.usernameTxtb.Size = new System.Drawing.Size(397, 44);
            this.usernameTxtb.TabIndex = 1;
            this.usernameTxtb.Text = "username";
            this.usernameTxtb.TextChanged += new System.EventHandler(this.usernameTxtb_TextChanged);
            this.usernameTxtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameTxtb_KeyPress);
            this.usernameTxtb.MouseEnter += new System.EventHandler(this.usernameTxtb_MouseEnter);
            this.usernameTxtb.MouseLeave += new System.EventHandler(this.usernameTxtb_MouseLeave);
            // 
            // saveBtn
            // 
            this.saveBtn.AutoSize = true;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Location = new System.Drawing.Point(488, 45);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(77, 44);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(73, 125);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(492, 174);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // undoBtn
            // 
            this.undoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.undoBtn.Location = new System.Drawing.Point(73, 319);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(83, 45);
            this.undoBtn.TabIndex = 3;
            this.undoBtn.Text = "Undo";
            this.undoBtn.UseVisualStyleBackColor = true;
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // redoBtn
            // 
            this.redoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redoBtn.Location = new System.Drawing.Point(179, 319);
            this.redoBtn.Name = "redoBtn";
            this.redoBtn.Size = new System.Drawing.Size(83, 45);
            this.redoBtn.TabIndex = 4;
            this.redoBtn.Text = "Redo";
            this.redoBtn.UseVisualStyleBackColor = true;
            this.redoBtn.Click += new System.EventHandler(this.redoBtn_Click);
            // 
            // cutBtn
            // 
            this.cutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cutBtn.Location = new System.Drawing.Point(268, 319);
            this.cutBtn.Name = "cutBtn";
            this.cutBtn.Size = new System.Drawing.Size(83, 45);
            this.cutBtn.TabIndex = 5;
            this.cutBtn.Text = "Cut";
            this.cutBtn.UseVisualStyleBackColor = true;
            this.cutBtn.Click += new System.EventHandler(this.cutBtn_Click);
            // 
            // copyBtn
            // 
            this.copyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copyBtn.Location = new System.Drawing.Point(371, 319);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(83, 45);
            this.copyBtn.TabIndex = 6;
            this.copyBtn.Text = "Copy";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // pasteBtn
            // 
            this.pasteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pasteBtn.Location = new System.Drawing.Point(482, 319);
            this.pasteBtn.Name = "pasteBtn";
            this.pasteBtn.Size = new System.Drawing.Size(83, 45);
            this.pasteBtn.TabIndex = 7;
            this.pasteBtn.Text = "Paste";
            this.pasteBtn.UseVisualStyleBackColor = true;
            this.pasteBtn.Click += new System.EventHandler(this.pasteBtn_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox1.Location = new System.Drawing.Point(698, 45);
            this.maskedTextBox1.Mask = "(994)50-000-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(396, 31);
            this.maskedTextBox1.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(698, 180);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(54, 28);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "C#";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Location = new System.Drawing.Point(698, 225);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(67, 28);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "C++";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox3.Location = new System.Drawing.Point(698, 271);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(121, 28);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "Javascript";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(6, 93);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 29);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Visa";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(0, 128);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(102, 29);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Master";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // engRadioButton
            // 
            this.engRadioButton.AutoSize = true;
            this.engRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.engRadioButton.Location = new System.Drawing.Point(6, 30);
            this.engRadioButton.Name = "engRadioButton";
            this.engRadioButton.Size = new System.Drawing.Size(108, 29);
            this.engRadioButton.TabIndex = 14;
            this.engRadioButton.TabStop = true;
            this.engRadioButton.Text = "English";
            this.engRadioButton.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton4.Location = new System.Drawing.Point(139, 30);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(108, 29);
            this.radioButton4.TabIndex = 15;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Turkish";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton5.Location = new System.Drawing.Point(275, 30);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(115, 29);
            this.radioButton5.TabIndex = 16;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Russion";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(878, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 216);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Card Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.engRadioButton);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(688, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 100);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Languages";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 456);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(381, 31);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(676, 463);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 20;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 667);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.pasteBtn);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.cutBtn);
            this.Controls.Add(this.redoBtn);
            this.Controls.Add(this.undoBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.usernameTxtb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTxtb;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button undoBtn;
        private System.Windows.Forms.Button redoBtn;
        private System.Windows.Forms.Button cutBtn;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Button pasteBtn;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton engRadioButton;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

