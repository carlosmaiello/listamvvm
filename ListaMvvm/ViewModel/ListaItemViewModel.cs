using ListaMvvm.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ListaMvvm.ViewModel
{
    public class ListaItemViewModel : ViewModel
    {
        private string desc;
        private ObservableCollection<Item> itens;
        private bool isEnviarParaServidor;
        private bool isAdicionando;
        private bool isNotAdicionando;

        public string Desc { get => desc; set => SetProperty(ref desc, value); }
        public ObservableCollection<Item> Itens { get => itens; set => SetProperty(ref itens, value); }
        public bool IsEnviarParaServidor { get => isEnviarParaServidor; set => SetProperty(ref isEnviarParaServidor, value); }
        public bool IsAdicionando { 
            get => isAdicionando; 
            set
            {
                SetProperty(ref isAdicionando, value);
                IsNotAdicionando = !IsAdicionando;
            }
        }
        public bool IsNotAdicionando { get => isNotAdicionando; set => SetProperty(ref isNotAdicionando, value); }

        public ICommand InserirCommand { get; set; }


        public ListaItemViewModel()
        {
            InserirCommand = new Command(() => Inserir());

            Itens = new ObservableCollection<Item>();
            IsEnviarParaServidor = Itens.Count > 0;
            IsAdicionando = false;
        }



        public void Inserir()
        {
            if (this.Desc == "")
                return;

            Item item = new Item();
            item.Desc = this.Desc;

            Itens.Add(item);
            IsEnviarParaServidor = Itens.Count > 0;

            this.Desc = "";
            IsAdicionando = false;
        }

        public void Remover(Item item)
        {
            this.Itens.Remove(item);
            IsEnviarParaServidor = Itens.Count > 0;
        }
    }
}
