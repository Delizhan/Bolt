namespace Bolt.Interface
{
    partial class Additionally
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
            this.pictureBox_additionally = new System.Windows.Forms.PictureBox();
            this.bindingSource_scooter = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource_point = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_coupon = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countScootersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTripDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTripDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.couponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_date = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_point = new System.Windows.Forms.DataGridView();
            this.idScooterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberBuildingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_coupon = new System.Windows.Forms.Button();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.button_point = new System.Windows.Forms.Button();
            this.button_date = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_additionally)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_scooter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_point)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_coupon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_point)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_additionally
            // 
            this.pictureBox_additionally.Image = global::Bolt.Properties.Resources.additionally2;
            this.pictureBox_additionally.Location = new System.Drawing.Point(0, -1);
            this.pictureBox_additionally.Name = "pictureBox_additionally";
            this.pictureBox_additionally.Size = new System.Drawing.Size(1460, 1025);
            this.pictureBox_additionally.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_additionally.TabIndex = 0;
            this.pictureBox_additionally.TabStop = false;
            // 
            // bindingSource_scooter
            // 
            this.bindingSource_scooter.DataSource = typeof(Bolt.ClassesAndInterfaces.Scooter);
            // 
            // bindingSource_point
            // 
            this.bindingSource_point.DataSource = typeof(Bolt.ClassesAndInterfaces.IssuePoint);
            // 
            // dataGridView_coupon
            // 
            this.dataGridView_coupon.AllowUserToAddRows = false;
            this.dataGridView_coupon.AllowUserToDeleteRows = false;
            this.dataGridView_coupon.AutoGenerateColumns = false;
            this.dataGridView_coupon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_coupon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.countScootersDataGridViewTextBoxColumn,
            this.startTripDataGridViewTextBoxColumn,
            this.endTripDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.couponDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn});
            this.dataGridView_coupon.DataSource = this.bindingSource_scooter;
            this.dataGridView_coupon.Location = new System.Drawing.Point(150, 294);
            this.dataGridView_coupon.Name = "dataGridView_coupon";
            this.dataGridView_coupon.ReadOnly = true;
            this.dataGridView_coupon.RowHeadersWidth = 51;
            this.dataGridView_coupon.RowTemplate.Height = 29;
            this.dataGridView_coupon.Size = new System.Drawing.Size(563, 207);
            this.dataGridView_coupon.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "№";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // countScootersDataGridViewTextBoxColumn
            // 
            this.countScootersDataGridViewTextBoxColumn.DataPropertyName = "CountScooters";
            this.countScootersDataGridViewTextBoxColumn.HeaderText = "Кількість самокатів";
            this.countScootersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countScootersDataGridViewTextBoxColumn.Name = "countScootersDataGridViewTextBoxColumn";
            this.countScootersDataGridViewTextBoxColumn.ReadOnly = true;
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
            // dataGridView_date
            // 
            this.dataGridView_date.AllowUserToAddRows = false;
            this.dataGridView_date.AllowUserToDeleteRows = false;
            this.dataGridView_date.AutoGenerateColumns = false;
            this.dataGridView_date.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_date.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView_date.DataSource = this.bindingSource_scooter;
            this.dataGridView_date.Location = new System.Drawing.Point(867, 414);
            this.dataGridView_date.Name = "dataGridView_date";
            this.dataGridView_date.ReadOnly = true;
            this.dataGridView_date.RowHeadersWidth = 51;
            this.dataGridView_date.RowTemplate.Height = 29;
            this.dataGridView_date.Size = new System.Drawing.Size(563, 207);
            this.dataGridView_date.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CountScooters";
            this.dataGridViewTextBoxColumn2.HeaderText = "Кількість самокатів";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StartTrip";
            this.dataGridViewTextBoxColumn3.HeaderText = "Час початку поїздки";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EndTrip";
            this.dataGridViewTextBoxColumn4.HeaderText = "Час закінчення поїздки";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Coupon";
            this.dataGridViewTextBoxColumn6.HeaderText = "Талон";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Discount";
            this.dataGridViewTextBoxColumn7.HeaderText = "%";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridView_point
            // 
            this.dataGridView_point.AllowUserToAddRows = false;
            this.dataGridView_point.AllowUserToDeleteRows = false;
            this.dataGridView_point.AutoGenerateColumns = false;
            this.dataGridView_point.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_point.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idScooterDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn1,
            this.cityDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.numberBuildingDataGridViewTextBoxColumn});
            this.dataGridView_point.DataSource = this.bindingSource_point;
            this.dataGridView_point.Location = new System.Drawing.Point(150, 708);
            this.dataGridView_point.Name = "dataGridView_point";
            this.dataGridView_point.ReadOnly = true;
            this.dataGridView_point.RowHeadersWidth = 51;
            this.dataGridView_point.RowTemplate.Height = 29;
            this.dataGridView_point.Size = new System.Drawing.Size(563, 207);
            this.dataGridView_point.TabIndex = 3;
            // 
            // idScooterDataGridViewTextBoxColumn
            // 
            this.idScooterDataGridViewTextBoxColumn.DataPropertyName = "IdScooter";
            this.idScooterDataGridViewTextBoxColumn.HeaderText = "№ запису";
            this.idScooterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idScooterDataGridViewTextBoxColumn.Name = "idScooterDataGridViewTextBoxColumn";
            this.idScooterDataGridViewTextBoxColumn.ReadOnly = true;
            this.idScooterDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "№ пункту видачі";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "Місто";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn.Width = 125;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Вулиця";
            this.streetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.ReadOnly = true;
            this.streetDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberBuildingDataGridViewTextBoxColumn
            // 
            this.numberBuildingDataGridViewTextBoxColumn.DataPropertyName = "NumberBuilding";
            this.numberBuildingDataGridViewTextBoxColumn.HeaderText = "Будинок";
            this.numberBuildingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberBuildingDataGridViewTextBoxColumn.Name = "numberBuildingDataGridViewTextBoxColumn";
            this.numberBuildingDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberBuildingDataGridViewTextBoxColumn.Width = 125;
            // 
            // button_coupon
            // 
            this.button_coupon.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_coupon.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_coupon.ForeColor = System.Drawing.SystemColors.Control;
            this.button_coupon.Location = new System.Drawing.Point(150, 510);
            this.button_coupon.Name = "button_coupon";
            this.button_coupon.Size = new System.Drawing.Size(200, 54);
            this.button_coupon.TabIndex = 23;
            this.button_coupon.Text = "Відсортувати";
            this.button_coupon.UseVisualStyleBackColor = false;
            this.button_coupon.Click += new System.EventHandler(this.button_coupon_Click);
            // 
            // dtPicker
            // 
            this.dtPicker.CalendarFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtPicker.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtPicker.Location = new System.Drawing.Point(867, 328);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(563, 38);
            this.dtPicker.TabIndex = 24;
            // 
            // button_point
            // 
            this.button_point.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_point.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_point.ForeColor = System.Drawing.SystemColors.Control;
            this.button_point.Location = new System.Drawing.Point(150, 923);
            this.button_point.Name = "button_point";
            this.button_point.Size = new System.Drawing.Size(200, 54);
            this.button_point.TabIndex = 25;
            this.button_point.Text = "Переглянути";
            this.button_point.UseVisualStyleBackColor = false;
            this.button_point.Click += new System.EventHandler(this.button_point_Click);
            // 
            // button_date
            // 
            this.button_date.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_date.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_date.ForeColor = System.Drawing.SystemColors.Control;
            this.button_date.Location = new System.Drawing.Point(867, 629);
            this.button_date.Name = "button_date";
            this.button_date.Size = new System.Drawing.Size(200, 54);
            this.button_date.TabIndex = 26;
            this.button_date.Text = "Переглянути";
            this.button_date.UseVisualStyleBackColor = false;
            this.button_date.Click += new System.EventHandler(this.button_date_Click);
            // 
            // Additionally
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 993);
            this.Controls.Add(this.button_date);
            this.Controls.Add(this.button_point);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.button_coupon);
            this.Controls.Add(this.dataGridView_point);
            this.Controls.Add(this.dataGridView_date);
            this.Controls.Add(this.dataGridView_coupon);
            this.Controls.Add(this.pictureBox_additionally);
            this.Name = "Additionally";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bolt | Додатково";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_additionally)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_scooter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_point)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_coupon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_point)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox_additionally;
        private BindingSource bindingSource_scooter;
        private BindingSource bindingSource_point;
        private DataGridView dataGridView_coupon;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countScootersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startTripDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endTripDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn couponDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private DataGridView dataGridView_date;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridView dataGridView_point;
        private DataGridViewTextBoxColumn idScooterDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberBuildingDataGridViewTextBoxColumn;
        private Button button_coupon;
        private DateTimePicker dtPicker;
        private Button button_point;
        private Button button_date;
    }
}