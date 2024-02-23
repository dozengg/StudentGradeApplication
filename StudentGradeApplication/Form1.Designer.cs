namespace StudentGradeApplication
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.name = new System.Windows.Forms.TextBox();
            this.englishbox = new System.Windows.Forms.TextBox();
            this.mathbox = new System.Windows.Forms.TextBox();
            this.filipinobox = new System.Windows.Forms.TextBox();
            this.sciencebox = new System.Windows.Forms.TextBox();
            this.historybox = new System.Windows.Forms.TextBox();
            this.finalgrade = new System.Windows.Forms.Label();
            this.fingrade = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(23, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Average";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(18, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "English";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Math";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "History";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Science";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Filipino";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Grades";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.HighlightText;
            this.name.ForeColor = System.Drawing.SystemColors.MenuText;
            this.name.Location = new System.Drawing.Point(103, 49);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(341, 20);
            this.name.TabIndex = 15;
            this.name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // englishbox
            // 
            this.englishbox.Location = new System.Drawing.Point(157, 158);
            this.englishbox.Name = "englishbox";
            this.englishbox.Size = new System.Drawing.Size(100, 20);
            this.englishbox.TabIndex = 16;
            // 
            // mathbox
            // 
            this.mathbox.Location = new System.Drawing.Point(157, 194);
            this.mathbox.Name = "mathbox";
            this.mathbox.Size = new System.Drawing.Size(100, 20);
            this.mathbox.TabIndex = 17;
            // 
            // filipinobox
            // 
            this.filipinobox.Location = new System.Drawing.Point(157, 231);
            this.filipinobox.Name = "filipinobox";
            this.filipinobox.Size = new System.Drawing.Size(100, 20);
            this.filipinobox.TabIndex = 18;
            // 
            // sciencebox
            // 
            this.sciencebox.Location = new System.Drawing.Point(157, 268);
            this.sciencebox.Name = "sciencebox";
            this.sciencebox.Size = new System.Drawing.Size(100, 20);
            this.sciencebox.TabIndex = 19;
            // 
            // historybox
            // 
            this.historybox.Location = new System.Drawing.Point(157, 301);
            this.historybox.Name = "historybox";
            this.historybox.Size = new System.Drawing.Size(100, 20);
            this.historybox.TabIndex = 20;
            // 
            // finalgrade
            // 
            this.finalgrade.AutoSize = true;
            this.finalgrade.Location = new System.Drawing.Point(311, 195);
            this.finalgrade.Name = "finalgrade";
            this.finalgrade.Size = new System.Drawing.Size(0, 13);
            this.finalgrade.TabIndex = 21;
            this.finalgrade.Visible = false;
            this.finalgrade.Click += new System.EventHandler(this.label8_Click);
            // 
            // fingrade
            // 
            this.fingrade.AutoSize = true;
            this.fingrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fingrade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fingrade.Location = new System.Drawing.Point(372, 172);
            this.fingrade.Name = "fingrade";
            this.fingrade.Size = new System.Drawing.Size(0, 25);
            this.fingrade.TabIndex = 22;
            this.fingrade.Visible = false;
            this.fingrade.Click += new System.EventHandler(this.fingrade_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(291, 207);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(585, 457);
            this.Controls.Add(this.result);
            this.Controls.Add(this.fingrade);
            this.Controls.Add(this.finalgrade);
            this.Controls.Add(this.historybox);
            this.Controls.Add(this.sciencebox);
            this.Controls.Add(this.filipinobox);
            this.Controls.Add(this.mathbox);
            this.Controls.Add(this.englishbox);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox englishbox;
        private System.Windows.Forms.TextBox mathbox;
        private System.Windows.Forms.TextBox filipinobox;
        private System.Windows.Forms.TextBox sciencebox;
        private System.Windows.Forms.TextBox historybox;
        private System.Windows.Forms.Label finalgrade;
        private System.Windows.Forms.Label fingrade;
        private System.Windows.Forms.Label result;
    }
}

