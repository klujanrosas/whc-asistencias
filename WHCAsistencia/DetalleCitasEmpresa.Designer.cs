namespace WHCAsistencia
{
    partial class DetalleCitasEmpresa
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
            this.detalleCitasForm = new FlatUI.FormSkin();
            this.flatClose1 = new FlatUI.FlatClose();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appointmentsByBusinessIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wHCAsistenciasDataSet1 = new WHCAsistencia.WHCAsistenciasDataSet1();
            this.appointmentsByBusinessIdTableAdapter = new WHCAsistencia.WHCAsistenciasDataSet1TableAdapters.AppointmentsByBusinessIdTableAdapter();
            this.wHCAsistenciasDataSet2 = new WHCAsistencia.WHCAsistenciasDataSet2();
            this.appointmentsByBusinessIdBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentsByBusinessIdTableAdapter1 = new WHCAsistencia.WHCAsistenciasDataSet2TableAdapters.AppointmentsByBusinessIdTableAdapter();
            this.doctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDeCitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.detalleCitasForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsByBusinessIdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wHCAsistenciasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wHCAsistenciasDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsByBusinessIdBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // detalleCitasForm
            // 
            this.detalleCitasForm.BackColor = System.Drawing.Color.White;
            this.detalleCitasForm.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.detalleCitasForm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.detalleCitasForm.Controls.Add(this.flatClose1);
            this.detalleCitasForm.Controls.Add(this.dataGridView1);
            this.detalleCitasForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detalleCitasForm.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.detalleCitasForm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.detalleCitasForm.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.detalleCitasForm.HeaderMaximize = false;
            this.detalleCitasForm.Location = new System.Drawing.Point(0, 0);
            this.detalleCitasForm.Name = "detalleCitasForm";
            this.detalleCitasForm.Size = new System.Drawing.Size(720, 480);
            this.detalleCitasForm.TabIndex = 0;
            this.detalleCitasForm.Text = "Citas";
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.CausesValidation = false;
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(689, 13);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 1;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatClose1.Click += new System.EventHandler(this.flatClose1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorDataGridViewTextBoxColumn,
            this.fechaDeCitaDataGridViewTextBoxColumn,
            this.pacienteDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.appointmentsByBusinessIdBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(696, 406);
            this.dataGridView1.TabIndex = 0;
            // 
            // appointmentsByBusinessIdBindingSource
            // 
            this.appointmentsByBusinessIdBindingSource.DataMember = "AppointmentsByBusinessId";
            this.appointmentsByBusinessIdBindingSource.DataSource = this.wHCAsistenciasDataSet1;
            // 
            // wHCAsistenciasDataSet1
            // 
            this.wHCAsistenciasDataSet1.DataSetName = "WHCAsistenciasDataSet1";
            this.wHCAsistenciasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentsByBusinessIdTableAdapter
            // 
            this.appointmentsByBusinessIdTableAdapter.ClearBeforeFill = true;
            // 
            // wHCAsistenciasDataSet2
            // 
            this.wHCAsistenciasDataSet2.DataSetName = "WHCAsistenciasDataSet2";
            this.wHCAsistenciasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentsByBusinessIdBindingSource1
            // 
            this.appointmentsByBusinessIdBindingSource1.DataMember = "AppointmentsByBusinessId";
            this.appointmentsByBusinessIdBindingSource1.DataSource = this.wHCAsistenciasDataSet2;
            // 
            // appointmentsByBusinessIdTableAdapter1
            // 
            this.appointmentsByBusinessIdTableAdapter1.ClearBeforeFill = true;
            // 
            // doctorDataGridViewTextBoxColumn
            // 
            this.doctorDataGridViewTextBoxColumn.DataPropertyName = "Doctor";
            this.doctorDataGridViewTextBoxColumn.HeaderText = "Doctor";
            this.doctorDataGridViewTextBoxColumn.Name = "doctorDataGridViewTextBoxColumn";
            this.doctorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDeCitaDataGridViewTextBoxColumn
            // 
            this.fechaDeCitaDataGridViewTextBoxColumn.DataPropertyName = "Fecha de Cita";
            this.fechaDeCitaDataGridViewTextBoxColumn.HeaderText = "Fecha de Cita";
            this.fechaDeCitaDataGridViewTextBoxColumn.Name = "fechaDeCitaDataGridViewTextBoxColumn";
            this.fechaDeCitaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pacienteDataGridViewTextBoxColumn
            // 
            this.pacienteDataGridViewTextBoxColumn.DataPropertyName = "Paciente";
            this.pacienteDataGridViewTextBoxColumn.HeaderText = "Paciente";
            this.pacienteDataGridViewTextBoxColumn.Name = "pacienteDataGridViewTextBoxColumn";
            this.pacienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DetalleCitasEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.detalleCitasForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetalleCitasEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalleCitasEmpresa";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.detalleCitasForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsByBusinessIdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wHCAsistenciasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wHCAsistenciasDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsByBusinessIdBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin detalleCitasForm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource appointmentsByBusinessIdBindingSource;
        private WHCAsistenciasDataSet1 wHCAsistenciasDataSet1;
        private WHCAsistenciasDataSet1TableAdapters.AppointmentsByBusinessIdTableAdapter appointmentsByBusinessIdTableAdapter;
        private FlatUI.FlatClose flatClose1;
        private System.Windows.Forms.BindingSource appointmentsByBusinessIdBindingSource1;
        private WHCAsistenciasDataSet2 wHCAsistenciasDataSet2;
        private WHCAsistenciasDataSet2TableAdapters.AppointmentsByBusinessIdTableAdapter appointmentsByBusinessIdTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDeCitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn estadoDataGridViewTextBoxColumn;
    }
}