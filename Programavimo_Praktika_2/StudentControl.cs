using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programavimo_Praktika_2.Backend.Models;
using Programavimo_Praktika_2.Backend.Repositories;

namespace Programavimo_Praktika_2
{
    public partial class StudentControl : UserControl
    {
        public StudentControl()
        {
            InitializeComponent();
            DataTable currentuser = new DataTable();
            SqlHelper sql = new SqlHelper();            
            SqlHelper.InsertDataFromSql(LogedInScreen.ID, ref currentuser);
            int groupid = int.Parse(currentuser.Rows[0][5].ToString());    
          
            List<GroupLectures> groupLectures = new List<GroupLectures>();
            groupLectures = sql.GetGroupLecturesStudent(groupid);
            foreach (GroupLectures c in groupLectures)
            {
                
                Lectures lecture = new Lectures();

                lecture = sql.GetLecturesLecturer(c.LectureID);
                Button lecturebutt = new Button();
                lecturebutt.Text = lecture.LectureName;
                lecturebutt.Width = LecturesflowLayoutPanel1.Width - 5;
                lecturebutt.Tag = lecture;
                LecturesflowLayoutPanel1.Controls.Add(lecturebutt);
                lecturebutt.Click += Lecturebutt_Click;
                
               
                
                
                
            }

        }

        private void Lecturebutt_Click(object sender, EventArgs e)
        {
            MarksflowLayoutPanel2.Controls.Clear();
            Button button = (Button)sender;
            Lectures lectures = (Lectures)button.Tag;
            List<Marks> marks = new List<Marks>();
            SqlHelper sql = new SqlHelper();
            marks = sql.GetMarksLecturer(lectures.Id, LogedInScreen.ID);
            foreach (Marks c in marks)
            {
                Button markbutton = new Button();
                markbutton.Text = $"{c.Mark}";
                markbutton.Width = MarksflowLayoutPanel2.Width - 5;
                MarksflowLayoutPanel2.Controls.Add(markbutton);                
                //userbutton.Click += Userbutton_Click;
            }
            //throw new NotImplementedException();
        }
    }
}
