namespace Bolt
{
    partial class SMS_NewPassword
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
            this.pictureBox_sucNewPassword = new System.Windows.Forms.PictureBox();
            this.button__next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sucNewPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_sucNewPassword
            // 
            this.pictureBox_sucNewPassword.Image = global::Bolt.Properties.Resources.SucNewPassword;
            this.pictureBox_sucNewPassword.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox_sucNewPassword.Name = "pictureBox_sucNewPassword";
            this.pictureBox_sucNewPassword.Size = new System.Drawing.Size(812, 462);
            this.pictureBox_sucNewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_sucNewPassword.TabIndex = 0;
            this.pictureBox_sucNewPassword.TabStop = false;
            // 
            // button__next
            // 
            this.button__next.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button__next.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button__next.ForeColor = System.Drawing.SystemColors.Control;
            this.button__next.Location = new System.Drawing.Point(273, 290);
            this.button__next.Name = "button__next";
            this.button__next.Size = new System.Drawing.Size(277, 75);
            this.button__next.TabIndex = 10;
            this.button__next.Text = "Перейти до перегляду сторінок";
            this.button__next.UseVisualStyleBackColor = false;
            this.button__next.Click += new System.EventHandler(this.button__next_Click);
            // 
            // SMS_NewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 456);
            this.Controls.Add(this.button__next);
            this.Controls.Add(this.pictureBox_sucNewPassword);
            this.Name = "SMS_NewPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "!!!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SMS_NewPassword_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sucNewPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox_sucNewPassword;
        private Button button__next;
    }
}