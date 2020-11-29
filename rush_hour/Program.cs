using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace rush_hour
{
    public class Program
    {
        //declaration des variables globales
        static void Main(string[] args)
        {
            //Variable Global
            List<Voiture> List_Voitures = new List<Voiture>();


            //presentation
            Console.WriteLine("Bienvenue sur rush hour !");
            Console.WriteLine("Appuyer sur [enter] pour commencer une partie :");
            Console.ReadLine();

            #region INITIALISATION DU PLATEAU 

            //initialisation du plateau
            //declaration de case gagnante
            int X_win = 5;
            int Y_win = 3;
            //ajout des vehicules sur le plateau
            Voiture Bleu = Init_game.CreationDesVehicules("B", 5, 0, 5, 1, "V",false);
            Voiture Rouge = Init_game.CreationDesVehicules("R", 0, 3, 1, 3, "H",false);
            Voiture Vert = Init_game.CreationDesVehicules("G", 5, 5, 4, 5, "H",false);
            Voiture Violet = Init_game.CreationDesVehicules("V", 0, 2, 1, 2, "H",false);
            Voiture Jaune = Init_game.CreationDesBus("Y", 3, 4, 3, 5,3,3 ,"V",true);
            

            List_Voitures.Add(Bleu);
            List_Voitures.Add(Rouge);
            List_Voitures.Add(Vert);
            List_Voitures.Add(Violet);
            List_Voitures.Add(Jaune);




            Console.WriteLine("Affichage des véhicules :");
            //Recupére l'affichage des ligne par ligne des voitures
            string[] Ligne = new string[6];
            Ligne[0] = Affichage.Affichage_Ligne_Plateau(List_Voitures, 0);
            Ligne[1] = Affichage.Affichage_Ligne_Plateau(List_Voitures, 1);
            Ligne[2] = Affichage.Affichage_Ligne_Plateau(List_Voitures, 2);
            Ligne[3] = Affichage.Affichage_Ligne_Plateau(List_Voitures, 3);
            Ligne[4] = Affichage.Affichage_Ligne_Plateau(List_Voitures, 4);
            Ligne[5] = Affichage.Affichage_Ligne_Plateau(List_Voitures, 5);
            //affiche ligne par ligne les voitures
            for (int i =5; i > -1; i--)
            {
                Console.WriteLine(Ligne[i]);
            }
            #endregion

            #region INTERACTION JOUEUR

            //tant que voiture rouge non presente sur case gagnante alors
            bool Victory = false;
            while (Victory == false)
            {
                //Demander au joueur une voiture à déplacer
                string VoitureSelect ="";
                bool ChoixValide = false;
                while (ChoixValide != true)
                {
                    Console.WriteLine("Choisir un véhicule à déplacer : (Exemple: B,V,R,Y...)");
                     VoitureSelect = Console.ReadLine();
                    foreach (Voiture Voiture_Item in List_Voitures)
                    {
                        if (VoitureSelect.ToUpper() == Voiture_Item._Couleur)
                        {
                            ChoixValide = true;
                        }
                    }
                }
              
                //On recherche la voiture selectionné  
                string Voiture_Position = "";
                foreach (Voiture Voiture_Item in List_Voitures)
                {
                    //recuperation du deplacement du véhicule choisi
                    if (Voiture_Item._Couleur == VoitureSelect.ToUpper())
                    {
                        Voiture_Position = Voiture_Item._Position;
                    }
                }
                //Demander le déplacement voulu selon la position du véhicule
                string ManoeuvreSelect;
                if (Voiture_Position == "H")
                {
                    while(true)
                    {
                        Console.WriteLine("Choisir une manoeuvre pour la voiture {0} : Gauche[G],Droite[D]", VoitureSelect);
                        ManoeuvreSelect = Console.ReadLine();
                        if(ManoeuvreSelect.ToUpper() == "G" || ManoeuvreSelect.ToUpper() == "D")
                        {
                            break;
                        }

                    }
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("Choisir une manoeuvre pour la voiture {0} : Haut[H],Bas[B]", VoitureSelect);
                        ManoeuvreSelect = Console.ReadLine();
                        if (ManoeuvreSelect.ToUpper() == "H" || ManoeuvreSelect.ToUpper() == "B")
                        {
                            break;
                        }
                    }
                }
                //Verification si colision ou non
                bool Colision = false;
                Colision = Control_Case.Controle_Colision(List_Voitures, ManoeuvreSelect, VoitureSelect);
                if(Colision == true)
                {
                    Console.WriteLine("BAAAAAAMMMM ACCIDENT !!!!!!! ");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Manoeuvre réussie !");
                    //deplacement du vehicule dans ce cas
                    //recherche du vehicule à deplacer
                    foreach (Voiture Voiture_Item in List_Voitures)
                    {
                        //recuperation du deplacement du véhicule choisi
                        if (Voiture_Item._Couleur == VoitureSelect.ToUpper())
                        {
                            //Deplacement du vehicule
                            Control_Case.DeplacerVoiture(Voiture_Item, ManoeuvreSelect,List_Voitures);
                        }
                    }
                }

                //affichage du plateau
                Console.WriteLine("Affichage des véhicules :");
                //Recupére l'affichage des ligne par ligne des voitures
                Ligne = new string[6];
                Ligne[0] = Affichage.Affichage_Ligne_Plateau(List_Voitures, 0);
                Ligne[1] = Affichage.Affichage_Ligne_Plateau(List_Voitures, 1);
                Ligne[2] = Affichage.Affichage_Ligne_Plateau(List_Voitures, 2);
                Ligne[3] = Affichage.Affichage_Ligne_Plateau(List_Voitures, 3);
                Ligne[4] = Affichage.Affichage_Ligne_Plateau(List_Voitures, 4);
                Ligne[5] = Affichage.Affichage_Ligne_Plateau(List_Voitures, 5);
                //affiche ligne par ligne les voitures
                for (int i = 5; i > -1; i--)
                {
                    Console.WriteLine(Ligne[i]);
                }
                Victory = Control_Case.VerifVictory(List_Voitures);
            }
            Console.WriteLine("BRAVO !!! Tu as Gagné !!!!!");

            #endregion








        }
    }
}
