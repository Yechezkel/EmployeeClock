using EmployeeClock;
using EmployeeClock.DAL;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace EmployeeClock
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            new LoginForm().Show();
            Application.Run();          
        }
    }
}
