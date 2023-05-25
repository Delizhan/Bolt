namespace Bolt
{
    partial class NewPassword
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_password = new System.Windows.Forms.Button();
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.textBox_new_password = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.button_code = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bolt.Properties.Resources.Password1;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1947, 1011);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_password
            // 
            this.button_password.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_password.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_password.ForeColor = System.Drawing.SystemColors.Control;
            this.button_password.Location = new System.Drawing.Point(738, 772);
            this.button_password.Name = "button_password";
            this.button_password.Size = new System.Drawing.Size(456, 54);
            this.button_password.TabIndex = 10;
            this.button_password.Text = "Далі ->";
            this.button_password.UseVisualStyleBackColor = false;
            this.button_password.Click += new System.EventHandler(this.button_password_Click);
            // 
            // textBox_code
            // 
            this.textBox_code.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_code.Location = new System.Drawing.Point(738, 586);
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.Size = new System.Drawing.Size(456, 39);
            this.textBox_code.TabIndex = 11;
            // 
            // textBox_new_password
            // 
            this.textBox_new_password.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_new_password.Location = new System.Drawing.Point(738, 686);
            this.textBox_new_password.Name = "textBox_new_password";
            this.textBox_new_password.Size = new System.Drawing.Size(456, 39);
            this.textBox_new_password.TabIndex = 12;
            // 
            // textBox_surname
            // 
            this.textBox_surname.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_surname.Location = new System.Drawing.Point(738, 485);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(456, 39);
            this.textBox_surname.TabIndex = 13;
            // 
            // button_code
            // 
            this.button_code.BackColor = System.Drawing.Color.White;
            this.button_code.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_code.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.button_code.Location = new System.Drawing.Point(882, 886);
            this.button_code.Name = "button_code";
            this.button_code.Size = new System.Drawing.Size(169, 47);
            this.button_code.TabIndex = 14;
            this.button_code.Text = "Отримати код";
            this.button_code.UseVisualStyleBackColor = false;
            this.button_code.Click += new System.EventHandler(this.button_code_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_name.Location = new System.Drawing.Point(738, 384);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(456, 39);
            this.textBox_name.TabIndex = 15;
            // 
            // NewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 993);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_code);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.textBox_new_password);
            this.Controls.Add(this.textBox_code);
            this.Controls.Add(this.button_password);
            this.Controls.Add(this.pictureBox1);
            this.Name = "NewPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bolt | Зміна паролю";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewPassword_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button button_password;
        private TextBox textBox_code;
        private TextBox textBox_new_password;
        private TextBox textBox_surname;
        private Button button_code;
        private TextBox textBox_name;
    }
}