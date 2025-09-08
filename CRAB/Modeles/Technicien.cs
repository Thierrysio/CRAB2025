using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRAB.Modeles
{
    public class Technicien
    {
        #region Proprietes
        private int _matricule;
        private string _nom;
        private string _prenom;
        private List<Visite> _lesVisites; // init interne (vide)
        #endregion

        #region Constructeurs
        // Constructeur complet SANS collections ni relations
        public Technicien(int matricule, string nom, string prenom)
        {
            _matricule = matricule;
            _nom = nom;
            _prenom = prenom;
            _lesVisites = new List<Visite>();
        }
        #endregion

        #region Getters/Setters
        public int Matricule { get => _matricule; set => _matricule = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public List<Visite> LesVisites { get => _lesVisites; set => _lesVisites = value; }
        #endregion

        #region Methodes
        // À compléter plus tard
        #endregion
    }
}
