using DAM_Leccion_AOE.Model;

namespace DAM_Leccion_AOE
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        private PersonaModel personaModel { get; set; }


        public MainPage()
        {
            InitializeComponent();
            Ejecutar();
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

        public void Ejecutar()
        {
            personaModel = new PersonaModel()
            {
                Nombre = "Hola Aqui Estoy :)",
            };

            BindingContext = personaModel;

            //Binding personaBinding = new Binding(); //origen
            //personaBinding.Path = "Nombre"; //ruta
            //txtNombre.SetBinding(Entry.TextProperty, personaBinding); //Destino final



            //PersonaModel personaModel = new PersonaModel();
            //personaModel.Nombre = "Hola aqui estoy";
            //txtNombre.Text = personaModel.Nombre;


            //txtNombre.Text = "HOLA ESTOY AQUI";
        }

        //Evento guardar
        private void btnAceptar_Clicked(object sender, EventArgs e)
        {
            // DisplayAlert("Asistente del sistema", "Se ha guardado el registro en la BD", "Aceptar");
            personaModel.Nombre = "Alondra Montalvo";
        }
    }

}
