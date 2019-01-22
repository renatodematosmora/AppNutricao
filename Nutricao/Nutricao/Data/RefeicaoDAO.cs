using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net;
using System.Collections.ObjectModel;

namespace Nutricao.Data
{
    public class RefeicaoDAO
    {
        private SQLiteConnection conexao;

        private ObservableCollection<Refeicao> lista;

        public ObservableCollection<Refeicao> Lista
        {
            get
            {
                if(lista == null)
                {
                    lista = GetAll();
                }
                return lista;
            }
            private set
            {
                lista = value;
            }
        }

        public RefeicaoDAO(SQLiteConnection con)
        {
            conexao = con;
            conexao.CreateTable<Refeicao>();
        }

        public void Salvar(Refeicao refeicao)
        {
            conexao.Insert(refeicao);
            lista.Add(refeicao);
        }

        public void Remove(Refeicao refeicao)
        {
            conexao.Delete<Refeicao>(refeicao.ID);
            lista.Remove(refeicao);
        }

        private ObservableCollection<Refeicao> GetAll()
        {
            return new ObservableCollection<Refeicao>(conexao.Table<Refeicao>());
        }
    }
}
