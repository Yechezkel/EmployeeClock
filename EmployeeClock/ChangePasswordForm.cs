using EmployeeClock.DAL;
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
    public partial class ChangePasswordForm : Form
    {
        DBContext _dbContext;

        public ChangePasswordForm(string tz)
        {
             
            InitializeComponent();
            _dbContext = new DBContext();
            tz_textBox.Text = tz;
        }

        private void OnCancelClicked(object sender, EventArgs e)
        {
            Navigations.MoveToLoginForm();
        }

        private void OnChangePassowrdClicked(object sender, EventArgs e)
        {

            string tz = tz_textBox.Text;
            string oldPassword = oldPassword_textBox.Text;
            string newPassword = newPassword_textBox.Text;
            string confirmPassword = confirmPassword_textBox.Text;

            if (tz == "" || oldPassword == "" || newPassword == "" || confirmPassword == "")
            {
                MessageBox.Show("אנא מלא את כל השדות");
                return;
            }
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("הסיסמאות  אינן זהות");
                return;
            }
            SqlParameter[] sp1 = { new SqlParameter("@tz", tz), new SqlParameter("@oldPassword", oldPassword) };
            DataTable dataTable = _dbContext.MakeQueryDT("select * from Employee where EmployeeTZ = @tz and EmployeePassword = @oldPassword;", sp1);
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("מספר תעודת זהות או סיסמה שגויים");
                return;
            }
            if (dataTable.Rows.Count == 1)
            {
                SqlParameter[] sp2 = { new SqlParameter("@tz", tz), new SqlParameter("@newPassword", newPassword) };
                dataTable = _dbContext.MakeQueryDT("UPDATE Employee SET EmployeePassword = @newPassword where EmployeeTZ = @tz;", sp2);
                MessageBox.Show("הסיסמה שונתה בהצלחה");//איך לבדוק אם זה באמת קרה
                Navigations.MoveToLoginForm();
            }
            else
            {
                MessageBox.Show("שגיאה עקב כפילות של תעודות זהות");
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (!Navigations.isNavigate)
            {
                Application.Exit();
            }
        }
    }
}
    