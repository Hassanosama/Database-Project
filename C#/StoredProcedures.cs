using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBapplication
{
    public class StoredProcedures
    {
        public static string GetShows = "GetShows";
        public static string GetCinemas = "GetCinemas";
        public static string Book = "BookShow";
        public static string MostReported = "most_reported_items";

        public static string Select_Concerts = "Select_Concerts";
        public static string Select_Singers = "Select_SingersNames";
        public static string AddConcert = "Add_Concert";
        public static string SelectDates = "Select_Dates";
        public static string BookConcert = "BookConcert";
        public static string GetID = "Get_ID";

        public static string UpdateItem = "UpdateItem";
        public static string uploadGame = "Upload_Game";
        public static string uploadMovie = "upload_movie";
        public static string uploadSeries = "Upload_Series";
        public static string uploadSong = "Upload_Song";
        public static string InseretGenre = "insertGenre";
        public static string GetAllCeleb = "Get_Celeb";
        public static string AddCeleb = "Add_Celeb";

        public static string ItemPurchases = "ItemPurchases";
        public static string TotalPurchasesForUser = "TotalPurchases";

        public static string Login = "Login";
        public static string ChangePassword = "ChangePassword";
        public static string Search = "SearchItems";

        public static string User_Fav = "UserFav";
        public static string User_History = "MyHistory";
        public static string User_Purchase = "MyItems";
        public static string User_Uploads = "Uploads";
        public static string Item_Info = "ItemInfo";
        public static string AddFav = "AddFavorites";
        public static string Buy = "Buy";
        public static string UploaderName = "UploaderName";
        public static string AddHistory = "AddHistory";
        public static string AddReport = "AddReport";
        public static string AddNewAccount = "NewAcc";
        public static string UserHaveThis = "HaveThisItem";

        public static string block = "Delete_User";
        public static string delete_item = "Delete_Item";
        public static string reports = "Get_Reports";
        public static string top_purchase = "most_purchased";
        public static string no_sell_items = "Not_Sold";
        public static string GetUsers = "Get_Users";
        public static string FilterUsers = "Filter_Users";


    }
}

