namespace WHCAsistencia
{
    partial class Main
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
            this.wHCAsistenciasDataSet = new WHCAsistencia.WHCAsistenciasDataSet();
            this.businessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.businessTableAdapter = new WHCAsistencia.WHCAsistenciasDataSetTableAdapters.BusinessTableAdapter();
            this.WHCAsistencias = new FlatUI.FormSkin();
            this.flatTabControl1 = new FlatUI.FlatTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNuevoColaborador = new FlatUI.FlatButton();
            this.colaboradoresDataGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessRUCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleEmpresa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.flatMini1 = new FlatUI.FlatMini();
            this.flatClose1 = new FlatUI.FlatClose();
            ((System.ComponentModel.ISupportInitialize)(this.wHCAsistenciasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessBindingSource)).BeginInit();
            this.WHCAsistencias.SuspendLayout();
            this.flatTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradoresDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // wHCAsistenciasDataSet
            // 
            this.wHCAsistenciasDataSet.DataSetName = "WHCAsistenciasDataSet";
            this.wHCAsistenciasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // businessBindingSource
            // 
            this.businessBindingSource.DataMember = "Business";
            this.businessBindingSource.DataSource = this.wHCAsistenciasDataSet;
            // 
            // businessTableAdapter
            // 
            this.businessTableAdapter.ClearBeforeFill = true;
            // 
            // WHCAsistencias
            // 
            this.WHCAsistencias.BackColor = System.Drawing.Color.White;
            this.WHCAsistencias.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.WHCAsistencias.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.WHCAsistencias.Controls.Add(this.flatTabControl1);
            this.WHCAsistencias.Controls.Add(this.flatMini1);
            this.WHCAsistencias.Controls.Add(this.flatClose1);
            this.WHCAsistencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WHCAsistencias.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.WHCAsistencias.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.WHCAsistencias.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.WHCAsistencias.HeaderMaximize = false;
            this.WHCAsistencias.Location = new System.Drawing.Point(0, 0);
            this.WHCAsistencias.Name = "WHCAsistencias";
            this.WHCAsistencias.Size = new System.Drawing.Size(720, 480);
            this.WHCAsistencias.TabIndex = 0;
            this.WHCAsistencias.Text = "WHC Asistencias";
            // 
            // flatTabControl1
            // 
            this.flatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.flatTabControl1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatTabControl1.Controls.Add(this.tabPage1);
            this.flatTabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatTabControl1.ItemSize = new System.Drawing.Size(120, 40);
            this.flatTabControl1.Location = new System.Drawing.Point(0, 37);
            this.flatTabControl1.Name = "flatTabControl1";
            this.flatTabControl1.SelectedIndex = 0;
            this.flatTabControl1.Size = new System.Drawing.Size(720, 443);
            this.flatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.flatTabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage1.Controls.Add(this.btnNuevoColaborador);
            this.tabPage1.Controls.Add(this.colaboradoresDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(712, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Empresas";
            // 
            // btnNuevoColaborador
            // 
            this.btnNuevoColaborador.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevoColaborador.BaseColor = System.Drawing.Color.Empty;
            this.btnNuevoColaborador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoColaborador.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNuevoColaborador.Location = new System.Drawing.Point(8, 355);
            this.btnNuevoColaborador.Name = "btnNuevoColaborador";
            this.btnNuevoColaborador.Rounded = false;
            this.btnNuevoColaborador.Size = new System.Drawing.Size(106, 32);
            this.btnNuevoColaborador.TabIndex = 0;
            this.btnNuevoColaborador.Text = "Nuevo";
            this.btnNuevoColaborador.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // colaboradoresDataGrid
            // 
            this.colaboradoresDataGrid.AllowUserToAddRows = false;
            this.colaboradoresDataGrid.AllowUserToDeleteRows = false;
            this.colaboradoresDataGrid.AutoGenerateColumns = false;
            this.colaboradoresDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.colaboradoresDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.businessNameDataGridViewTextBoxColumn,
            this.businessRUCDataGridViewTextBoxColumn,
            this.detalleEmpresa,
            this.deletedDataGridViewCheckBoxColumn});
            this.colaboradoresDataGrid.DataSource = this.businessBindingSource;
            this.colaboradoresDataGrid.Location = new System.Drawing.Point(6, 6);
            this.colaboradoresDataGrid.Name = "colaboradoresDataGrid";
            this.colaboradoresDataGrid.ReadOnly = true;
            this.colaboradoresDataGrid.Size = new System.Drawing.Size(698, 334);
            this.colaboradoresDataGrid.TabIndex = 1;
            this.colaboradoresDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.colaboradoresDataGrid_CellContentClick);
            this.colaboradoresDataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.colaboradoresDataGrid_CellFormatting);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "#";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // businessNameDataGridViewTextBoxColumn
            // 
            this.businessNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.businessNameDataGridViewTextBoxColumn.DataPropertyName = "businessName";
            this.businessNameDataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.businessNameDataGridViewTextBoxColumn.Name = "businessNameDataGridViewTextBoxColumn";
            this.businessNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.businessNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // businessRUCDataGridViewTextBoxColumn
            // 
            this.businessRUCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.businessRUCDataGridViewTextBoxColumn.DataPropertyName = "businessRUC";
            this.businessRUCDataGridViewTextBoxColumn.HeaderText = "RUC";
            this.businessRUCDataGridViewTextBoxColumn.Name = "businessRUCDataGridViewTextBoxColumn";
            this.businessRUCDataGridViewTextBoxColumn.ReadOnly = true;
            this.businessRUCDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // detalleEmpresa
            // 
            this.detalleEmpresa.DataPropertyName = "id";
            this.detalleEmpresa.HeaderText = "Acciones";
            this.detalleEmpresa.Name = "detalleEmpresa";
            this.detalleEmpresa.ReadOnly = true;
            this.detalleEmpresa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // deletedDataGridViewCheckBoxColumn
            // 
            this.deletedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deletedDataGridViewCheckBoxColumn.DataPropertyName = "deleted";
            this.deletedDataGridViewCheckBoxColumn.HeaderText = "deleted";
            this.deletedDataGridViewCheckBoxColumn.Name = "deletedDataGridViewCheckBoxColumn";
            this.deletedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.deletedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(666, 10);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 1;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(690, 13);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 0;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatClose1.Click += new System.EventHandler(this.flatClose1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.WHCAsistencias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wHCAsistenciasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessBindingSource)).EndInit();
            this.WHCAsistencias.ResumeLayout(false);
            this.flatTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colaboradoresDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin WHCAsistencias;
        private FlatUI.FlatTabControl flatTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private FlatUI.FlatMini flatMini1;
        private FlatUI.FlatClose flatClose1;
        private FlatUI.FlatButton btnNuevoColaborador;
        private System.Windows.Forms.DataGridView colaboradoresDataGrid;
        private WHCAsistenciasDataSet wHCAsistenciasDataSet;
        private System.Windows.Forms.BindingSource businessBindingSource;
        private WHCAsistenciasDataSetTableAdapters.BusinessTableAdapter businessTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessRUCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn detalleEmpresa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn;
    }
}

