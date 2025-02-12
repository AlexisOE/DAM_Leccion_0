using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DAM_Leccion_AOE.Model;
using FoundationStandard.ObjectHydrator;

namespace DAM_Leccion_AOE.ViewModel
{
    public class PersonasViewModel
    {
        private ObservableCollection<PersonasModel> Personas { get; set; }

        public PersonasViewModel()
        {
            Consultar();
        }


        public void Consultar() 
        {

            var listado = new Hydrator<PersonasModel>().WithFirstName(n => n.Nombre);
            Personas = new ObservableCollection<PersonasModel>(listado.GetList(20));
        
        }
        
    }
}
