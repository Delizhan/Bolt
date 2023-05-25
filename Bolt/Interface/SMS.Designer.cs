namespace Bolt.Interface
{
    partial class SMS
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
            this.pictureBox_sucEnter = new System.Windows.Forms.PictureBox();
            this.label_LogIn = new System.Windows.Forms.Label();
            this.button__next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sucEnter)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_sucEnter
            // 
            this.pictureBox_sucEnter.Image = global::Bolt.Properties.Resources.SucEnter;
            this.pictureBox_sucEnter.Location = new System.Drawing.Point(-6, -3);
            this.pictureBox_sucEnter.Name = "pictureBox_sucEnter";
            this.pictureBox_sucEnter.Size = new System.Drawing.Size(812, 462);
            this.pictureBox_sucEnter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_sucEnter.TabIndex = 0;
            this.pictureBox_sucEnter.TabStop = false;
            // 
            // label_LogIn
            // 
            this.label_LogIn.AutoSize = true;
            this.label_LogIn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label_LogIn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_LogIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_LogIn.Location = new System.Drawing.Point(263, 237);
            this.label_LogIn.Name = "label_LogIn";
            this.label_LogIn.Size = new System.Drawing.Size(27, 31);
            this.label_LogIn.TabIndex = 1;
            this.label_LogIn.Text = "1";
            // 
            // button__next
            // 
            this.button__next.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button__next.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button__next.ForeColor = System.Drawing.SystemColors.Control;
            this.button__next.Location = new System.Drawing.Point(262, 302);
            this.button__next.Name = "button__next";
            this.button__next.Size = new System.Drawing.Size(277, 75);
            this.button__next.TabIndex = 11;
            this.button__next.Text = "Перейти до перегляду сторінок";
            this.button__next.UseVisualStyleBackColor = false;
            this.button__next.Click += new System.EventHandler(this.button__next_Click);
            // 
            // SMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button__next);
            this.Controls.Add(this.label_LogIn);
            this.Controls.Add(this.pictureBox_sucEnter);
            this.Name = "SMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "!!!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SMS_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sucEnter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox_sucEnter;
        private Button button__next;
        public Label label_LogIn;
    }
}