using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using Nutricao.Data;

namespace Nutricao
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaRefeicoes : ContentPage
	{
        public ObservableCollection<Refeicao> Refeicoes { get; set; }
        private RefeicaoDAO dao;

		public ListaRefeicoes (RefeicaoDAO dao)
		{
            BindingContext = this;
            this.dao = dao;
            Refeicoes = dao.Lista;

			InitializeComponent ();
		}

        public async void AcaoItem(object sender, ItemTappedEventArgs e)
        {
            Refeicao refeicao = e.Item as Refeicao;
            string msg = "Você tem certeza que deseja remover a refeição " + refeicao.Descricao;
            var resposta = await DisplayAlert("Remover item", msg, "SIM", "NÃO");
            if (resposta)
            {
                dao.Remove(refeicao);
                await DisplayAlert("Remover item","Refeição removida com sucesso!","OK");
            }

        }

    }
}