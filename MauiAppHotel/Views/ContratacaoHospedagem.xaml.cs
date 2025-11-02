namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}

    private async void SobreClicked(object sender, EventArgs e)
    {
  
        await Shell.Current.GoToAsync("Sobre");
    }

}