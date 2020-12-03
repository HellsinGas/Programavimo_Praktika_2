using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programavimo_Praktika_2.Backend.Repositories;


namespace Programavimo_Praktika_2
{
    //DataTable currentuser = new DataTable();
    //public static string UserID;
   // public static int ID;
   // public static bool status;
   // public static bool loginas;
    public partial class LogedInScreen : Form
    {
        DataTable currentuser = new DataTable();
       // public static string UserID;
        public static int ID;
        public LogedInScreen(string username, string password)
        {
            InitializeComponent();
            SqlHelper.InsertDataFromSql(username, ref currentuser);           
            namelabel.Text = currentuser.Rows[0][1].ToString();
            ID = (int)currentuser.Rows[0][0];
            usernamelabel.Text = currentuser.Rows[0][3].ToString();
            surnamelabel.Text = currentuser.Rows[0][2].ToString();
            rolelabel.Text = currentuser.Rows[0][7].ToString();
           if(currentuser.Rows[0][7].ToString() == "admin")
            {
                AdminControl adminas = new AdminControl();
                flowLayoutPanel1.Controls.Add(adminas);
            }
            if (currentuser.Rows[0][7].ToString() == "lecturer")
            {
                // lectdminas = new AdminControl();
                LecturerControl lecturer = new LecturerControl();
                flowLayoutPanel1.Controls.Add(lecturer);
            }
            if (currentuser.Rows[0][7].ToString() == "student")
            {
                // lectdminas = new AdminControl();
                StudentControl student = new StudentControl();
                flowLayoutPanel1.Controls.Add(student);
            }
            

        }
    }
}
