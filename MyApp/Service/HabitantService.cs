using MyApp.Model;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MyApp.Service
{
    public class HabitantService
    {
        private DemandeALutilisateur _DemandeALutilisateur;
        private CommuneService _CommuneService;
        private List<Habitants> ListeHabitants = new List<Habitants>();

        public HabitantService(DemandeALutilisateur demandeALutilisateur, CommuneService communeService)
        {
            _DemandeALutilisateur = demandeALutilisateur;
            _CommuneService = communeService;
        }

        public void AfficheHabitans()
        {
            foreach (Habitants h in ListeHabitants)
            {
                Console.WriteLine(h.nom);
                Console.WriteLine("Les communes: ");

                if (h.Communes != null)
                {
                    foreach (Commune c in h.Communes)
                    {
                        Console.WriteLine(c.Nom);
                    }
                }
            }
        }

        public Habitants CreatHabitants()
        {
            Habitants h = new Habitants();

            h.nom = _DemandeALutilisateur.saisieNom("Nom de l'habitant :");
            h.age = _DemandeALutilisateur.saisieEntier("Quel as tu :");
           
            return h;
        }

    }
}
