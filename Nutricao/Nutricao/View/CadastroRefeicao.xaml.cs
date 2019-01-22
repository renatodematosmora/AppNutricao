using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using Nutricao.Data;
using Nutricao.ViewModel;

namespace Nutricao
{
    public partial class CadastroRefeicao : ContentPage
    {
        public CadastroRefeicao(RefeicaoDAO dao)
        {
            CadastroRefeicaoViewModel vm = new CadastroRefeicaoViewModel(dao, this);
            BindingContext = vm;
            InitializeComponent();
        }
    }
}
