namespace Mandaloriano.Models.Entidades
{
    public class clsMision
    {
        #region atributos
        private int idMision;
        private string objetivoMision;
        private string planetaMision;
        private string recompensaMision;
        #endregion

        #region constructores
        public clsMision() { }
        public clsMision(int idMision, string objetivoMision, string planetaMision, string recompensaMision)
        {
            this.idMision = idMision;
            this.objetivoMision = objetivoMision;
            this.planetaMision = planetaMision;
            this.recompensaMision = recompensaMision;
        }
        #endregion

        #region propiedades
        public int IdMision
        {
            get { return idMision; }
            set { idMision = value; }
        }
        public string ObjetivoMision
        {
            get { return objetivoMision; }
            set { objetivoMision = value; }
        }
        public string PlanetaMision
        {
            get { return planetaMision; }
            set { planetaMision = value; }
        }
        public string RecompensaMision
        {
            get { return recompensaMision; }
            set { recompensaMision = value;}
        }
        #endregion
    }
}
