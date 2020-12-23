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
    public partial class Employee : Form
    {
        private SqlConnection sqlConnection;
        private SqlDataAdapter da;
        private DataTable dt;
        public Employee(String con)
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(con);
            sqlConnection.Open();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO tb1_EmployeeDetails(IdEmployee,EmployeeName, 
 ContactNumber, IdDesignation, IdReportingTo) values('" + id.Text + "','" + name.Text + "','" + contact.Text + "'," + des.Text +", " + report.Text + ")";
            da = new SqlDataAdapter(query, sqlConnection);
            dt = new DataTable();
            da.Fill(dt);

 MessageBox.Show("Employees Added Successfully...!");
        }
    }
}
