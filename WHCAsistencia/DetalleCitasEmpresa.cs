using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WHCAsistencia
{
    public partial class DetalleCitasEmpresa : Form
    {
        public int businessId;
        public DetalleCitasEmpresa(int businessId)
        {
            this.businessId = businessId;
            InitializeComponent();
            LoadData();            
        }

        private void LoadData()
        {
            DataSet ptDataset = new DataSet();
            SqlConnection sqlCon = new SqlConnection("Data Source=.;Initial Catalog=WHCAsistencias;Integrated Security=True");
            sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand("AppointmentsByBusinessId", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@businessId", businessId);
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(ptDataset);
            dataGridView1.DataSource = ptDataset.Tables[0];
            
            dataGridView1.Columns[3].ValueType = typeof(DataGridViewButtonColumn);
            sqlCon.Close();
        }

        private void flatClose1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
