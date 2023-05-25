namespace Bolt
{
    partial class Message_NumScooters
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
            this.pictureBox_message = new System.Windows.Forms.PictureBox();
            this.button__ok = new System.Windows.Forms.Button();
            this.textBox_numScooters = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_message)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_message
            // 
            this.pictureBox_message.Image = global::Bolt.Properties.Resources.Message_NumScooters;
            this.pictureBox_message.Location = new System.Drawing.Point(0, -1);
            this.pictureBox_message.Name = "pictureBox_message";
            this.pictureBox_message.Size = new System.Drawing.Size(812, 462);
            this.pictureBox_message.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_message.TabIndex = 0;
            this.pictureBox_message.TabStop = false;
            // 
            // button__ok
            // 
            this.button__ok.BackColor = System.Drawing.Color.Orange;
            this.button__ok.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button__ok.ForeColor = System.Drawing.SystemColors.Control;
            this.button__ok.Location = new System.Drawing.Point(267, 294);
            this.button__ok.Name = "button__ok";
            this.button__ok.Size = new System.Drawing.Size(277, 50);
            this.button__ok.TabIndex = 12;
            this.button__ok.Text = "OK";
            this.button__ok.UseVisualStyleBackColor = false;
            this.button__ok.Click += new System.EventHandler(this.button__ok_Click);
            // 
            // textBox_numScooters
            // 
            this.textBox_numScooters.BackColor = System.Drawing.Color.Orange;
            this.textBox_numScooters.ForeColor = System.Drawing.Color.White;
            this.textBox_numScooters.Location = new System.Drawing.Point(630, 227);
            this.textBox_numScooters.Name = "textBox_numScooters";
            this.textBox_numScooters.Size = new System.Drawing.Size(33, 27);
            this.textBox_numScooters.TabIndex = 13;
            // 
            // Message_NumScooters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 456);
            this.Controls.Add(this.textBox_numScooters);
            this.Controls.Add(this.button__ok);
            this.Controls.Add(this.pictureBox_message);
            this.Name = "Message_NumScooters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "!!!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_message)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox_message;
        private Button button__ok;
        public TextBox textBox_numScooters;
    }
}