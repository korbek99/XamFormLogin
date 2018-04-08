using System;
using System.IO;
using Xamarin.Forms;
using XamFormLogin.Data;
using XamFormLogin.iOS.Data;

[assembly: Dependency(typeof(SQLite_IOS))]

namespace XamFormLogin.iOS.Data
{
    public class SQLite_IOS : ISQLite
    {
        public SQLite_IOS()
        {
        }

        public SQLite.SQLiteConnection GetConnection()
        {

            var filename = "TestDB.db3";
            string documentsPath = System.Environment.GetFolderPath((System.Environment.SpecialFolder.Personal));
            var libraryPath = Path.Combine(documentsPath, "..", "Library");
            var path = Path.Combine(libraryPath, filename);
            var connection = new SQLite.SQLiteConnection(path);
            return connection;
        }
    }
}
