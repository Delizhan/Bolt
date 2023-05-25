namespace Bolt
{
    partial class Rent
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox_rent = new System.Windows.Forms.PictureBox();
            this.button_search = new System.Windows.Forms.Button();
            this.pictureBox_mape = new System.Windows.Forms.PictureBox();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_kolScooters = new System.Windows.Forms.TextBox();
            this.textBox_start = new System.Windows.Forms.TextBox();
            this.textBox_end = new System.Windows.Forms.TextBox();
            this.button_rent = new System.Windows.Forms.Button();
            this.button_issuePoint = new System.Windows.Forms.Button();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.button_more = new System.Windows.Forms.Button();
            this.dataGridView_scooterRecords = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countScootersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTripDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTripDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.couponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource_scooterRecords = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_rent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_scooterRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_scooterRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_rent
            // 
            this.pictureBox_rent.Image = global::Bolt.Properties.Resources.orenda1;
            this.pictureBox_rent.Location = new System.Drawing.Point(-21, -1);
            this.pictureBox_rent.Name = "pictureBox_rent";
            this.pictureBox_rent.Size = new System.Drawing.Size(1947, 1011);
            this.pictureBox_rent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_rent.TabIndex = 0;
            this.pictureBox_rent.TabStop = false;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_search.Image = global::Bolt.Properties.Resources.Rectangle_11;
            this.button_search.Location = new System.Drawing.Point(1244, 465);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(80, 80);
            this.button_search.TabIndex = 1;
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // pictureBox_mape
            // 
            this.pictureBox_mape.Image = global::Bolt.Properties.Resources.Group_17;
            this.pictureBox_mape.Location = new System.Drawing.Point(1246, 571);
            this.pictureBox_mape.Name = "pictureBox_mape";
            this.pictureBox_mape.Size = new System.Drawing.Size(637, 345);
            this.pictureBox_mape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_mape.TabIndex = 2;
            this.pictureBox_mape.TabStop = false;
            this.pictureBox_mape.Visible = false;
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_search.Location = new System.Drawing.Point(1330, 483);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(548, 39);
            this.textBox_search.TabIndex = 3;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // textBox_login
            // 
            this.textBox_login.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_login.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_login.Location = new System.Drawing.Point(1318, 69);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.ReadOnly = true;
            this.textBox_login.Size = new System.Drawing.Size(456, 39);
            this.textBox_login.TabIndex = 4;
            // 
            // textBox_kolScooters
            // 
            this.textBox_kolScooters.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_kolScooters.Location = new System.Drawing.Point(724, 348);
            this.textBox_kolScooters.Name = "textBox_kolScooters";
            this.textBox_kolScooters.Size = new System.Drawing.Size(456, 39);
            this.textBox_kolScooters.TabIndex = 6;
            this.textBox_kolScooters.Text = "15";
            // 
            // textBox_start
            // 
            this.textBox_start.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_start.Location = new System.Drawing.Point(724, 449);
            this.textBox_start.Name = "textBox_start";
            this.textBox_start.Size = new System.Drawing.Size(397, 39);
            this.textBox_start.TabIndex = 8;
            this.textBox_start.Text = "11";
            // 
            // textBox_end
            // 
            this.textBox_end.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_end.Location = new System.Drawing.Point(724, 548);
            this.textBox_end.Name = "textBox_end";
            this.textBox_end.Size = new System.Drawing.Size(397, 39);
            this.textBox_end.TabIndex = 9;
            this.textBox_end.Text = "12";
            // 
            // button_rent
            // 
            this.button_rent.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_rent.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_rent.ForeColor = System.Drawing.SystemColors.Control;
            this.button_rent.Location = new System.Drawing.Point(724, 735);
            this.button_rent.Name = "button_rent";
            this.button_rent.Size = new System.Drawing.Size(456, 54);
            this.button_rent.TabIndex = 10;
            this.button_rent.Text = "Орендувати";
            this.button_rent.UseVisualStyleBackColor = false;
            this.button_rent.Click += new System.EventHandler(this.button_rent_Click);
            // 
            // button_issuePoint
            // 
            this.button_issuePoint.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_issuePoint.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_issuePoint.ForeColor = System.Drawing.SystemColors.Control;
            this.button_issuePoint.Location = new System.Drawing.Point(724, 808);
            this.button_issuePoint.Name = "button_issuePoint";
            this.button_issuePoint.Size = new System.Drawing.Size(456, 92);
            this.button_issuePoint.TabIndex = 12;
            this.button_issuePoint.Text = "Обрати пункт видачі поточного запису";
            this.button_issuePoint.UseVisualStyleBackColor = false;
            this.button_issuePoint.Click += new System.EventHandler(this.button_issuePoint_Click);
            // 
            // dtPicker
            // 
            this.dtPicker.CalendarFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtPicker.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtPicker.Location = new System.Drawing.Point(724, 649);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(456, 38);
            this.dtPicker.TabIndex = 13;
            // 
            // button_more
            // 
            this.button_more.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_more.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_more.ForeColor = System.Drawing.SystemColors.Control;
            this.button_more.Location = new System.Drawing.Point(1699, 153);
            this.button_more.Name = "button_more";
            this.button_more.Size = new System.Drawing.Size(179, 54);
            this.button_more.TabIndex = 14;
            this.button_more.Text = "Більше...";
            this.button_more.UseVisualStyleBackColor = false;
            this.button_more.Click += new System.EventHandler(this.button_more_Click);
            // 
            // dataGridView_scooterRecords
            // 
            this.dataGridView_scooterRecords.AllowUserToAddRows = false;
            this.dataGridView_scooterRecords.AllowUserToDeleteRows = false;
            this.dataGridView_scooterRecords.AutoGenerateColumns = false;
            this.dataGridView_scooterRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_scooterRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.countScootersDataGridViewTextBoxColumn,
            this.startTripDataGridViewTextBoxColumn,
            this.endTripDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.couponDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn});
            this.dataGridView_scooterRecords.DataSource = this.bindingSource_scooterRecords;
            this.dataGridView_scooterRecords.Location = new System.Drawing.Point(1244, 223);
            this.dataGridView_scooterRecords.Name = "dataGridView_scooterRecords";
            this.dataGridView_scooterRecords.ReadOnly = true;
            this.dataGridView_scooterRecords.RowHeadersWidth = 51;
            this.dataGridView_scooterRecords.RowTemplate.Height = 29;
            this.dataGridView_scooterRecords.Size = new System.Drawing.Size(634, 226);
            this.dataGridView_scooterRecords.TabIndex = 15;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "№";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.ToolTipText = "№";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // countScootersDataGridViewTextBoxColumn
            // 
            this.countScootersDataGridViewTextBoxColumn.DataPropertyName = "CountScooters";
            this.countScootersDataGridViewTextBoxColumn.HeaderText = "Кількість самокатів";
            this.countScootersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countScootersDataGridViewTextBoxColumn.Name = "countScootersDataGridViewTextBoxColumn";
            this.countScootersDataGridViewTextBoxColumn.ReadOnly = true;
            this.countScootersDataGridViewTextBoxColumn.ToolTipText = "Кількість самокатів";
            this.countScootersDataGridViewTextBoxColumn.Width = 125;
            // 
            // startTripDataGridViewTextBoxColumn
            // 
            this.startTripDataGridViewTextBoxColumn.DataPropertyName = "StartTrip";
            this.startTripDataGridViewTextBoxColumn.HeaderText = "Час початку поїздки";
            this.startTripDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startTripDataGridViewTextBoxColumn.Name = "startTripDataGridViewTextBoxColumn";
            this.startTripDataGridViewTextBoxColumn.ReadOnly = true;
            this.startTripDataGridViewTextBoxColumn.Width = 125;
            // 
            // endTripDataGridViewTextBoxColumn
            // 
            this.endTripDataGridViewTextBoxColumn.DataPropertyName = "EndTrip";
            this.endTripDataGridViewTextBoxColumn.HeaderText = "Час закінчення поїздки";
            this.endTripDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endTripDataGridViewTextBoxColumn.Name = "endTripDataGridViewTextBoxColumn";
            this.endTripDataGridViewTextBoxColumn.ReadOnly = true;
            this.endTripDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // couponDataGridViewTextBoxColumn
            // 
            this.couponDataGridViewTextBoxColumn.DataPropertyName = "Coupon";
            this.couponDataGridViewTextBoxColumn.HeaderText = "Талон";
            this.couponDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.couponDataGridViewTextBoxColumn.Name = "couponDataGridViewTextBoxColumn";
            this.couponDataGridViewTextBoxColumn.ReadOnly = true;
            this.couponDataGridViewTextBoxColumn.Width = 125;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "%";
            this.discountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            this.discountDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSource_scooterRecords
            // 
            this.bindingSource_scooterRecords.DataSource = typeof(Bolt.ClassesAndInterfaces.Scooter);
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 993);
            this.Controls.Add(this.dataGridView_scooterRecords);
            this.Controls.Add(this.button_more);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.button_issuePoint);
            this.Controls.Add(this.button_rent);
            this.Controls.Add(this.textBox_end);
            this.Controls.Add(this.textBox_start);
            this.Controls.Add(this.textBox_kolScooters);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.pictureBox_mape);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.pictureBox_rent);
            this.Name = "Rent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bolt | Оренда електросамокату";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Rent_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_rent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_scooterRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_scooterRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox_rent;
        private Button button_search;
        private PictureBox pictureBox_mape;
        private TextBox textBox_search;
        private TextBox textBox_kolScooters;
        private TextBox textBox_start;
        private TextBox textBox_end;
        private Button button_rent;
        private Button button_issuePoint;
        public TextBox textBox_login;
        private DateTimePicker dtPicker;
        private Button button_more;
        private DataGridView dataGridView_scooterRecords;
        private BindingSource bindingSource_scooterRecords;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countScootersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startTripDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endTripDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn couponDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
    }
}