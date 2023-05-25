namespace Bolt
{
    partial class Error_PastDate
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
            this.pictureBox_error = new System.Windows.Forms.PictureBox();
            this.button__ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_error)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_error
            // 
            this.pictureBox_error.Image = global::Bolt.Properties.Resources.Error_PastDate;
            this.pictureBox_error.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox_error.Name = "pictureBox_error";
            this.pictureBox_error.Size = new System.Drawing.Size(812, 462);
            this.pictureBox_error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_error.TabIndex = 0;
            this.pictureBox_error.TabStop = false;
            // 
            // button__ok
            // 
            this.button__ok.BackColor = System.Drawing.Color.Brown;
            this.button__ok.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button__ok.ForeColor = System.Drawing.SystemColors.Control;
            this.button__ok.Location = new System.Drawing.Point(267, 298);
            this.button__ok.Name = "button__ok";
            this.button__ok.Size = new System.Drawing.Size(277, 50);
            this.button__ok.TabIndex = 13;
            this.button__ok.Text = "OK";
            this.button__ok.UseVisualStyleBackColor = false;
            this.button__ok.Click += new System.EventHandler(this.button__ok_Click);
            // 
            // Error_PastDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 456);
            this.Controls.Add(this.button__ok);
            this.Controls.Add(this.pictureBox_error);
            this.Name = "Error_PastDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "!!!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox_error;
        private Button button__ok;
    }
}