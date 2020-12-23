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

namespace Employeee
{
    public partial class Manager : Form
    {
        private SqlConnection sqlConnection;
        private SqlDataAdapter da;
        private DataTable dt;

        public Manager(String con)
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(con);
            sqlConnection.Open();
            fill();
        }
        private void fill()
        {
            da = new SqlDataAdapter("Select ed.IdEmployee, ed.EmployeeName from tb1_EmployeeDetails ed where ed.IdDesignation = 1",sqlConnection );
 dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                cmbName.DataSource = dt;
                cmbName.DisplayMember = "EmployeeName";
                cmbName.ValueMember = "IdEmployee";
            }
        }
        private void Manager_Load(object sender, EventArgs e)
        {

        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT EmployeeName,ContactNumber FROM tb1_EmployeeDetails WHERE IdDesignation = 2 and IdReportingTo = " + cmbName.SelectedValue, sqlConnection);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
                dataGridView1.DataSource = dt;
            else
            {
                dataGridView1.DataSource = null;
                MessageBox.Show("Not availabe for s...!");
            }
        }
    }
}
