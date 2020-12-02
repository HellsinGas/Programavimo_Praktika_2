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
       /* public static bool InsertDataForSqlWishlist(int UserId, int itemId)
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            string query = string.Empty;
            query += "INSERT INTO wishlist(UserID,itemID) ";
            query += "VALUES ('" + UserId + "','" + itemId + "')";
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
        }*/
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
        public static bool InsertDataForSqlGroupLectures(int lectureid, int groupid)
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
        /*public static bool InsertDataFromSql(string Username, ref DataTable dat)
        {
            SqlConnection con = new SqlConnection(sqlconnectionstring);
            string SqlCommand = string.Empty;
            SqlCommand += "SELECT * FROM Useris ";
            SqlCommand += "Where Username = '" + Username + "'";
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

        }*/

        /*public static void FillTable(ref DataTable dat)
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
        }*/

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
        /* public List<Item> GetItems()
         {
             List<Item> itemsList = new List<Item>();
             try
             {
                 string sql = "select id, title, price, description, image from items";
                 SqlCommand cmd = new SqlCommand(sql, conn);

                 conn.Open();
                 SqlDataReader reader = cmd.ExecuteReader();

                 while (reader.Read())
                 {
                     int id = int.Parse(reader["id"].ToString());
                     string title = reader["title"].ToString();
                     double price = double.Parse(reader["price"].ToString());
                     string description = reader["description"].ToString();
                     string image = reader["image"].ToString();
                     itemsList.Add(new Item(id, title, description, image, price));
                 }

                 conn.Close();
             }
             catch (Exception exc)
             {
                 Debug.WriteLine(exc.Message);
             }

             return itemsList;
         }*/
        /*   public Item GetItemsWishlist(int ID)
           {
              //Item itemsList= new Item();
               try
               {
                   string sql = "select ID, title, price, description, image from items where ID=@ID";
                   SqlCommand cmd = new SqlCommand(sql, conn);
                   cmd.Parameters.AddWithValue("@ID", ID);

                   conn.Open();
                   SqlDataReader reader = cmd.ExecuteReader();

                   while (reader.Read())
                   {
                       int id = int.Parse(reader["id"].ToString());
                       string title = reader["title"].ToString();
                       double price = double.Parse(reader["price"].ToString());
                       string description = reader["description"].ToString();
                       string image = reader["image"].ToString();
                       Item itemList= new Item(id, title, description, image, (double)price);
                   //return itemsList;
                   //  itemList.add
                    }

                   conn.Close();
                   return itemsList;
               }
               catch (SqlException e)
               {
                   MessageBox.Show("bybys gavos" +e);
                  // Debug.WriteLine(exc.Message);
                  // throw;
                   //return ;
               }

               // return NULL;
               return itemsList;
           }*/

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

        /* private List<Item> GetItems(int categoryId)
         {
             List<Item> itemsList = new List<Item>();
             try
             {
                 string sql = "select id, title, price, description, image from items " +
                         "where categoryId=@categoryId";
                 SqlCommand cmd = new SqlCommand(sql, conn);
                 cmd.Parameters.AddWithValue("@categoryId", categoryId);

                 conn.Open();
                 SqlDataReader reader = cmd.ExecuteReader();

                 while (reader.Read())
                 {
                     int id = int.Parse(reader["id"].ToString());
                     string title = reader["title"].ToString();
                     double price = double.Parse(reader["price"].ToString());
                     string description = reader["description"].ToString();
                     string image = reader["image"].ToString();
                     itemsList.Add(new Item(id, title, description, image, price));
                 }

                 conn.Close();
             }
             catch (Exception exc)
             {
                 Debug.WriteLine(exc.Message);
             }

             return itemsList;
         }*/
        /*    public List<Commentas> GetComments(int ItemID)
            {
                List<Commentas> comentaras = new List<Commentas>();
                try
                {
                    string sql = "select DISTINCT ID, UserID, itemID, comment, Timestamp from comment " + "where ItemID=@ItemID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ItemID", ItemID);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //int i = 0;
                    while (reader.Read())
                    {
                        // int i = 0;
                        int id = int.Parse(reader["id"].ToString());
                        int userId = int.Parse(reader["UserID"].ToString());
                        int ItemId = int.Parse(reader["ItemID"].ToString());
                        string commentas = reader["comment"].ToString();
                        string timestamp = reader["timestamp"].ToString();
                        comentaras.Add(new Commentas(id, userId, ItemId, commentas, timestamp));
                        //  i++;
                    }

                    conn.Close();
                }
                catch (Exception exc)
                {
                    Debug.WriteLine(exc.Message);
                }

                //foreach (Wishlist b in wishlistas)
                // b.SetWishItems(GetItemsWishlist(b.ItemId));

                return comentaras;
            }*/
        /* public List<Wishlist> GetWishlist(int UserID)
         {
             List<Wishlist> wishlistas = new List<Wishlist>();
             try
             {
                 string sql = "select DISTINCT id, UserID, itemID from wishlist " + "where UserID=@UserID";
                 SqlCommand cmd = new SqlCommand(sql, conn);
                 cmd.Parameters.AddWithValue("@UserID", UserID);

                 conn.Open();
                 SqlDataReader reader = cmd.ExecuteReader();
                 //int i = 0;
                 while (reader.Read())
                 {
                     // int i = 0;
                     int id = int.Parse(reader["id"].ToString());
                     int userId = int.Parse(reader["UserID"].ToString());
                     int ItemId = int.Parse(reader["ItemID"].ToString());
                     wishlistas.Add(new Wishlist(id, userId, ItemId));
                     //  i++;
                 }

                 conn.Close();
             }
             catch (Exception exc)
             {
                 Debug.WriteLine(exc.Message);
             }

             //foreach (Wishlist b in wishlistas)
             // b.SetWishItems(GetItemsWishlist(b.ItemId));

             return wishlistas;
         }*/
    }
}
