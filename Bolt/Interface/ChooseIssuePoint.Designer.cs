namespace Bolt.Interface
{
    partial class ChooseIssuePoint
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
            this.pictureBox_issuePoint = new System.Windows.Forms.PictureBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.textBox_street = new System.Windows.Forms.TextBox();
            this.textBox_numberBuilding = new System.Windows.Forms.TextBox();
            this.button_next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_issuePoint)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_issuePoint
            // 
            this.pictureBox_issuePoint.Image = global::Bolt.Properties.Resources.issuePoint;
            this.pictureBox_issuePoint.Location = new System.Drawing.Point(1, 0);
            this.pictureBox_issuePoint.Name = "pictureBox_issuePoint";
            this.pictureBox_issuePoint.Size = new System.Drawing.Size(598, 889);
            this.pictureBox_issuePoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_issuePoint.TabIndex = 0;
            this.pictureBox_issuePoint.TabStop = false;
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_id.Location = new System.Drawing.Point(65, 360);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(470, 39);
            this.textBox_id.TabIndex = 7;
            this.textBox_id.Text = "3";
            // 
            // textBox_city
            // 
            this.textBox_city.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_city.Location = new System.Drawing.Point(65, 463);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(470, 39);
            this.textBox_city.TabIndex = 8;
            this.textBox_city.Text = "Полтава";
            // 
            // textBox_street
            // 
            this.textBox_street.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_street.Location = new System.Drawing.Point(65, 566);
            this.textBox_street.Name = "textBox_street";
            this.textBox_street.Size = new System.Drawing.Size(470, 39);
            this.textBox_street.TabIndex = 9;
            this.textBox_street.Text = "Чкалова";
            // 
            // textBox_numberBuilding
            // 
            this.textBox_numberBuilding.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_numberBuilding.Location = new System.Drawing.Point(65, 669);
            this.textBox_numberBuilding.Name = "textBox_numberBuilding";
            this.textBox_numberBuilding.Size = new System.Drawing.Size(470, 39);
            this.textBox_numberBuilding.TabIndex = 10;
            this.textBox_numberBuilding.Text = "11";
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_next.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_next.ForeColor = System.Drawing.SystemColors.Control;
            this.button_next.Location = new System.Drawing.Point(72, 750);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(456, 54);
            this.button_next.TabIndex = 11;
            this.button_next.Text = "Далі ->";
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // ChooseIssuePoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 883);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.textBox_numberBuilding);
            this.Controls.Add(this.textBox_street);
            this.Controls.Add(this.textBox_city);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.pictureBox_issuePoint);
            this.Name = "ChooseIssuePoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bolt | Пункт видачі";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_issuePoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox_issuePoint;
        private TextBox textBox_id;
        private TextBox textBox_city;
        private TextBox textBox_street;
        private TextBox textBox_numberBuilding;
        private Button button_next;
    }
}