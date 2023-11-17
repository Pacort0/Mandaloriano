using Mandaloriano.DAL;
using Mandaloriano.Models.Entidades;

namespace Mandaloriano.ViewModels
{
    public class clsMisionesVM:clsMision
    {
        private List<clsMision> listaCorta;
        private List<clsMision> listaLarga;

        public clsMisionesVM()
        {
            NombreMision = "";
            ObjetivoMision = "";
            RecompensaMision = 0;
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
