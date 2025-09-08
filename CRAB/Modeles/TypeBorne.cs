using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRAB.Modeles
{
    public class TypeBorne
    {
        #region Proprietes
        private string _codeTypeBorne;
        private int _dureeRevisionMinutes;
        private int _nbJoursEntreRevisions;
        private int _nbUnitesEntreRevisions;
        #endregion

        #region Constructeurs
        // Constructeur complet SANS collections ni relations
        public TypeBorne(string code, int dureeMinutes, int nbJours, int nbUnites)
        {
            _codeTypeBorne = code;
            _dureeRevisionMinutes = dureeMinutes;
            _nbJoursEntreRevisions = nbJours;
            _nbUnitesEntreRevisions = nbUnites;
        }
        #endregion

        #region Getters/Setters
        public string CodeTypeBorne { get => _codeTypeBorne; set => _codeTypeBorne = value; }
        public int DureeRevisionMinutes { get => _dureeRevisionMinutes; set => _dureeRevisionMinutes = value; }
        public int NbJoursEntreRevisions { get => _nbJoursEntreRevisions; set => _nbJoursEntreRevisions = value; }
        public int NbUnitesEntreRevisions { get => _nbUnitesEntreRevisions; set => _nbUnitesEntreRevisions = value; }
        #endregion

        #region Methodes
        // À compléter plus tard
        #endregion
    }
}
