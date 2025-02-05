using Microsoft.Maui.Controls;
using DAM_Leccion_AOE;
using DAM_Leccion_AOE.View;  // ← Importar correctamente la carpeta View

namespace DAM_Leccion_AOE
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }

       
    }
}
