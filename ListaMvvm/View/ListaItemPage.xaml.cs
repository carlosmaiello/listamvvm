using ListaMvvm.Model;
using ListaMvvm.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListaMvvm.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaItemPage : ContentPage
    {
        public ListaItemPage()
        {
            InitializeComponent();
        }

        private async void Remover_Clicked(object sender, EventArgs e)
        {
            ListaItemViewModel viewModel = (this.BindingContext as ListaItemViewModel);

            if (await DisplayAlert("Removendo item",
                "Deseja realmente remover este ítem?", "Sim", "Não"))
            {
                Button btn = sender as Button;
                Item item = btn.CommandParameter as Item;
                viewModel.Remover(item);
            }
        }

        private void Adicionar_Clicked(object sender, EventArgs e)
        {
            ListaItemViewModel viewModel = (this.BindingContext as ListaItemViewModel);
            viewModel.IsAdicionando = true;
        }
    }
}