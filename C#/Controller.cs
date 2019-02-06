using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBapplication
{
    public class Controller
    {
        private DBManager dbMan; // A Reference of type DBManager 
                                 // (Initially NULL; NO DBManager Object is created yet)

        public Controller()
        {
            dbMan = new DBManager(); // Create the DBManager Object
        }

        //checks the username/password and returns the priviledges associated with this user
        //Returns 0 in case of error
        public int CheckPassword_Basic(string username, string password)
        {
            //Query the DB to check for username/password
            string query = StoredProcedures.Login;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@password", password);
            object p = dbMan.ExecuteScalar(query,Parameters);

            if (p == null) return 0;
            else return (int)p;
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public int Change_Password(string user,string oldpass,string newpass)
        {
            string change = StoredProcedures.ChangePassword;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", user);
            Parameters.Add("@pass", oldpass);
            Parameters.Add("@npass", newpass);
            return dbMan.ExecuteNonQuery(change, Parameters);
        }
        public DataTable SearchForItems(string name,int type,string genre)
        {

            string q = StoredProcedures.Search;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name",name);
            Parameters.Add("@type",type);
            Parameters.Add("@genre",genre);
            return dbMan.ExecuteReader(q, Parameters);
        }
        public DataTable User_Favorits(string username)
        {

            string q = StoredProcedures.User_Fav;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return dbMan.ExecuteReader(q, Parameters);
        }
        public DataTable User_Purchase(string username)
        {

            string q = StoredProcedures.User_Purchase;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return dbMan.ExecuteReader(q, Parameters);
        }
        public DataTable User_History(string username)
        {

            string q = StoredProcedures.User_History;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return dbMan.ExecuteReader(q, Parameters);
        }
        public DataTable User_uploads(string username)
        {

            string q = StoredProcedures.User_Uploads;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            return dbMan.ExecuteReader(q, Parameters);
        }
        public DataTable Item_Info(int id,string typ)
        {

            string q = StoredProcedures.Item_Info;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@t", typ);
            return dbMan.ExecuteReader(q, Parameters);
        }
        public int Add_Favorites(string user, string ItemName)
        {
            string q = StoredProcedures.AddFav;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", user);
            Parameters.Add("@itemname", ItemName);
            return dbMan.ExecuteNonQuery(q, Parameters);
        }
        public int Buy_Item(string user, string ItemName)
        {
            string q = StoredProcedures.Buy;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", user);
            Parameters.Add("@itemname", ItemName);
            return dbMan.ExecuteNonQuery(q, Parameters);
        }
        public string Uploader_name(int ItemID)
        {
            string q = StoredProcedures.UploaderName;
            
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@itemid", ItemID);
            DataTable tmp = dbMan.ExecuteReader(q, Parameters);
            return tmp.Rows[0]["Users_name"].ToString();
        }
        public int Add_To_History(string user, string item_type)
        {
            string q = StoredProcedures.AddHistory;
            string typ = "";
            bool st = false;
            for (int i = 0; i < item_type.Length; ++i)
            {
                if (item_type[i] == '{') { st = true; continue; }
                if (item_type[i] == '}') break;
                if (st) typ += item_type[i];
            }
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", user);
            Parameters.Add("@itemname", typ);
            return dbMan.ExecuteNonQuery(q, Parameters);
        }
        public int Report(string user, string item_name,string reason)
        {
            string q = StoredProcedures.AddReport;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", user);
            Parameters.Add("@itemname", item_name);
            Parameters.Add("@comment", reason);
            return dbMan.ExecuteNonQuery(q, Parameters);
        }
        public int Add_New_Acc(string username, string password, int priv)
        {
            string q = StoredProcedures.AddNewAccount;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@password", password);
            Parameters.Add("@priv", priv);
            return dbMan.ExecuteNonQuery(q, Parameters);
        }
        public int HaveThis(int ItemID, string username)
        {
            //Query the DB to check for username/password
            string query = StoredProcedures.UserHaveThis;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            Parameters.Add("@itemid", ItemID);
            object p = dbMan.ExecuteScalar(query, Parameters);

            if (p == null) return 0;
            else return (int)p;
        }
        public DataTable Get_Reports()
        {
            string q = StoredProcedures.reports;
            return dbMan.ExecuteReader(q,null);
        }
        public int Delete_Item(int id)
        {
            string q = StoredProcedures.delete_item;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@itemid", id);
            return dbMan.ExecuteNonQuery(q, Parameters);
        }
        public int Delete_User(string username)
        {
            string q = StoredProcedures.block;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@UploaderName", username);
            return dbMan.ExecuteNonQuery(q, Parameters);
        }
        public DataTable Get_Users()
        {
            string q = StoredProcedures.GetUsers;
            return dbMan.ExecuteReader(q, null);
        }
        public DataTable Filter_Users(int priv)
        {
            string q = StoredProcedures.FilterUsers;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@priv", priv);
            return dbMan.ExecuteReader(q, Parameters);
        }
        public DataTable Get_Most_Sold()
        {
            string q = StoredProcedures.top_purchase;
            return dbMan.ExecuteReader(q, null);
        }
        public DataTable Get_Not_Sold()
        {
            string q = StoredProcedures.no_sell_items;
            return dbMan.ExecuteReader(q, null);
        }


        public int Upload_Movie(string name, float price, int Year, float Rate, string uploader, byte[] img, float dur, string dir, string act1, string act2)
        {
            string upload = StoredProcedures.uploadMovie;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            Parameters.Add("@Price", price);
            Parameters.Add("@Year", Year);
            Parameters.Add("@Rate", Rate);
            Parameters.Add("@UploaderUserName", uploader);
            Parameters.Add("@Poster_Url", img);
            Parameters.Add("@Duration", dur);
            Parameters.Add("@Name_Director", dir);
            Parameters.Add("@act1", act1);
            Parameters.Add("@act2", act2);
            object res = dbMan.ExecuteScalar(upload, Parameters);
            if (res == null) return 0;
            return (int)res;
        }
        public int Upload_Song(string name, float price, int Year, float Rate, string uploader, byte[] img, float dur, string singer, string album)
        {
            string upload = StoredProcedures.uploadSong;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            Parameters.Add("@Price", price);
            Parameters.Add("@Year", Year);
            Parameters.Add("@Rate", Rate);
            Parameters.Add("@UploaderUserName", uploader);
            Parameters.Add("@Poster_Url", img);
            Parameters.Add("@Duration", dur);
            Parameters.Add("@Singer", singer);
            Parameters.Add("@Album", album);
            object res = dbMan.ExecuteScalar(upload, Parameters);
            if (res == null) return 0;
            return (int)res;
        }
        public int Upload_Series(string name, float price, int Year, float Rate, string uploader, byte[] img,int nos,string dir, string act1, string act2)
        {
            string upload = StoredProcedures.uploadSeries;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            Parameters.Add("@Price", price);
            Parameters.Add("@Year", Year);
            Parameters.Add("@Rate", Rate);
            Parameters.Add("@UploaderUserName", uploader);
            Parameters.Add("@Poster_Url", img);
            Parameters.Add("@Name_Director", dir);
            Parameters.Add("@NOS", nos);
            Parameters.Add("@act1", act1);
            Parameters.Add("@act2", act2);
            object res = dbMan.ExecuteScalar(upload, Parameters);
            if (res == null) return 0;
            return (int)res;

        }
        public int Upload_Game(string name, float price, int Year, float Rate, string uploader, byte[] img,string studio)
        {
            string upload = StoredProcedures.uploadGame;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            Parameters.Add("@Price", price);
            Parameters.Add("@Year", Year);
            Parameters.Add("@Rate", Rate);
            Parameters.Add("@UploaderUserName", uploader);
            Parameters.Add("@Poster_Url", img);
            Parameters.Add("@Studio", studio);
            object res = dbMan.ExecuteScalar(upload, Parameters);
            if (res == null) return 0;
            return (int)res;
        }
        public int Insert_Genre(int id, string g, int t)
        {
            string q = StoredProcedures.InseretGenre;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@itemID", id);
            Parameters.Add("@Genre", g);
            Parameters.Add("@Type", t);
            return dbMan.ExecuteNonQuery(q, Parameters);
        }
        public DataTable Get_Celebs(int t)
        {
            string q = StoredProcedures.GetAllCeleb;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@t", t);
            return dbMan.ExecuteReader(q, Parameters);
        }
        public int Add_Celeb(string name, int age, int t)
        {
            string q = StoredProcedures.AddCeleb;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name", name);
            Parameters.Add("@age", age);
            Parameters.Add("@t", t);
            return dbMan.ExecuteNonQuery(q, Parameters);
        }
        public DataTable shows()
        {

            string q = StoredProcedures.GetCinemas;

            return dbMan.ExecuteReader(q, null);
        }
        public DataTable showmovies(string s)
        {

            string q = StoredProcedures.GetShows;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Cname", s);
            return dbMan.ExecuteReader(q, Parameters);
        }
        public int Book(string user, string Cinema, string Movie)
        {
            string change = StoredProcedures.Book;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", user);
            Parameters.Add("@cinemaname", Cinema);
            Parameters.Add("@moviename", Movie);
            return dbMan.ExecuteNonQuery(change, Parameters);
        }
        public DataTable Most_Reported()
        {
            string q = StoredProcedures.MostReported;
            return dbMan.ExecuteReader(q,null);
        }
        /////////////////////////////////Update
        public int Update_Item(string name, float price, float Rate, int ID)
        {
            string upload = StoredProcedures.UpdateItem;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@itemid", ID);
            Parameters.Add("@itemname", name);
            Parameters.Add("@itemrate", Rate);
            Parameters.Add("@price", price);
            object res = dbMan.ExecuteScalar(upload, Parameters);
            if (res == null) return 0;
            return (int)res;
        }
        public DataTable Select_Concerts(int type, int user_id)
        {

            string StoredProcedureName = StoredProcedures.Select_Concerts;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@type", type);
            Parameters.Add("@user_id", user_id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable Select_Singers(int type)   // type = 1 select all singers, type = 2 select only who perform concerts
        {

            string StoredProcedureName = StoredProcedures.Select_Singers;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@type", type);
            return dbMan.ExecuteReader(StoredProcedureName,null);
        }
        public DataTable Select_Dates(string singer)
        {

            string StoredProcedureName = StoredProcedures.SelectDates;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Singer", singer);  

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int addConcert(int Price, int seats, string time, string location, int phone, string singer)
        {
            string upload = StoredProcedures.AddConcert;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@TicketPrice", Price);
            Parameters.Add("@AvailableSeats", seats);
            Parameters.Add("@Time_Date", time);
            Parameters.Add("@Location", location);
            Parameters.Add("@Phone", phone);
            Parameters.Add("@Singer", singer);
            return dbMan.ExecuteNonQuery(upload, Parameters);
        }

        public int bookConcert(int user_id, string singer, string time)
        {
            string upload = StoredProcedures.BookConcert;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID_User", user_id);
            Parameters.Add("@Singer", singer);
            Parameters.Add("@Time", time);
            object res = dbMan.ExecuteScalar(upload, Parameters);
            if (res == null) return 1;
            return (int)res;
        }
        public int Get_ID(string username)
        {
            string upload = StoredProcedures.GetID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", username);
            object res = dbMan.ExecuteScalar(upload, Parameters);
            if (res == null) return 0;
            return (int)res;
        }



    }
}
