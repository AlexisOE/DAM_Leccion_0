using DAM_Leccion_AOE.ViewModel;

namespace DAM_Leccion_AOE.View;

public partial class PersonasView : ContentPage
{
	public PersonasView()
	{
		InitializeComponent();

		BindingContext = new PersonasViewModel();
	}
}