using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WHCAsistencia
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wHCAsistenciasDataSet.Business' table. You can move, or remove it, as needed.
            this.businessTableAdapter.Fill(this.wHCAsistenciasDataSet.Business);

        }

        private void colaboradoresDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                Form detalleForm = new DetalleCitasEmpresa(e.RowIndex+1);
                detalleForm.Show();                
            }
        }

        private void colaboradoresDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                e.Value = "Ver Citas";
            }
        }

        private void flatClose1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
