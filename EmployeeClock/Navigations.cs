using EmployeeClock;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClock
{
    
    internal class Navigations
    {
        public static bool isNavigate = false;
        private static void CloseAllForms()
        {
            foreach (Form item in new List<Form>(Application.OpenForms.Cast<Form>()))
                item.Close();
        }

        public static void MoveToLoginForm()
        {
            isNavigate = true;
            CloseAllForms();
            Form form = new LoginForm();
            form.Show();
            isNavigate = false;
        }

        public static void MoveToChangePasswordForm(string tz)
        {
            isNavigate = true;
            CloseAllForms();
            Form form = new ChangePasswordForm(tz);
            form.Show();
            isNavigate = false;
        }

        public static void MoveToClockForm(DataTable dataTable)
        {
            isNavigate = true;
            CloseAllForms();
            Form form = new ClockForm(dataTable);
            form.Show();
            isNavigate = false;
        }


    }
}





