using System;
using System.Collections.Generic;
using System.Text;

namespace rush_hour
{
    public class Init_game
    {
       
        public static Voiture CreationDesVehicules(string Couleur,int X1,int Y1,int X2,int Y2,string Position,bool bus)
        {
            //initialisation de la voiture bleu
            Voiture voiture = new Voiture();
            voiture._Couleur = Couleur;
            voiture._X1 = X1;
            voiture._Y1 = Y1;
            voiture._X2 = X2;
            voiture._Y2 = Y2;
            voiture._Position = Position;
            voiture._Bus = bus;

            return voiture;
        }
        public static Voiture CreationDesBus(string Couleur, int X1, int Y1, int X2, int Y2,int X3,int Y3, string Position,bool bus)
        {
            //initialisation de la voiture bleu
            Voiture Bus = new Voiture();
            Bus._Couleur = Couleur;
            Bus._X1 = X1;
            Bus._Y1 = Y1;
            Bus._X2 = X2;
            Bus._Y2 = Y2;
            Bus._X3 = X3;
            Bus._Y3 = Y3;
            Bus._Position = Position;
            Bus._Bus = bus;
            return Bus;
        }
    }
}
