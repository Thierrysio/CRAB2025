using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRAB.Modeles
{
    public class Borne
    {
        #region Proprietes
        private int _idBorne;
        private DateTime _dateDerniereRevision;
        private int _indiceCompteurUnites;

        private TypeBorne _leType;   // relation (à setter après)
        #endregion

        #region Constructeurs
        // Constructeur complet SANS collections ni relations
        public Borne(int id, DateTime dateDerniereRevision, int indiceCompteur)
        {
            _idBorne = id;
            _dateDerniereRevision = dateDerniereRevision;
            _indiceCompteurUnites = indiceCompteur;
            _leType = null;      // sera renseigné via setter
        }
        #endregion

        #region Getters/Setters
        public int IdBorne { get => _idBorne; set => _idBorne = value; }
        public DateTime DateDerniereRevision { get => _dateDerniereRevision; set => _dateDerniereRevision = value; }
        public int IndiceCompteurUnites { get => _indiceCompteurUnites; set => _indiceCompteurUnites = value; }

        public TypeBorne LeTypeBorne { get => _leType; set => _leType = value; }
        #endregion

        #region Methodes
        public bool estAReviser()
        {
            bool resultat = false;

            TimeSpan difference = DateTime.Now - this.DateDerniereRevision;
            if (difference.Days>=this.LeTypeBorne.NbJoursEntreRevisions || this.IndiceCompteurUnites>=this.LeTypeBorne.NbUnitesEntreRevisions )
            {
                resultat = true;
            }

            return resultat;
        }

        #endregion
    }
}
