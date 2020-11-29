using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace rush_hour
{
    public class Voiture
    {
       //Couleur de la voiture
        public string _Couleur { get; set; }
        // Coordonnees de la voiture
        public int _X1 { get; set; }
      
        public int _Y1 { get; set; }

        public int _X2 { get; set; }
      
        public int _Y2 { get; set; }
        public int _Y3 { get; set; }
        public int _X3 { get; set; }

        public string _Position { get; set; }
        public bool _Bus { get; set; }


    }

}
