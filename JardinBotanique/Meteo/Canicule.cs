using JardinBotanique.ContenuJardin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JardinBotanique.Meteo
{
    // TODO: Corriger l'erreur puis compléter le code pour répoudre à l'exigence suivante :
    //       En cas d'épisode de canicule, chaque plante consomme le double de son besoin quotidien en eau.
    public class Canicule : Intemperie
    {
        public Canicule() : base("Canicule")
        {

        }
    }
}
