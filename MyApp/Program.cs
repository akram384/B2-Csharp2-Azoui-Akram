using System;
using System.Collections.Generic;
using System.Globalization;
using MyApp.Service;
namespace MyApp
{
    class Program
    {
            private static DemandeALutilisateur _DemandeALutilisateur = new DemandeALutilisateur();
        static void Main(string[] args)
        {
            DemandeALutilisateur _DemandeALutilisateur = new DemandeALutilisateur();
            DepartementService _DepartementService = new DepartementService(_DemandeALutilisateur);
            CommuneService _CommuneService = new CommuneService(_DemandeALutilisateur,_DepartementService);
            HabitantService _HabitanService = new HabitantService(_DemandeALutilisateur, _CommuneService);



            List<Commune> listcommune = new List<Commune>();

            while (true)
            {
                string choixUtilisateur = MenuUtilisateur();

                if (choixUtilisateur == "1")
                {
                    _HabitanService.CreatHabitants();
                }
                else if (choixUtilisateur == "2")
                {
                    _HabitanService.AfficheHabitans();
                }
                else if (choixUtilisateur == "3")
                {
                    // exercice : permettre de créer une commune
                    _CommuneService.CreeCommune();
                }
                else if (choixUtilisateur == "4")
                {

                }
                else if (choixUtilisateur == "5")
                {
                    _DepartementService.CreeDepartement();
                    // exercice : afficher la liste des
                }
                else if (choixUtilisateur == "Q")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Je n'ai pas compris");
                }
            }
        }

        private static string MenuUtilisateur()
        {
            Console.WriteLine("Bienvenue dans l'appli de gestion des villes");
            Console.WriteLine("Que voulez-vous faire ?");
            Console.WriteLine("1. Créer une nouvelles ville");
            Console.WriteLine("2. Afficher l'ensemble des villes");
            Console.WriteLine("3. Afficher le nombre total d'habitants");
            
            Console.WriteLine("Q. Quitter");
            string choixUtilisateur = _DemandeALutilisateur.saisieNom("");
            return choixUtilisateur;
        }




        public static void affiche(List<Commune> listcommunes)
        {
            Console.WriteLine("Liste des communes créées:");
            foreach(Commune c in listcommunes)
            {
                var culture = CultureInfo.GetCultureInfo("en-GB");
                string nb = string.Format(culture,"{0:n0}", c.NbHab);
                nb = nb.Replace(",", ".");
                string message_p1 = "Nom: " + c.Nom + " Code Postal: " + c.CodePost;
                string message_p2 = "Nombre d'habitants: " + nb;
                Console.WriteLine(message_p1);
                Console.WriteLine(message_p2);
            }
        }
        
        public static void calculNbtotalHabs(List<Commune> listcommunes)
        {
            int Nbtot = 0;
            foreach (Commune c in listcommunes)
            {
                Nbtot = Nbtot + c.NbHab;
            }
            var culture = CultureInfo.GetCultureInfo("en-GB");
            string nb = string.Format(culture,"{0:n0}", Nbtot);
            nb = nb.Replace(",", ".");
            string message = "Nombre total d'habitants: " + nb;        
            Console.WriteLine(message);
        }
    }
}
