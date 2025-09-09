using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRAB.Modeles
{
    public class Maintenance
    {
        #region Proprietes
        private List<Station> _lesStations;
        private List<Technicien> _lesTechniciens;
        private List<Visite> _lesVisites;
        #endregion

        #region Constructeurs
        // Constructeur complet SANS collections ni relations
        public Maintenance()
        {
            _lesStations = new List<Station>();
            _lesTechniciens = new List<Technicien>();
            _lesVisites = new List<Visite>();
        }
        #endregion

        #region Getters/Setters
        public List<Station> LesStations { get => _lesStations; set => _lesStations = value; }
        public List<Technicien> LesTechniciens { get => _lesTechniciens; set => _lesTechniciens = value; }
        public List<Visite> LesVisites { get => _lesVisites; set => _lesVisites = value; }
        #endregion

        #region Methodes
        public void AffecterVisites()
        {
            foreach(Visite uneVisite in this.LesVisites)
            {
                if(uneVisite.Etat == EtatVisite.Programmee) 
                {
                    Technicien unTechnicienMoinsOccupe = null;
                    int uneChargeMin = int.MaxValue;

                    foreach(Technicien unTechnicien in this.LesTechniciens)
                    {
                        int maChargeTotale = unTechnicien.GetChargeTotale();
                        if(unTechnicienMoinsOccupe == null ||maChargeTotale< uneChargeMin)
                        {
                            uneChargeMin = maChargeTotale;
                            unTechnicienMoinsOccupe = unTechnicien;
                        }
                    }
                    uneVisite.Affecter(unTechnicienMoinsOccupe);
                }
                

            }
        }
        #endregion
    }
}
