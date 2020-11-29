using System;
using System.Collections.Generic;
using System.Text;

namespace rush_hour
{
    public class Affichage
    {
        public static string Affichage_Ligne_Plateau(List<Voiture> ListVoiture, int NumeroLigne)
        {
            string ResultatLigne = "";
            string[] CaseLigneTab = new string[6];
            foreach (Voiture Voiture_Item in ListVoiture)
            {
                try
                {
                    if (Voiture_Item._Y1 == NumeroLigne)
                    {
                        CaseLigneTab[Voiture_Item._X1] = Voiture_Item._Couleur;
                    }
                    if (Voiture_Item._Y2 == NumeroLigne)
                    {
                        CaseLigneTab[Voiture_Item._X2] = Voiture_Item._Couleur;
                    }
                    if (Voiture_Item._Y3 == NumeroLigne && Voiture_Item._Bus == true)
                    {
                        CaseLigneTab[Voiture_Item._X3] = Voiture_Item._Couleur;
                    }
                }
                catch
                {
                    // victoire hors champ
                }
            }
      
            foreach (string CaseLigne in CaseLigneTab)
            {
                if(CaseLigne != "")
                {
                    ResultatLigne = ResultatLigne + CaseLigne;
                }
                if(CaseLigne == null)
                {
                    ResultatLigne = ResultatLigne + "." ;
                }
            }
            if(NumeroLigne == 3)
            {
                ResultatLigne = ResultatLigne + ".";
            }
            return ResultatLigne;
        }
    }
}
