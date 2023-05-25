namespace Bolt
{
    partial class Lesson3
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
            this.pictureBox_lesson3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lesson3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_lesson3
            // 
            this.pictureBox_lesson3.Image = global::Bolt.Properties.Resources.Lesson3;
            this.pictureBox_lesson3.Location = new System.Drawing.Point(-23, 1);
            this.pictureBox_lesson3.Name = "pictureBox_lesson3";
            this.pictureBox_lesson3.Size = new System.Drawing.Size(1947, 1011);
            this.pictureBox_lesson3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_lesson3.TabIndex = 0;
            this.pictureBox_lesson3.TabStop = false;
            // 
            // Lesson3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 993);
            this.Controls.Add(this.pictureBox_lesson3);
            this.Name = "Lesson3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bolt | Урок №3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lesson3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox_lesson3;
    }
}