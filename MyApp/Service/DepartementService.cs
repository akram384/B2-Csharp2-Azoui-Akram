using MyApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Service
{
    public class DepartementService
    {
        public DemandeALutilisateur _DemandeALutilisateur;
        List<Departement> departements = new List<Departement>();

        public DepartementService(DemandeALutilisateur demandeALutilisateur)
        {
            this._DemandeALutilisateur = demandeALutilisateur;
        }

        public Departement CreeDepartement()
        {
            Departement d = new Departement();
            d.nom = _DemandeALutilisateur.saisieNom("Nom du departement");
            d.code = _DemandeALutilisateur.saisieEntier("Numeros de departement");
            departements.Add(d);
            return d;
        }

        public Departement DemandeDepartement()
        {

            Departement result = null;
            while (result == null)
            {
                string saisieUtilisateur = _DemandeALutilisateur.saisieNom("Numéro de la salle ?");
                foreach (Departement d in this.departements)
                {
                    if (d.nom == saisieUtilisateur)
                    {
                        result = d;
                    }
                }
            }

            return result;
        }


    }
 }
