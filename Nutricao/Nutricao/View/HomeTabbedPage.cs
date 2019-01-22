using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using System.Collections.ObjectModel;
using SQLite;
using SQLite.Net;
using Nutricao.Data;
using SQLiteConnection = SQLite.Net.SQLiteConnection;

namespace Nutricao
{
	public class HomeTabbedPage : TabbedPage
	{
		public HomeTabbedPage ()
		{
            SQLiteConnection con = DependencyService.Get<ISQLite>().GetConnection();

            RefeicaoDAO dao = new RefeicaoDAO(con);

            this.Children.Add(new CadastroRefeicao(dao));
            this.Children.Add(new ListaRefeicoes(dao));
		}
	}
}