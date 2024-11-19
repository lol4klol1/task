namespace task
{
    partial class registration
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
            this.nazad = new System.Windows.Forms.Button();
            this.reg = new System.Windows.Forms.Button();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tasktextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nazad
            // 
            this.nazad.Location = new System.Drawing.Point(304, 333);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(122, 26);
            this.nazad.TabIndex = 0;
            this.nazad.Text = "Назад";
            this.nazad.UseVisualStyleBackColor = true;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // reg
            // 
            this.reg.BackColor = System.Drawing.Color.Transparent;
            this.reg.Location = new System.Drawing.Point(304, 272);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(122, 31);
            this.reg.TabIndex = 1;
            this.reg.Text = "Зарегистрироваться\r\n";
            this.reg.UseVisualStyleBackColor = false;
            this.reg.Click += new System.EventHandler(this.reg_Click);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(304, 103);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(122, 20);
            this.FirstNameTextBox.TabIndex = 4;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Задача";
            // 
            // tasktextBox
            // 
            this.tasktextBox.Location = new System.Drawing.Point(304, 144);
            this.tasktextBox.Name = "tasktextBox";
            this.tasktextBox.Size = new System.Drawing.Size(122, 20);
            this.tasktextBox.TabIndex = 7;
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tasktextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.nazad);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "registration";
            this.Text = "Регистация";
            this.Load += new System.EventHandler(this.registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.Button reg;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tasktextBox;
    }
}