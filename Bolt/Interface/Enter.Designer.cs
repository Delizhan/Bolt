namespace Bolt
{
    partial class Enter
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
            this.pictureBox_enter = new System.Windows.Forms.PictureBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_enter = new System.Windows.Forms.Button();
            this.button_choose_password = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_enter)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_enter
            // 
            this.pictureBox_enter.Image = global::Bolt.Properties.Resources.Enter;
            this.pictureBox_enter.Location = new System.Drawing.Point(-7, 0);
            this.pictureBox_enter.Name = "pictureBox_enter";
            this.pictureBox_enter.Size = new System.Drawing.Size(1947, 1011);
            this.pictureBox_enter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_enter.TabIndex = 0;
            this.pictureBox_enter.TabStop = false;
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_name.Location = new System.Drawing.Point(738, 433);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(456, 39);
            this.textBox_name.TabIndex = 2;
            this.textBox_name.Text = "Ірина";
            // 
            // textBox_surname
            // 
            this.textBox_surname.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_surname.Location = new System.Drawing.Point(738, 533);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(456, 39);
            this.textBox_surname.TabIndex = 3;
            this.textBox_surname.Text = "Деліжан";
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_password.Location = new System.Drawing.Point(738, 634);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(456, 39);
            this.textBox_password.TabIndex = 4;
            this.textBox_password.Text = "123456789";
            // 
            // button_enter
            // 
            this.button_enter.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_enter.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_enter.ForeColor = System.Drawing.SystemColors.Control;
            this.button_enter.Location = new System.Drawing.Point(738, 712);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(456, 54);
            this.button_enter.TabIndex = 9;
            this.button_enter.Text = "Далі ->";
            this.button_enter.UseVisualStyleBackColor = false;
            this.button_enter.Click += new System.EventHandler(this.button_sign_Click);
            // 
            // button_choose_password
            // 
            this.button_choose_password.BackColor = System.Drawing.Color.White;
            this.button_choose_password.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_choose_password.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.button_choose_password.Location = new System.Drawing.Point(879, 828);
            this.button_choose_password.Name = "button_choose_password";
            this.button_choose_password.Size = new System.Drawing.Size(169, 47);
            this.button_choose_password.TabIndex = 10;
            this.button_choose_password.Text = "Забули пароль?";
            this.button_choose_password.UseVisualStyleBackColor = false;
            this.button_choose_password.Click += new System.EventHandler(this.button_choose_password_Click);
            // 
            // Enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 993);
            this.Controls.Add(this.button_choose_password);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.pictureBox_enter);
            this.Name = "Enter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bolt | Вхід";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Enter_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_enter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox_enter;
        private TextBox textBox_name;
        private TextBox textBox_surname;
        private TextBox textBox_password;
        private Button button_enter;
        private Button button_choose_password;
    }
}