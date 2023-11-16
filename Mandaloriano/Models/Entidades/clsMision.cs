namespace Mandaloriano.Models.Entidades
{
    public class clsMision
    {
        #region atributos
        private int idMision;
        private string objetivoMision;
        private string nombreMision;
        private int recompensaMision;
        #endregion

        #region constructores
        public clsMision() { }
        public clsMision(int idMision, string nombreMision, string objetivoMision, int recompensaMision)
        {
            this.idMision = idMision;
            this.nombreMision= nombreMision;
            this.objetivoMision = objetivoMision;
            this.recompensaMision = recompensaMision;
        }
        #endregion
                
        #region propiedades
        public int IdMision
        {
            get { return idMision; }
            set { idMision = value; }
        }
        public string NombreMision
        {
            get { return nombreMision;}
            set { nombreMision = value;}
        }
        public string ObjetivoMision
        {
            get { return objetivoMision; }
            set { objetivoMision = value; }
        }
        public int RecompensaMision
        {
            get { return recompensaMision; }
            set { recompensaMision = value;}
        }
        #endregion
    }
}
