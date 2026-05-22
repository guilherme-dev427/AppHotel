using AppHotel.Models;

namespace AppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	App PropriedadesApp;
	public ContratacaoHospedagem()
	{
		InitializeComponent();
		PropriedadesApp = (App)Application.Current;
		pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

		dtpck_checkin.MinimumDate = DateTime.Now;
		dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, 
			DateTime.Now.Month + 1, DateTime.Now.Day);

		dtpck_checkout.MinimumDate = dtpck_checkin.Date?.AddDays(1);
		dtpck_checkout.MaximumDate = dtpck_checkin.Date?.AddMonths(6);
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		try
		{
			Hospedagem h = new Hospedagem()
			{
				QuartoSelecionado = (Quarto)pck_quarto.SelectedItem,
				QtdAdultos = Convert.ToInt32(stp_adultos.Value),
				QtdCriancas = Convert.ToInt32(stp_criancas.Value),
				DataCheckIn = dtpck_checkin.Date.Value,
				DataCheckOut = dtpck_checkout.Date.Value
            };
			Navigation.PushAsync(new HospedagemContratada()
			{
				BindingContext = h
            });      
			}
		catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "OK");
        }

    }
}