using EmployeeClock.DAL.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeClock
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
            
        }

       


        private void button_enter_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            string password = textBox_password.Text;
            if(DBcontext.CheckPassExpiaryDate(id, password))
            {
                if (DBcontext.PasswordValidation(textBox_id.Text, textBox_password.Text))
                {
                    FormHandler.CloseAllForms();
                    FormHandler.ShowForm("EmployeeIdentityForm", id);
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            } 
            
        }

        private void button_forgot_password_Click(object sender, EventArgs e)
        {
            FormHandler.CloseAllForms();
            FormHandler.ShowForm("ChangePasswordForm", "");
        }
    }
}
