using EmployeeClock.DAL.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClock
{
    internal class FormHandler
    {
        public static void CloseAllForms()
        {
            List<Form> openForms = new List<Form>(Application.OpenForms.Cast<Form>());
            foreach (Form item in openForms)
            {
                item.Close();
            }
        }

        public static void ShowForm(string formName, string employeeNat = null)
        {
            Form form = formName switch
            {
                "EmployeeIdentityForm" => new EmployeeIdentityForm(employeeNat),
                "ChangePasswordForm" => new ChangePasswordForm(),
                "LoginForm" => new LoginForm(),
                _ => throw new ArgumentException("Invalid form name.",
                nameof(formName)),
            };
            form.Show();
        }


        
    }
}
