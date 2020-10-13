using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Service
{
    public class CommuneService
    {
        private List<Commune> Communes = new List<Commune>();
        private DemandeALutilisateur _demandeALutilisateur;

        private DepartementService _departementService;

        public CommuneService(DemandeALutilisateur demandeALutilisateur, DepartementService departementService)
        {
            this._demandeALutilisateur = demandeALutilisateur;
            this._departementService = departementService;
        }

        public Commune CreeCommune()
        {
            Commune result = new Commune();

            result.Nom = _demandeALutilisateur.saisieNom("Nom de la commune :");
            result.CodePost = _demandeALutilisateur.saisieEntier(" Code postal :");
            result.NbHab = _demandeALutilisateur.saisieEntier("nombre d'habitants :");

            Communes.Add(result);
            return result;
        }
    }
}
