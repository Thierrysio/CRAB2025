using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRAB.Modeles
{
    public enum EtatVisite { Programmee = 0, Affectee = 1, Realisee = 2 }

    public class Visite
    {
        #region Proprietes
        private EtatVisite _etat;
        private int _dureeTotale;

        private Station _laStation;        // relation (à setter après)
        private List<Borne> _lesBornes;     // init interne (vide), on ajoutera ensuite ≥ 1
       
        #endregion

        #region Constructeurs
        // Constructeur complet SANS collections ni relations
        public Visite(EtatVisite etat, int dureetotale)
        {
            _etat = etat;
            _dureeTotale = dureetotale;

            _laStation = null;                 // sera renseigné via setter
            _lesBornes = new List<Borne>();     // 1..* -> on commence vide
        }
        #endregion

        #region Getters/Setters
        public EtatVisite Etat { get => _etat; set => _etat = value; }
        public int DureeTotaleMinutes { get => _dureeTotale; set => _dureeTotale = value; }

        public Station LaStation { get => _laStation; set => _laStation = value; }
        public List<Borne> LesBornes { get => _lesBornes; set => _lesBornes = value; }
        #endregion

        #region Methodes
        // À compléter plus tard
        #endregion
    }
}
