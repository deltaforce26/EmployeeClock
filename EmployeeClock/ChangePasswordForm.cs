using EmployeeClock.DAL.Services;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeClock
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void button_changePassword_Click(object sender, EventArgs e)
        {
            string id = textBox_id.Text;
            string oldPassword = textBox_old_password.Text;
            string newPassword = textBox_NewPassword.Text;
            string confirmPassword = textBoxConfirmNewPassword.Text;

            if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Missing required fields.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords don't match.");
                return;
            }

            DateTime expiryDate = DateTime.Now.AddMonths(6);
            

            if (DBcontext.PasswordValidation(id, oldPassword))
            {
                

                SqlParameter[] parametersUpdate =
                {
                    new SqlParameter("@id", id),
                    new SqlParameter("@oldPassword", oldPassword)
                };

                SqlParameter[] parametersInsert =
                {
                    new SqlParameter("@id", id),
                    new SqlParameter("@expiryDate", expiryDate),
                    new SqlParameter("@newPassword", newPassword)
                };

                DBcontext.MakeQuery(
                    "UPDATE P SET P.IsActive = 0 " +
                    "FROM Passwords P " +
                    "INNER JOIN Employees E ON P.EmployeeID = E.ID " +
                    "WHERE E.EmployeeNat = @id AND P.EmployeePassword = @oldPassword",
                    parametersUpdate
                );

                DBcontext.MakeQuery(
                    "INSERT INTO Passwords (EmployeeID, ExpiryDate, IsActive, EmployeePassword) " +
                    "VALUES ((SELECT ID FROM Employees WHERE EmployeeNat = @id), @expiryDate, 1, @newPassword)",
                    parametersInsert
                );

                MessageBox.Show("Your password has been changed.");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            FormHandler.CloseAllForms();
            FormHandler.ShowForm("LoginForm", "");
        }
    }
}
