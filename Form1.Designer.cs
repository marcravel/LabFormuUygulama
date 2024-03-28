namespace LabFormu
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.schoolCombo = new System.Windows.Forms.ComboBox();
            this.majorCombo = new System.Windows.Forms.ComboBox();
            this.interestListBox = new System.Windows.Forms.ListBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adress";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "School";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Major";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Interest";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(124, 29);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(245, 27);
            this.nameTextBox.TabIndex = 1;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(124, 68);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(245, 27);
            this.phoneTextBox.TabIndex = 2;
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(124, 108);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(245, 27);
            this.mailTextBox.TabIndex = 3;
            // 
            // adressTextBox
            // 
            this.adressTextBox.Location = new System.Drawing.Point(124, 149);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(245, 27);
            this.adressTextBox.TabIndex = 4;
            // 
            // schoolCombo
            // 
            this.schoolCombo.FormattingEnabled = true;
            this.schoolCombo.Items.AddRange(new object[] {
            "Harvard University",
            "Selcuk University",
            "MIT",
            "Konya Technical University"});
            this.schoolCombo.Location = new System.Drawing.Point(124, 187);
            this.schoolCombo.Name = "schoolCombo";
            this.schoolCombo.Size = new System.Drawing.Size(245, 28);
            this.schoolCombo.TabIndex = 5;
            // 
            // majorCombo
            // 
            this.majorCombo.FormattingEnabled = true;
            this.majorCombo.Items.AddRange(new object[] {
            "Electrical Electronic Engineering",
            "Computer Engineering",
            "Mechanical Engineering",
            "Chemistry Engineering",
            "Civil Engineering",
            "Mathematics",
            "Physics",
            "Journalism",
            "Psychology",
            "Sociology"});
            this.majorCombo.Location = new System.Drawing.Point(124, 226);
            this.majorCombo.Name = "majorCombo";
            this.majorCombo.Size = new System.Drawing.Size(245, 28);
            this.majorCombo.TabIndex = 6;
            // 
            // interestListBox
            // 
            this.interestListBox.FormattingEnabled = true;
            this.interestListBox.ItemHeight = 20;
            this.interestListBox.Items.AddRange(new object[] {
            "Coding",
            "Computer"});
            this.interestListBox.Location = new System.Drawing.Point(124, 268);
            this.interestListBox.Name = "interestListBox";
            this.interestListBox.Size = new System.Drawing.Size(245, 104);
            this.interestListBox.TabIndex = 7;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(207, 399);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(162, 60);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(28, 399);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(162, 60);
            this.registerBtn.TabIndex = 8;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 487);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.interestListBox);
            this.Controls.Add(this.majorCombo);
            this.Controls.Add(this.schoolCombo);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form Filling";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.ComboBox schoolCombo;
        private System.Windows.Forms.ComboBox majorCombo;
        private System.Windows.Forms.ListBox interestListBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

