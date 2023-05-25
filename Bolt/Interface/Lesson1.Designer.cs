namespace Bolt
{
    partial class Lesson1
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
            this.pictureBox_lesson1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lesson1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_lesson1
            // 
            this.pictureBox_lesson1.Image = global::Bolt.Properties.Resources.Lesson1__1_;
            this.pictureBox_lesson1.Location = new System.Drawing.Point(-21, -1);
            this.pictureBox_lesson1.Name = "pictureBox_lesson1";
            this.pictureBox_lesson1.Size = new System.Drawing.Size(1947, 1011);
            this.pictureBox_lesson1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_lesson1.TabIndex = 0;
            this.pictureBox_lesson1.TabStop = false;
            // 
            // Lesson1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 993);
            this.Controls.Add(this.pictureBox_lesson1);
            this.Name = "Lesson1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bolt | Урок №1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lesson1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox_lesson1;
    }
}