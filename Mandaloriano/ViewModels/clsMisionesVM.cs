using Mandaloriano.DAL;
using Mandaloriano.Models.Entidades;

namespace Mandaloriano.ViewModels
{
    public class clsMisionesVM:clsMision
    {
        private List<clsMision> listaMisiones;

        public clsMisionesVM()
        {
            listaMisiones = clsListadoMisiones.listaMisionesLarga();
        }
        public List<clsMision> ListaMisiones
        {
            get { return listaMisiones; }
            set { listaMisiones = value; }
        }
    }

    
}
