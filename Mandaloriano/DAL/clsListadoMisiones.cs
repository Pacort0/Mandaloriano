using Mandaloriano.Models.Entidades;

namespace Mandaloriano.DAL
{
    public static class clsListadoMisiones
    {
        public static List<clsMision> listaMisionesLarga()
        {
            List<clsMision> listaLarga = new List<clsMision>()
            {
                new clsMision() {IdMision = 0, NombreMision="Rescate de Baby Yoda", ObjetivoMision="Debes hacerte con Grogu y llevárselo a Luke SkyWalker para su entrenamiento.", RecompensaMision=5000},
                new clsMision() {IdMision = 1, NombreMision="Recuperar armadura Beskar", ObjetivoMision="Tu armadura de Beskar ha sido robada. Debes encontrarla.", RecompensaMision=2000},
                new clsMision() {IdMision = 2, NombreMision="Planeta Sorgon", ObjetivoMision="Debes llevar a un niño de vuelta a su planeta natal “Sorgon”.", RecompensaMision=500},
                new clsMision() {IdMision = 3, NombreMision="Renacuajos", ObjetivoMision="Debes llevar a una Dama Rana y sus huevos de Tatooine a la luna del estuario Trask, donde su esposo fertilizará los huevos.", RecompensaMision=500}
            };
            return listaLarga;
        }
    }
}
