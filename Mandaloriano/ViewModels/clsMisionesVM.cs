using Mandaloriano.DAL;
using Mandaloriano.Models.Entidades;

namespace Mandaloriano.ViewModels
{
    public class clsMisionesVM
    {
        private List<clsMision> listaCorta;
        private List<clsMision> listaLarga;

        public clsMisionesVM()
        {
            listaCorta = clsListadoMisiones.listaMisionesCorta();
            listaLarga = clsListadoMisiones.listaMisionesLarga();
        }

        public List<clsMision> ListaCorta
        {
            get { return listaCorta; }
            set { listaCorta = value; }
        }

        public List<clsMision> ListaLarga
        {
            get { return listaLarga; }
            set { listaLarga = value; }
        }
    }

    
}
