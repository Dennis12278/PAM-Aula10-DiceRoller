using DiceRoller.ViewModels;

namespace DiceRoller.Views;

public partial class DadoView : ContentPage
{
	public DadoView()
	{
		InitializeComponent();
		this.BindingContext = new DadoViewModel();
	}
}