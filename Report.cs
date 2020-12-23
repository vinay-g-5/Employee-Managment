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
    public partial class Report : Form
    {
        private SqlConnection sqlConnection;
        private SqlDataAdapter da;
        private DataTable dt;

        public Report(String con)
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(con);
            sqlConnection.Open();
            fill();
        }
        private void fill()
        {
            da = new SqlDataAdapter("SELECT e.EmployeeName as EMPLOYEE, e1.EmployeeName as ReportingManager from tb1_EmployeeDetails e, tb1_EmployeeDetails e1 where e.IdReportingTo = e1.IdEmployee", sqlConnection);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                dataGridView1.DataSource = dt;
            else
            {
                dataGridView1.DataSource = null;
                MessageBox.Show("No employees availabe!");
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
