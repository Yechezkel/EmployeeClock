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
    public partial class ClockForm : Form    
    {
        DBContext _dbContext;
        bool isEmployeeIn;
        string employeeID = "";

        public ClockForm(DataTable dataTable1)
        {
            
            InitializeComponent();
            _dbContext = new DBContext();

            employeeID = dataTable1.Rows[0]["EmployeeID"].ToString();

            SqlParameter[] sp2 = { new SqlParameter("@employeeID", employeeID) };
            DataTable dataTable2 = _dbContext.MakeQueryDT("select top(2) * from Attendance where EmployeeID = @employeeID order by EntryTime desc;", sp2);
            
            tz_label.Text += dataTable1.Rows[0]["EmployeeTZ"].ToString() + "";

            
            if (dataTable2.Rows.Count == 0)
            {
                lastEntry_label.Text += " --------";
                lastExit_label.Text += " --------";
                isEmployeeIn = false;
            }
            
            else
            {
                if (dataTable2.Rows[0]["ExitTime"].ToString() == "")
                {
                    isEmployeeIn = true;
                    if (dataTable2.Rows.Count == 2)
                    {
                        lastEntry_label.Text += dataTable2.Rows[0]["EntryTime"].ToString();
                        lastExit_label.Text += dataTable2.Rows[1]["ExitTime"].ToString();
                    }
                    else
                    {
                        lastEntry_label.Text += dataTable2.Rows[0]["EntryTime"].ToString();
                        lastExit_label.Text += " --------  ";
                    }
                }
                else
                {
                    
                    isEmployeeIn = false;
                    lastEntry_label.Text += dataTable2.Rows[0]["EntryTime"].ToString();
                    lastExit_label.Text += dataTable2.Rows[0]["ExitTime"].ToString();
                }
                
                
            }
        }

        private void OnCancelClicked(object sender, EventArgs e)
        {
            Navigations.MoveToLoginForm();
        }

        private void OnEntryClicked(object sender, EventArgs e)
        {
            if (isEmployeeIn==false)
            {
                SqlParameter[] sp = { new SqlParameter("@employeeID", employeeID) };
                DataTable dataTable = _dbContext.MakeQueryDT("insert into Attendance(EmployeeID, EntryTime) values (@employeeID, getdate()); ", sp);
                MessageBox.Show("כניסה עודכנה");
                Navigations.MoveToLoginForm();
            }
            
        }

        
        private void OnExitClicked(object sender, EventArgs e)
        {
            if (isEmployeeIn == true)
            {
                SqlParameter[] sp = { new SqlParameter("@employeeID", employeeID) };
                DataTable dataTable = _dbContext.MakeQueryDT("UPDATE Attendance SET ExitTime = GeTdate() where EmployeeID = @employeeID; ", sp);
                MessageBox.Show("יציאה עודכנה");
                Navigations.MoveToLoginForm();
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
