using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRAB.Modeles
{
    public class Station
    {
        #region Proprietes
        private int _idStation;
        private string _libelleEmplacement;
        private List<Borne> _lesBornes;   // multiplicité 1..*
        #endregion

        #region Constructeurs
        // Constructeur complet
        public Station(int id, string libelle)
        {
            _idStation = id;
            _libelleEmplacement = libelle;
            LesBornes =  new List<Borne>();
        }

        #endregion

        #region Getters/Setters
        public int IdStation { get => _idStation; set => _idStation = value; }
        public string LibelleEmplacement { get => _libelleEmplacement; set => _libelleEmplacement = value; }
        public List<Borne> LesBornes { get => _lesBornes; set => _lesBornes = value; }


        #endregion

        #region Methodes
        public Visite GetVisiteAFaire()
        {
            List<Borne> bornesAReviser = new List<Borne>();
            int totalVisite = 0;
            foreach (Borne maborne in this.LesBornes)
            {
                if (maborne.estAReviser())
                {
                    bornesAReviser.Add(maborne);
                    totalVisite += maborne.LeTypeBorne.DureeRevisionMinutes;
                }
            }

            if (bornesAReviser.Count == 0)
            {
                return null; // aucune visite à créer
            }
            else
            {
                // On crée une visite "programmée"
                return new Visite( this,EtatVisite.Programmee, totalVisite, bornesAReviser);
            }
        }
        #endregion
    }
}
