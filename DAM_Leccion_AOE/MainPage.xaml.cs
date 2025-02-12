using DAM_Leccion_AOE.Model;
using DAM_Leccion_AOE.ViewModel;

namespace DAM_Leccion_AOE
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        MainPageViewModel mainPageViewModel = new MainPageViewModel();



        private PersonasModel personaModel { get; set; }


        public MainPage()
        {
            InitializeComponent();
            BindingContext = mainPageViewModel;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        

        //Evento guardar
        private void btnAceptar_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("Asistente del sistema", "Se ha guardado el registro en la BD", "Aceptar");
            //personaModel.Nombre = "Alexis";
            //personaModel.Apellido = "Olvera";
            //personaModel.Edad = "21";
        }
    }

}
