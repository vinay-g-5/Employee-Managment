using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employeee
{
    public partial class Form1 : Form
    {
       private String con = "Data Source=LAPTOP-S8FKPDUB\\SQLEXPRESS;Initial Catalog=db_emp;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(con);
            employee.Show();


        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void projectLeaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project project = new Project(con);
            project.Show();

        }

        private void mangerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager(con);
            manager.Show();

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report report = new Report(con);
            report.Show();
        }
    }
}
