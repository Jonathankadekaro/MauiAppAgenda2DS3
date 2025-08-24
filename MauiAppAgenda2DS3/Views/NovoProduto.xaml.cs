using MauiAppAgenda2DS3.Models;

namespace MauiAppAgenda2DS3.Views;

public partial class NovoProduto : ContentPage
{
	public NovoProduto()
	{
		InitializeComponent();
	}

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {

		try
		{
			Produto p = new Produto
			{
				Descricao = txt_descricao.Text,
				Quantidade = Convert.ToDouble(txt_quantidade.Text),
				Preco = Convert.ToDouble(txt_preco.Text)

			};	

			await App.Db.Insert(p);

			await DisplayAlert("Sucesso", "Registro concluido", "OK");


        } catch (Exception ex)
		{

			await DisplayAlert("Ops", ex.Message, "OK");
        }


    }
}