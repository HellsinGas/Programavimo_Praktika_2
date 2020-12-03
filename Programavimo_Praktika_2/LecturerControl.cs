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
using Programavimo_Praktika_2.Backend.Models;
using Microsoft.VisualBasic;

namespace Programavimo_Praktika_2
{
    public partial class LecturerControl : UserControl
    {
        public LecturerControl()
        {
            InitializeComponent();
           // Button lecturebutton = new Button();
            // veikia// LogedInScreen.ID
            List<LecturedBy> pask = new List<LecturedBy>();
            SqlHelper sql = new SqlHelper();
            pask = sql.GetLecturedByLecturer(LogedInScreen.ID);
            foreach (LecturedBy c in pask) {
                Lectures lecture = new Lectures();
                lecture = sql.GetLecturesLecturer(c.LectureId);
                Button lecturebutton = new Button();
                lecturebutton.Text = lecture.LectureName;
                lecturebutton.Width = LecturesLayoutPanel1.Width - 5;
                LecturesLayoutPanel1.Controls.Add(lecturebutton);
                lecturebutton.Tag = lecture;
                lecturebutton.Click += Lecturebutton_Click;


            }

        }

        private void Lecturebutton_Click(object sender, EventArgs e)
        {
            GroupsLayoutPanel2.Controls.Clear();
            MarksLayoutPanel4.Controls.Clear();
            StudentsLayoutPanel3.Controls.Clear();
            Button button = (Button)sender;
            SqlHelper sql = new SqlHelper();
            Lectures lectures = (Lectures)button.Tag;
            List<GroupLectures> groupLectures = new List<GroupLectures>();
            groupLectures = sql.GetGroupLecturesLecturer(lectures.Id);
            foreach(GroupLectures c in groupLectures)
            {
               //SqlHelper sql = new SqlHelper();
                Groups groups = new Groups();
                groups = sql.GetGroupsLecturer(c.GroupID);
                Button groupbuton = new Button();
                groupbuton.Text = groups.GroupName;
                groupbuton.Width = GroupsLayoutPanel2.Width - 5;
                ExTag exTag = new ExTag();
                exTag.Add("Lecture", lectures);
                //groupbuton.Tag = c;
                exTag.Add("Group", groups);
                groupbuton.Tag = exTag;
                GroupsLayoutPanel2.Controls.Add(groupbuton);
                groupbuton.Click += Groupbuton_Click;
            }
          //  throw new NotImplementedException();
        }

        private void Groupbuton_Click(object sender, EventArgs e)
        {
            StudentsLayoutPanel3.Controls.Clear();
            MarksLayoutPanel4.Controls.Clear();
            Button button = (Button)sender;
            ExTag ex = (ExTag)button.Tag;
            Lectures lectures = (Lectures)(ex.Get("Lecture"));
            Groups groups = (Groups)(ex.Get("Group"));
            SqlHelper sql = new SqlHelper();
            List<UserInfo> userInfos = new List<UserInfo>();
            userInfos = sql.GetUserInfoLecturer(groups.Id);
            foreach(UserInfo c in userInfos)
            {               
                
                Button userbutton = new Button();
                userbutton.Text = $"{c.Name} {c.Surname}";
                userbutton.Width = StudentsLayoutPanel3.Width - 5;
                ExTag exTag = new ExTag();
                exTag.Add("Lecture", lectures);                
                exTag.Add("User", c);
                StudentsLayoutPanel3.Controls.Add(userbutton);
                userbutton.Tag = exTag;
                userbutton.Click += Userbutton_Click;
                
              //  groupbuton.Click += Groupbuton_Click;

            }
            MessageBox.Show($"pamoka={lectures.LectureName} grupe= {groups.GroupName} ");

            //throw new NotImplementedException();
        }

        private void Userbutton_Click(object sender, EventArgs e)
        {
            MarksLayoutPanel4.Controls.Clear();
            Button button = (Button)sender;
            ExTag ex = (ExTag)button.Tag;
            Lectures lectures = (Lectures)(ex.Get("Lecture"));
            UserInfo user = (UserInfo)(ex.Get("User"));
            Button addmark = new Button();
            addmark.Tag = ex;
            addmark.Width = MarksLayoutPanel4.Width - 5;
            addmark.Text = "Add new mark";
            MarksLayoutPanel4.Controls.Add(addmark);
          //  MarksLayoutPanel4.SetFlowBreak(addmark, true);
            Label separation = new Label();
            separation.Text = "Student Marks : Click to change it";
            MarksLayoutPanel4.SetFlowBreak(separation, true);            
            addmark.Click += Addmark_Click;
            List<Marks> marks = new List<Marks>();
            SqlHelper sql = new SqlHelper();
            marks = sql.GetMarksLecturer(lectures.Id, user.Id);
            foreach(Marks c in marks)
            {
                Button markbutton = new Button();
                markbutton.Text = $"{c.Mark}";
                markbutton.Width = MarksLayoutPanel4.Width - 5;
                ExTag exTag = new ExTag();
                exTag.Add("Lecture", lectures);
                exTag.Add("User", c);
                MarksLayoutPanel4.Controls.Add(markbutton);
                markbutton.Tag = c;
                markbutton.Click += Markbutton_Click;
                //userbutton.Click += Userbutton_Click;
            }


            //throw new NotImplementedException();
        }

        private void Markbutton_Click(object sender, EventArgs e)
        {
            MarksLayoutPanel4.Controls.Clear();
            Button button = (Button)sender;
            Marks mark = (Marks)button.Tag;
            string content = Interaction.InputBox("Mark", $" Current mark :{mark.Mark}", "Input new mark here", 500, 300);
            if (content != "")
            {
                SqlHelper.InsertDataForSqlMarkChange(int.Parse(content), mark.Id);
               // SqlHelper.InsertDataForSqlMarks(lectures.Id, user.Id, int.Parse(content));

            }


        }

        private void Addmark_Click(object sender, EventArgs e)
        {
           // MarksLayoutPanel4.Controls.Clear();
            Button button = (Button)sender;
            ExTag ex = (ExTag)button.Tag;
            Lectures lectures = (Lectures)(ex.Get("Lecture"));
            UserInfo user = (UserInfo)(ex.Get("User"));
            string content = Interaction.InputBox("Mark", "Mark input Box", "Input new mark here", 500,300);
            if (content != "")
            {   
                
                SqlHelper.InsertDataForSqlMarks(lectures.Id, user.Id, int.Parse(content));

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
