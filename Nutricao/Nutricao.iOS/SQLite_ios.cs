using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using Nutricao.Data;
using SQLite.Net;
using SQLite.Net.Platform.XamarinIOS;
using UIKit;
using System.IO;
using Nutricao.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_ios))]
namespace Nutricao.iOS
{
    public class SQLite_ios : ISQLite
    {
        public SQLite_ios()
        {

        }

        public SQLiteConnection GetConnection()
        {
            var fileName = "Refeicoes.db3";
            var documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documents, ".", "Library", fileName);
            var platform = new SQLitePlatformIOS();
            return new SQLiteConnection(platform,path);
        }
    }
}