using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite.Net;
using SQLite.Net.Platform.XamarinAndroid;


using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Nutricao.Data;
using Xamarin.Forms;
using Nutricao.Droid;
using System.IO;
using System.Data;
using Mono.Data.Sqlite;

[assembly: Dependency(typeof(SQLite_droid))]
namespace Nutricao.Droid
{
    public class SQLite_droid : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var fileName = "Refeicoes.db3";
            string documents = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string path = Path.Combine(documents, fileName);
            var platform = new SQLitePlatformAndroid();
            return new SQLiteConnection(platform,path);
        }
    }
}