using Nutricao.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Nutricao.ViewModel
{
    public class CadastroRefeicaoViewModel : INotifyPropertyChanged
    {
        private string descricao;
        private double calorias;
        public string Descricao
        {
            get
            {
                return descricao;
            }
            set
            {
                if(value != descricao)
                {
                    descricao = value;
                    OnPropertyChanged("Descricao");
                }
            }
        }
        public double Calorias
        {
            get
            {
                return calorias;
            }
            set
            {
                if(value != calorias)
                {
                    calorias = value;
                    OnPropertyChanged("Calorias");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private RefeicaoDAO dao;
        private ContentPage page;
        public ICommand SalvaRefeicao { get; protected set; }

        public CadastroRefeicaoViewModel(RefeicaoDAO dao, ContentPage page)
        {
            this.dao = dao;
            this.page = page;
            SalvaRefeicao = new Command(() => {
                Refeicao refeicao = new Refeicao(descricao, calorias);
                dao.Salvar(refeicao);
                string msg = "A refeição " + descricao + " de " + calorias.ToString() + " calorias foi salva com sucesso!";
                this.page.DisplayAlert("Salvar refeição", msg, "Ok");
            });
        }

        private void OnPropertyChanged(string nome)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(nome));
        }
    }
}
