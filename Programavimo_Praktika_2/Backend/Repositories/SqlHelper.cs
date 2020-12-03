using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows;
using System.Data;
using System.Threading;
using Programavimo_Praktika_2.Backend.Models;

namespace Programavimo_Praktika_2.Backend.Repositories
{
    class SqlHelper
    {
        private static string sqlconnectionstring = @"Data Source=DESKTOP-8SF0T6G;Initial Catalog=Praktika2;Integrated Security=True";

        public static bool connectToSql()
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            try
            {
                con.Open();
                MessageBox.Show("Connection Succeeded");
                con.Close();
                return true;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Connection Failed" + e);
                return false;
            }
        }

        public static bool LoginwithSql(string Username, string Password)
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            string SqlCommand = string.Empty;
            SqlCommand += "SELECT * FROM UserTable ";
            SqlCommand += "Where username = '" + Username + "'";
            SqlCommand += "AND password = '" + Password + "'";
            SqlDataAdapter da = new SqlDataAdapter(SqlCommand, con);
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                if (dt.Rows.Count == 1)
                {

                    // return true;
                    // MessageBox.Show("+1!!!!!!!!!asdasd");
                    return true;
                }
                else
                {
                    con.Close();
                    MessageBox.Show("Bad Credentials");
                    return false;
                }


            }
            catch (SqlException e)
            {
                MessageBox.Show("+1!!!!!!!!!" + e);
                return false;

            }
        }
        public static bool InsertDataForSql(string Name, string surname, string username, string password, string email , string role)
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            string query = string.Empty;
            query += "INSERT INTO UserTable(name,surname,username,password,email,role) ";
            query += "VALUES ('" + Name + "','" + surname + "','" + username + "','" + password + "',";
            query += "'" + email + "','" + role + "')";
            try
            {
                con.Open();
                //SqlDataAdapter da = new SqlDataAdapter(query, con);
                SqlCommand da = new SqlCommand(query, con);
                da.ExecuteScalar();

                con.Close();
                // MessageBox.Show("!!!!!!!!!");
                return true;
            }
            catch (SqlException e)
            {
                con.Close();
                MessageBox.Show("Toks vartotojas jau egzistuoja" + e);
                return false;
            }
        }
       
        public static bool InsertDataForSqlGroup(string GroupName)
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            string query = string.Empty;
            query += "INSERT INTO Groups(GroupName) ";
            query += "VALUES ('" + GroupName + "')";
            //query += ", '0')";
            try
            {
                con.Open();
                //SqlDataAdapter da = new SqlDataAdapter(query, con);
                SqlCommand da = new SqlCommand(query, con);
                da.ExecuteScalar();

                con.Close();
                // MessageBox.Show("!!!!!!!!!");
                return true;
            }
            catch (SqlException e)
            {
                con.Close();
                MessageBox.Show("Toks vartotojas jau egzistuoja" + e);
                return false;
            }
        }
        public static bool InsertDataForSqlMarks(int lectureid ,int userid , int mark)
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            string query = string.Empty;
            query += "INSERT INTO MarksTable(LectureID,UserID,Mark) ";
            query += "VALUES ('" + lectureid + "','" + userid + "','" + mark + "')";
            //query += ", '0')";
            try
            {
                con.Open();
                //SqlDataAdapter da = new SqlDataAdapter(query, con);
                SqlCommand da = new SqlCommand(query, con);
                da.ExecuteScalar();

                con.Close();
                // MessageBox.Show("!!!!!!!!!");
                return true;
            }
            catch (SqlException e)
            {
                con.Close();
                MessageBox.Show("Toks vartotojas jau egzistuoja" + e);
                return false;
            }
        }
        public static bool InsertDataForSqlLecture(string name, string description)
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            string query = string.Empty;
            query += "INSERT INTO LectureTable(Name, Description) ";
            query += "VALUES ('" + name + "','" + description + "')";
            //query += ", '0')";
            try
            {
                con.Open();
                //SqlDataAdapter da = new SqlDataAdapter(query, con);
                SqlCommand da = new SqlCommand(query, con);
                da.ExecuteScalar();

                con.Close();
                // MessageBox.Show("!!!!!!!!!");
                return true;
            }
            catch (SqlException e)
            {
                con.Close();
                MessageBox.Show("Toks vartotojas jau egzistuoja" + e);
                return false;
            }
        }

        public static bool InsertDataFromSql(string Username, ref DataTable dat)
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            string SqlCommand = string.Empty;
            SqlCommand += "SELECT * FROM UserTable ";
            SqlCommand += "Where username = '" + Username + "'";
            SqlDataAdapter da = new SqlDataAdapter(SqlCommand, con);
            try
            {
                con.Open();
                //DataTable dt = new DataTable();
                da.Fill(dat);
                con.Close();
                if (dat.Rows.Count == 1)
                {

                    return true;
                }
                else
                {
                    con.Close();
                    return false;
                }

            }
            catch (SqlException e)
            {
                return false;
            }

        }
        public static bool InsertDataFromSql(int id, ref DataTable dat)
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            string SqlCommand = string.Empty;
            SqlCommand += "SELECT * FROM UserTable ";
            SqlCommand += "Where ID = '" + id + "'";
            SqlDataAdapter da = new SqlDataAdapter(SqlCommand, con);
            try
            {
                con.Open();
                //DataTable dt = new DataTable();
                da.Fill(dat);
                con.Close();
                if (dat.Rows.Count == 1)
                {

                    return true;
                }
                else
                {
                    con.Close();
                    return false;
                }

            }
            catch (SqlException e)
            {
                return false;
            }

        }
        public static bool InsertDataForSqlLecturedBy(int lectureid, int userid)
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            string query = string.Empty;
            query += "INSERT INTO LecturedBy(LectureID,UserID) ";
            query += "VALUES ('" + lectureid + "','" + userid + "')";
            try
            {
                con.Open();
                //SqlDataAdapter da = new SqlDataAdapter(query, con);
                SqlCommand da = new SqlCommand(query, con);
                da.ExecuteScalar();

                con.Close();
                // MessageBox.Show("!!!!!!!!!");
                return true;
            }
            catch (SqlException e)
            {
                con.Close();
                MessageBox.Show("Toks vartotojas jau egzistuoja" + e);
                return false;
            }
        }
        public static bool InsertDataForSqlGroupLectures(int lectureid ,int groupid)
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            string query = string.Empty;
            query += "INSERT INTO GroupLectures(LectureID,GroupID) ";
            query += "VALUES ('" + lectureid + "','" + groupid + "')";
            try
            {
                con.Open();
                //SqlDataAdapter da = new SqlDataAdapter(query, con);
                SqlCommand da = new SqlCommand(query, con);
                da.ExecuteScalar();

                con.Close();
                // MessageBox.Show("!!!!!!!!!");
                return true;
            }
            catch (SqlException e)
            {
                con.Close();
                MessageBox.Show("Toks vartotojas jau egzistuoja" + e);
                return false;
            }
        }
        public static bool InsertDataForSqlAssignGroups(int groupid, int userid)
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            string query = string.Empty;
            query += "UPDATE UserTable";
            query += " SET groupid ='"+ groupid +"'";
            query += "WHERE id = '" + userid + "'";
            try
            {
                con.Open();
                //SqlDataAdapter da = new SqlDataAdapter(query, con);
                SqlCommand da = new SqlCommand(query, con);
                da.ExecuteScalar();

                con.Close();
                // MessageBox.Show("!!!!!!!!!");
                return true;
            }
            catch (SqlException e)
            {
                con.Close();
                MessageBox.Show("Toks vartotojas jau egzistuoja" + e);
                return false;
            }
        }
        public static bool InsertDataForSqlMarkChange(int mark, int id)
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            string query = string.Empty;
            query += "UPDATE MarksTable";
            query += " SET Mark ='" + mark + "'";
            query += "WHERE id = '" + id + "'";
            try
            {
                con.Open();
                //SqlDataAdapter da = new SqlDataAdapter(query, con);
                SqlCommand da = new SqlCommand(query, con);
                da.ExecuteScalar();

                con.Close();
                // MessageBox.Show("!!!!!!!!!");
                return true;
            }
            catch (SqlException e)
            {
                con.Close();
                MessageBox.Show("Toks vartotojas jau egzistuoja" + e);
                return false;
            }
        }
        public static string InsertDataFromUserForLecturesBy(int ID)
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            string kazkas = string.Empty;
            kazkas+= "SELECT surname FROM UserTable ";
            kazkas += "Where id = '" + ID + "'";
            SqlCommand da = new SqlCommand(kazkas, con);
            try
            {
                /*SqlDataReader sql = da.ExecuteReader();*/
                con.Open();
                SqlDataReader sql = da.ExecuteReader();
                if (sql.Read())
                {
                    //con.Close();
                    string surname =sql["surname"].ToString();
                    con.Close();
                    return surname;
                }
                //DataTable dt = new DataTable();
                // da.Fill(dat);
              /*  con.Close();
                if (dat.Rows.Count == 1)
                {

                    return true;
                }*/
                else
                {
                    con.Close();
                    return "::::::::::::::";
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show ("kazkas" +e);
                return null;
            }

        }
        public static string InsertDataFromUserForLecturesByLectureID(int ID)
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            string kazkas = string.Empty;
            kazkas += "SELECT name FROM LectureTable ";
            kazkas += "Where id = '" + ID + "'";
            SqlCommand da = new SqlCommand(kazkas, con);
            try
            {
                /*SqlDataReader sql = da.ExecuteReader();*/
                con.Open();
                SqlDataReader sql = da.ExecuteReader();
                if (sql.Read())
                {
                    //con.Close();
                    string name = sql["name"].ToString();
                    con.Close();
                    return name;
                }
                //DataTable dt = new DataTable();
                // da.Fill(dat);
                /*  con.Close();
                  if (dat.Rows.Count == 1)
                  {

                      return true;
                  }*/
                else
                {
                    con.Close();
                    return "::::::::::::::";
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("kazkas2" + e);
                return null;
            }

        }
        public static void FillTable(ref DataTable dat)
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            string query = string.Empty;
            query += "SELECT * FROM UserTable Where Permissions = 'User'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            try
            {
                con.Open();
                da.Fill(dat);
                con.Close();
                return;
            }
            catch (SqlException e)
            {
                return;
            }
        }

        public static void DeleteUser(string ID)
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            string query = string.Empty;
            query += "DELETE FROM UserTable ";
            query += "WHERE ID = '" + ID + "'";
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteScalar();
                con.Close();
                return;
            }
            catch (SqlException e)
            {
                return;
            }
        }
        public static void DeleteGroup(string ID)
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            string query = string.Empty;
            query += "DELETE FROM Groups ";
            query += "WHERE ID = '" + ID + "'";
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteScalar();
                con.Close();
                return;
            }
            catch (SqlException e)
            {
                return;
            }
        }       
        public static void DeleteLecture(string ID)
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            string query = string.Empty;
            query += "DELETE FROM LectureTable ";
            query += "WHERE ID = '" + ID + "'";
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteScalar();
                con.Close();
                return;
            }
            catch (SqlException e)
            {
                return;
            }
        }
      

        public static void DeleteGroup(string ID, string itemId)
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            string query = string.Empty;
            query += "DELETE FROM wishlist ";
            query += "WHERE UserID = '" + ID + "' AND itemID = '" + itemId + "'";
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteScalar();
                con.Close();
                return;
            }
            catch (SqlException e)
            {
                MessageBox.Show("ZOPA " + e);
                return;
            }
        }
        public static void DeleteComment(string ID)
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            string query = string.Empty;
            query += "DELETE FROM comment ";
            query += "WHERE ID = '" + ID + "'";
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteScalar();
                con.Close();
                return;
            }
            catch (SqlException e)
            {
                MessageBox.Show("ZOPA " + e);
                return;
            }
        }

        public static void ChangeUserPass(string ID, string NPassword)
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            string query = string.Empty;
            query += "UPDATE Useris ";
            query += "SET Password = '" + NPassword + "'";
            query += "Where ID = '" + ID + "'";
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteScalar();
                con.Close();
                return;
            }
            catch (SqlException e)
            {
                return;
            }
        }
        
        public List<Groups> GetGroups()
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            List<Groups> groupsList = new List<Groups>();
            try
            {
                string sql = "select ID, GroupName from Groups";
                SqlCommand cmd = new SqlCommand(sql, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["ID"].ToString());
                    string title = reader["GroupName"].ToString();
                    groupsList.Add(new Groups(id, title));
                }

                con.Close();
            }
            catch (SqlException exc)
            {
                MessageBox.Show("Sql Error:" + exc);
            }         

            return groupsList;
        }
        public List<GroupLectures> GetGroupLecturesLecturer(int lectureid)
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            List<GroupLectures> groupsList = new List<GroupLectures>();
            try
            {
                string sql = "select ID, LectureID, GroupID from GroupLectures WHERE LectureID = '" + lectureid + "'";
                SqlCommand cmd = new SqlCommand(sql, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["ID"].ToString());
                    int title = int.Parse(reader["LectureID"].ToString());
                    int groupid = int.Parse(reader["GroupID"].ToString());
                    groupsList.Add(new GroupLectures(id, title,groupid));
                }

                con.Close();
            }
            catch (SqlException exc)
            {
                MessageBox.Show("Sql Error:" + exc);
            }

            return groupsList;
        }
        public List<GroupLectures> GetGroupLecturesStudent(int groupId)
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            List<GroupLectures> groupsList = new List<GroupLectures>();
            try
            {
                string sql = "select ID, LectureID, GroupID from GroupLectures WHERE GroupID = '" + groupId + "'";
                SqlCommand cmd = new SqlCommand(sql, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["ID"].ToString());
                    int title = int.Parse(reader["LectureID"].ToString());
                    int groupid = int.Parse(reader["GroupID"].ToString());
                    groupsList.Add(new GroupLectures(id, title, groupid));
                }

                con.Close();
            }
            catch (SqlException exc)
            {
                MessageBox.Show("Sql Error:" + exc);
            }

            return groupsList;
        }
        public Groups GetGroupsLecturer(int id)
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            Groups groupslect = new Groups();
            try
            {
                string sql = "select ID, GroupName from Groups WHERE ID = '" + id + "'";
                SqlCommand cmd = new SqlCommand(sql, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    groupslect.Id= int.Parse(reader["ID"].ToString());
                    groupslect.GroupName = reader["GroupName"].ToString();
                   // groupsList.Add(new Groups(id, title));
                }

                con.Close();
            }
            catch (SqlException exc)
            {
                MessageBox.Show("Sql Error:" + exc);
            }

            return groupslect;
        }
        public List<LecturedBy> GetLecturedBy()
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            List<LecturedBy> lecturedbyList = new List<LecturedBy>();
            try
            {
                string sql = "select ID, LectureID, UserID from LecturedBy";
                SqlCommand cmd = new SqlCommand(sql, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["ID"].ToString());
                    int lectureid = int.Parse(reader["LectureID"].ToString());
                    int userid = int.Parse(reader["UserID"].ToString());

                    lecturedbyList.Add(new LecturedBy(id,lectureid,userid));
                }

                con.Close();
            }
            catch (SqlException exc)
            {
                MessageBox.Show("Sql Error:" + exc);
            }

            return lecturedbyList;
        }
        public List<LecturedBy> GetLecturedByLecturer(int lecturerid)
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            List<LecturedBy> lecturedbyList = new List<LecturedBy>();
            try
            {
                string sql = "select ID, LectureID, UserID from LecturedBy WHERE UserID ='" + lecturerid + "'";
                SqlCommand cmd = new SqlCommand(sql, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["ID"].ToString());
                    int lectureid = int.Parse(reader["LectureID"].ToString());
                    int userid = int.Parse(reader["UserID"].ToString());

                    lecturedbyList.Add(new LecturedBy(id, lectureid, userid));
                }

                con.Close();
            }
            catch (SqlException exc)
            {
                MessageBox.Show("Sql Error:+++++++++++++++++++++" + exc);
            }

            return lecturedbyList;
        }
        public List<Lectures> GetLectures()
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            List<Lectures> lecturesList = new List<Lectures>();
            try
            {
                string sql = "select ID, Name, Description from LectureTable";
                SqlCommand cmd = new SqlCommand(sql, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["ID"].ToString());
                    string name = reader["Name"].ToString();
                    string description = reader["Description"].ToString();
                    lecturesList.Add(new Lectures(id, name, description));
                }

                con.Close();
            }
            catch (SqlException exc)
            {
                MessageBox.Show("Sql Error:" + exc);
            }

            return lecturesList;
        }
        public List<Marks> GetMarksLecturer(int lectureId, int userId)
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            List<Marks> marksList = new List<Marks>();
            try
            {
                string sql = "select ID, LectureID, UserID, Mark from MarksTable WHERE LectureID = '";
                sql += +lectureId + "' AND UserID = '" + userId + "'";
                SqlCommand cmd = new SqlCommand(sql, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["ID"].ToString());
                    int lectureid = int.Parse(reader["LectureID"].ToString());
                    int userid = int.Parse(reader["UserID"].ToString());
                    int mark = int.Parse(reader["Mark"].ToString());
                    marksList.Add(new Marks(id, lectureid,userid,mark));
                }

                con.Close();
            }
            catch (SqlException exc)
            {
                MessageBox.Show("Sql Error:" + exc);
            }

            return marksList;
        }
        public Lectures GetLecturesLecturer(int id)
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            Lectures lecturesList = new Lectures();
            try
            {
                string sql = "select ID, Name, Description from LectureTable WHERE  ID ='" + id + "'";
                SqlCommand cmd = new SqlCommand(sql, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lecturesList.Id = int.Parse(reader["ID"].ToString());
                    lecturesList.LectureName = reader["Name"].ToString();
                    lecturesList.Description = reader["Description"].ToString();
                    //lecturesList.Add(new Lectures(id, name, description));
                }

                con.Close();
            }
            catch (SqlException exc)
            {
                MessageBox.Show("Sql Error:" + exc);
            }

            return lecturesList;
        }
        public List<UserInfo> GetUserInfo()
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            List<UserInfo> userList = new List<UserInfo>();
            try
            {
                string sql = "select id, name, surname, username," +
                    " password, groupid, email, role from UserTable";
                SqlCommand cmd = new SqlCommand(sql, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    string name = reader["name"].ToString();
                    string surname = reader["surname"].ToString();
                    string username = reader["username"].ToString();
                    string password = reader["password"].ToString();
                    string groupid = reader["groupid"].ToString();
                    string email = reader["email"].ToString();
                    string role = reader["role"].ToString();
                    userList.Add(new UserInfo(id, name, surname,username,password,groupid,email,role));
                }

                con.Close();
            }
            catch (SqlException exc)
            {
                MessageBox.Show("Sql Error:" + exc);
            }

            return userList;
        }
        public List<UserInfo> GetUserInfoLecturer(int groupId)
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            List<UserInfo> userList = new List<UserInfo>();
            try
            {
                string sql = "select id, name, surname, username," +
                    " password, groupid, email, role from UserTable WHERE groupid = '" + groupId + "'";
                SqlCommand cmd = new SqlCommand(sql, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    string name = reader["name"].ToString();
                    string surname = reader["surname"].ToString();
                    string username = reader["username"].ToString();
                    string password = reader["password"].ToString();
                    string groupid = reader["groupid"].ToString();
                    string email = reader["email"].ToString();
                    string role = reader["role"].ToString();
                    userList.Add(new UserInfo(id, name, surname, username, password, groupid, email, role));
                }

                con.Close();
            }
            catch (SqlException exc)
            {
                MessageBox.Show("Sql Error:" + exc);
            }

            return userList;
        }

        
    }
}
