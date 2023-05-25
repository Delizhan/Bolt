namespace Bolt.Interface
{
    partial class SMS_OK
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
            this.pictureBox_ok = new System.Windows.Forms.PictureBox();
            this.button__next = new System.Windows.Forms.Button();
            this.label_text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ok)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_ok
            // 
            this.pictureBox_ok.Image = global::Bolt.Properties.Resources.SucEnter__1_;
            this.pictureBox_ok.Location = new System.Drawing.Point(-6, -6);
            this.pictureBox_ok.Name = "pictureBox_ok";
            this.pictureBox_ok.Size = new System.Drawing.Size(812, 462);
            this.pictureBox_ok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_ok.TabIndex = 1;
            this.pictureBox_ok.TabStop = false;
            // 
            // button__next
            // 
            this.button__next.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button__next.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button__next.ForeColor = System.Drawing.SystemColors.Control;
            this.button__next.Location = new System.Drawing.Point(262, 265);
            this.button__next.Name = "button__next";
            this.button__next.Size = new System.Drawing.Size(277, 54);
            this.button__next.TabIndex = 13;
            this.button__next.Text = "OK";
            this.button__next.UseVisualStyleBackColor = false;
            this.button__next.Click += new System.EventHandler(this.button__next_Click);
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label_text.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_text.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_text.Location = new System.Drawing.Point(263, 183);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(27, 31);
            this.label_text.TabIndex = 12;
            this.label_text.Text = "1";
            // 
            // SMS_OK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button__next);
            this.Controls.Add(this.label_text);
            this.Controls.Add(this.pictureBox_ok);
            this.Name = "SMS_OK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "!!!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox_ok;
        private Button button__next;
        public Label label_text;
    }
}