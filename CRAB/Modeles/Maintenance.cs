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
            
        }
        #endregion
    }
}
