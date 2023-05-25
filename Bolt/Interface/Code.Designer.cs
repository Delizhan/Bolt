namespace Bolt
{
    partial class Code
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
            this.button_code = new System.Windows.Forms.Button();
            this.label_text1 = new System.Windows.Forms.Label();
            this.label_text2 = new System.Windows.Forms.Label();
            this.label_code = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bolt.Properties.Resources.Code;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(812, 462);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_code
            // 
            this.button_code.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_code.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_code.ForeColor = System.Drawing.SystemColors.Control;
            this.button_code.Location = new System.Drawing.Point(291, 261);
            this.button_code.Name = "button_code";
            this.button_code.Size = new System.Drawing.Size(230, 54);
            this.button_code.TabIndex = 11;
            this.button_code.Text = "Отримати код";
            this.button_code.UseVisualStyleBackColor = false;
            this.button_code.Click += new System.EventHandler(this.button_code_Click);
            // 
            // label_text1
            // 
            this.label_text1.AutoSize = true;
            this.label_text1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_text1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_text1.Location = new System.Drawing.Point(438, 359);
            this.label_text1.Name = "label_text1";
            this.label_text1.Size = new System.Drawing.Size(360, 19);
            this.label_text1.TabIndex = 12;
            this.label_text1.Text = "Даний код потрібно запам\'ятати для змінення паролю.";
            // 
            // label_text2
            // 
            this.label_text2.AutoSize = true;
            this.label_text2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_text2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_text2.Location = new System.Drawing.Point(563, 378);
            this.label_text2.Name = "label_text2";
            this.label_text2.Size = new System.Drawing.Size(235, 19);
            this.label_text2.TabIndex = 13;
            this.label_text2.Text = "Його можна використати лише раз.";
            // 
            // label_code
            // 
            this.label_code.AutoSize = true;
            this.label_code.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_code.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_code.Location = new System.Drawing.Point(379, 221);
            this.label_code.Name = "label_code";
            this.label_code.Size = new System.Drawing.Size(0, 28);
            this.label_code.TabIndex = 15;
            // 
            // Code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 456);
            this.Controls.Add(this.label_code);
            this.Controls.Add(this.label_text2);
            this.Controls.Add(this.label_text1);
            this.Controls.Add(this.button_code);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Code";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Bolt";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button button_code;
        private Label label_text1;
        private Label label_text2;
        private Label label_code;
    }
}