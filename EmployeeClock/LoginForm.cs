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
using static System.Windows.Forms.DataFormats;


namespace EmployeeClock
{
    public partial class LoginForm : Form

    {
        DBContext _dbContext;


        public LoginForm()
        {
            InitializeComponent();
            _dbContext = new DBContext();
        }
        
        public void OnForgotPasswordClicked(object sender , EventArgs e)
        {
            string tz = tz_textBox.Text;
            Navigations.MoveToChangePasswordForm(tz);
        }

        public void OnEnterClicked(object sender, EventArgs e)
        {
            string tz = tz_textBox.Text;
            string password = password_textBox.Text;
            if (tz == "" || password == "")
            {
                MessageBox.Show("אנא מלא את כל השדות");
                return;
            }
            SqlParameter[] sp = { new SqlParameter("@tz", tz) , new SqlParameter("@password", password) };
            DataTable dataTable = _dbContext.MakeQueryDT("select * from Employee where EmployeeTZ = @tz and EmployeePassword = @Password;", sp);
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("מספר תעודת זהות או סיסמה שגויים");
                return;
            }
            if (dataTable.Rows.Count == 1)
            {
                Navigations.MoveToClockForm(dataTable);
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




















