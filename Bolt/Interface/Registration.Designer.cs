namespace Bolt
{
    partial class Registration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_signOrEnter = new System.Windows.Forms.PictureBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_sign = new System.Windows.Forms.Button();
            this.button_enter = new System.Windows.Forms.Button();
            this.button_guest = new System.Windows.Forms.Button();
            this.textBox_age = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_signOrEnter)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_signOrEnter
            // 
            this.pictureBox_signOrEnter.Image = global::Bolt.Properties.Resources.Sign1;
            this.pictureBox_signOrEnter.Location = new System.Drawing.Point(-8, -4);
            this.pictureBox_signOrEnter.Name = "pictureBox_signOrEnter";
            this.pictureBox_signOrEnter.Size = new System.Drawing.Size(1947, 1011);
            this.pictureBox_signOrEnter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_signOrEnter.TabIndex = 0;
            this.pictureBox_signOrEnter.TabStop = false;
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_name.Location = new System.Drawing.Point(1331, 391);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(456, 39);
            this.textBox_name.TabIndex = 1;
            // 
            // textBox_surname
            // 
            this.textBox_surname.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_surname.Location = new System.Drawing.Point(1331, 492);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(456, 39);
            this.textBox_surname.TabIndex = 2;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_phone.Location = new System.Drawing.Point(1419, 592);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(368, 39);
            this.textBox_phone.TabIndex = 3;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_password.Location = new System.Drawing.Point(1331, 692);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(456, 39);
            this.textBox_password.TabIndex = 4;
            // 
            // button_sign
            // 
            this.button_sign.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_sign.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_sign.ForeColor = System.Drawing.SystemColors.Control;
            this.button_sign.Location = new System.Drawing.Point(1331, 881);
            this.button_sign.Name = "button_sign";
            this.button_sign.Size = new System.Drawing.Size(456, 54);
            this.button_sign.TabIndex = 8;
            this.button_sign.Text = "Далі ->";
            this.button_sign.UseVisualStyleBackColor = false;
            this.button_sign.Click += new System.EventHandler(this.button_sign_Click);
            // 
            // button_enter
            // 
            this.button_enter.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_enter.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_enter.ForeColor = System.Drawing.SystemColors.Control;
            this.button_enter.Location = new System.Drawing.Point(1158, 152);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(133, 54);
            this.button_enter.TabIndex = 9;
            this.button_enter.Text = "Увійти";
            this.button_enter.UseVisualStyleBackColor = false;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // button_guest
            // 
            this.button_guest.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_guest.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_guest.ForeColor = System.Drawing.SystemColors.Control;
            this.button_guest.Location = new System.Drawing.Point(1158, 221);
            this.button_guest.Name = "button_guest";
            this.button_guest.Size = new System.Drawing.Size(133, 54);
            this.button_guest.TabIndex = 10;
            this.button_guest.Text = "Гість";
            this.button_guest.UseVisualStyleBackColor = false;
            this.button_guest.Click += new System.EventHandler(this.button_guest_Click);
            // 
            // textBox_age
            // 
            this.textBox_age.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_age.Location = new System.Drawing.Point(1331, 792);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(456, 39);
            this.textBox_age.TabIndex = 11;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1902, 993);
            this.Controls.Add(this.textBox_age);
            this.Controls.Add(this.button_guest);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.button_sign);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.pictureBox_signOrEnter);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bolt | Реєстрація";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registration_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_signOrEnter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox_signOrEnter;
        private TextBox textBox_name;
        private TextBox textBox_surname;
        private TextBox textBox_phone;
        private TextBox textBox_password;
        private Button button_sign;
        private Button button_enter;
        private Button button_guest;
        private TextBox textBox_age;
    }
}