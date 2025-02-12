using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAM_Leccion_AOE.Model;

namespace DAM_Leccion_AOE.ViewModel
{
    public class MainPageViewModel
    {
        private PersonasModel personasModel { get; set; }

        public MainPageViewModel()
        {
            Consultar();
        }


        public void Consultar()
        {
            personasModel = new PersonasModel()
            {
                Nombre = "Alexis",
                Apellido = "Olvera",
                Edad = "21",

            };




        }
    }
}
