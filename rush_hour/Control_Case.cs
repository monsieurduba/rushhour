using System;
using System.Collections.Generic;
using System.Text;

namespace rush_hour
{
    public class Control_Case
    {
        public static bool Controle_Colision(List<Voiture> ListVoitures, string Deplacement, string VoitureSelect)
        {
            int Voiture_X1 = 0;
            int Voiture_X2 = 0;
            int Voiture_Y1 = 0;
            int Voiture_Y2 = 0;
            //recuperer coordonné voiture selectionné
            foreach (Voiture Voiture_Item in ListVoitures)
            {
                //recuperation du deplacement du véhicule choisi
                if (Voiture_Item._Couleur == VoitureSelect)
                {
                    Voiture_X1 = Voiture_Item._X1;
                    Voiture_X2 = Voiture_Item._X2;
                    Voiture_Y1 = Voiture_Item._Y1;
                    Voiture_Y2 = Voiture_Item._Y2;
                }
            }
            // On recupere les nouveaux coordonnées du vehicule
            if (Deplacement == "H")
            {
                Voiture_Y1 = Voiture_Y1 + 1;
                Voiture_Y2 = Voiture_Y2 + 1;
            }
            if (Deplacement == "B")
            {
                Voiture_Y1 = Voiture_Y1 - 1;
                Voiture_Y2 = Voiture_Y2 - 1;
            }
            if (Deplacement == "G")
            {
                Voiture_X1 = Voiture_X1 - 1;
                Voiture_X2 = Voiture_X2 - 1;
            }
            if (Deplacement == "D")
            {
                Voiture_X1 = Voiture_X1 + 1;
                Voiture_X2 = Voiture_X2 + 1;
            }
            //on verifie si un autre vehicule n'a pas ces coordonnées
            bool Colision = false;

            //on verifie si la voiture n'a pas tappé un mur

            if (Voiture_X1 > 5)
            {
                Colision = true;
            }
            if (Voiture_X2 > 5)
            {
                Colision = true;
            }
            if (Voiture_Y1 > 5)
            {
                Colision = true;
            }
            if (Voiture_Y2 > 5)
            {
                Colision = true;
            }
          
            if (Voiture_X1 < 0)
            {
                Colision = true;
            }
            if (Voiture_X2 < 0)
            {
                Colision = true;
            }
            if (Voiture_Y1 < 0)
            {
                Colision = true;
            }
            if (Voiture_Y2 < 0)
            {
                Colision = true;
            }
            if (Voiture_X1 > 5 && Voiture_Y1 == 3)
            {
                Colision = false;
            }

            foreach (Voiture Voiture_Item in ListVoitures)
            {
                //recuperation du deplacement du véhicule choisi
                if (Voiture_Item._Y1 == Voiture_Y1 && Voiture_Item._X1 == Voiture_X1 && Voiture_Item._Couleur != VoitureSelect)
                {
                    Colision = true;
                    break;
                }
                if (Voiture_Item._Y2 == Voiture_Y2 && Voiture_Item._X2 == Voiture_X2 && Voiture_Item._Couleur != VoitureSelect)
                {
                    Colision = true;
                    break;
                }
            }
            return Colision;

        }

        public static void DeplacerVoiture(Voiture Voiture, string Deplacement, List<Voiture> ListVoitures)
        {
            if (Deplacement == "H")
            {
                Voiture._Y1 = Voiture._Y1 + 1;
                Voiture._Y2 = Voiture._Y2 + 1;
            }
            if (Deplacement == "B")
            {
                Voiture._Y1 = Voiture._Y1 - 1;
                Voiture._Y2 = Voiture._Y2 - 1;
            }
            if (Deplacement == "G")
            {
                Voiture._X1 = Voiture._X1 - 1;
                Voiture._X2 = Voiture._X2 - 1;
            }
            if (Deplacement == "D")
            {
                Voiture._X1 = Voiture._X1 + 1;
                Voiture._X2 = Voiture._X2 + 1;
            }

            foreach (Voiture Voiture_Item in ListVoitures)
            {
                //recuperation du deplacement du véhicule choisi
                if (Voiture_Item._Couleur == Voiture._Couleur)
                {
                    Voiture_Item._X1 = Voiture._X1;
                    Voiture_Item._X2 = Voiture._X2;
                    Voiture_Item._Y1 = Voiture._Y1;
                    Voiture_Item._Y1 = Voiture._Y1;
                }
            }
        }
            public static bool VerifVictory(List<Voiture> ListVoitures)
            {

                bool Victoire = false;
                foreach (Voiture Voiture_Item in ListVoitures)
                {
                    //recuperation du deplacement du véhicule choisi
                    if (Voiture_Item._Couleur == "R")
                    {
                        if (Voiture_Item._X2 == 5 && Voiture_Item._Y2 == 3)
                        {
                            Victoire = true;
                        }
                    }
                }
                return Victoire;
            }
        }
    
}
