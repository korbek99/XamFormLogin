using System;
using XamFormLogin.Data;
using System.IO;
using Xamarin.Forms;
using XamFormLogin.Data;
using XamFormLogin.Droid.Data;

[assembly: Dependency(typeof(SQLite_Android))]
                       
namespace XamFormLogin.Droid.Data
{
    public class SQLite_Android : ISQLite
    {
        
            public SQLite_Android(){}
            public SQLite.SQLiteConnection GetConnection()
            {

            var sqlitefilename = "TestDB.db3";
            string documentsPath = System.Environment.GetFolderPath((System.Environment.SpecialFolder.Personal));
            var path = Path.Combine(documentsPath, sqlitefilename);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
            }

    }
}
