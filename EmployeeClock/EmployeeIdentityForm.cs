using EmployeeClock.DAL.Services;
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

namespace EmployeeClock
{
    public partial class EmployeeIdentityForm : Form
    {
        public EmployeeIdentityForm(string employeenat)
        {
            InitializeComponent();
            LoadText(employeenat);


        }
        private int _emp_code;
        private DateTime _entryTime;
        private DateTime _exitTime;
        private DateTime _now = DateTime.Now;
        private void LoadText(string employeeNat)
        {
            label_employee_nat.Text = employeeNat;
            SqlParameter[] nat_params = { new SqlParameter("@emp_nat", employeeNat) };
            string last_date_query = "SELECT TOP 1 EmployeeCode, EntryTime , " +
                "ExitTime FROM EmployeeAttendance ea INNER JOIN " +
                "Employees e on ea.EmployeeCode = e.ID where e.EmployeeNat = " +
                "@emp_nat AND EntryTime IS NOT NULL AND ExitTime IS NOT NULL " +
                "order by(EntryTime) desc;";
            DataTable last_time = DBcontext.MakeQuery(last_date_query, nat_params);

            if (last_time.Rows.Count > 0)
            {
                _emp_code = Convert.ToInt32(last_time.Rows[0][0].ToString());

                if (!last_time.Rows[0].IsNull("EntryTime"))
                {
                    _entryTime = Convert.ToDateTime(last_time.Rows[0]["EntryTime"].ToString());
                    label_last_entry2.Text = _entryTime.ToString("yyyy-MM-dd");
                }
                else
                {
                    label_last_entry2.Text = "N/A";
                }

                if (!last_time.Rows[0].IsNull("ExitTime"))
                {
                    _exitTime = Convert.ToDateTime(last_time.Rows[0]["ExitTime"].ToString());
                    label_last_exit2.Text = _exitTime.ToString("yyyy-MM-dd");
                }
                else
                {
                    label_last_exit2.Text = "N/A";
                }
            }
            else
            {
                label_last_entry2.Text = "N/A";
                label_last_exit2.Text = "N/A";
            }
        }

        private void EmployeeIdentityForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel_cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHandler.CloseAllForms();
            FormHandler.ShowForm("LoginForm", "");
        }

        private void button_entry_Click(object sender, EventArgs e)
        {
            if (_entryTime > _now.AddHours(-24) && _entryTime <= _now)
            {
                DBcontext.MakeQuery($"insert into EmployeeAttendance(EmployeeCode, entrytime)" +
                $"values({_emp_code}, '{DateTime.Now}')");
                MessageBox.Show("You have clocked in successfully");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("It has been more than 24 hours since your last exit," +
                    "Please contact system admin");
                Application.Exit();

            }
                
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            
            if (_entryTime > _now.AddHours(-24) && _entryTime <= _now)
            {
                DBcontext.MakeQuery($"UPDATE EmployeeAttendance SET ExitTime " +
                    $"= '{_now}' WHERE EmployeeCode = {_emp_code} " +
                    $"AND year(EntryTime) = '{_entryTime.Year}' AND MONTH(EntryTime) = '{_entryTime.Month}' AND DAY(EntryTime) = '{_entryTime.Day}'; ");
                MessageBox.Show("You have clocked out successfully");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("It has been more than 24 hours since your last entry," +
                    "Please contact the system admin");
                Application.Exit();
            }
            
        }
    }
}
