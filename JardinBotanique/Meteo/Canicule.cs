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
        // <summary>
        // Impacter le jardin pendant une canicule.
        // </summary>
        // <param name="jardin">Le jardin à impacter.</param>
        public override void Impacter(Jardin jardin)
        {
            if (jardin == null) throw new ArgumentNullException(nameof(jardin));

            foreach(Plante plante in jardin.Plantes)
            {
                jardin.Ressources.Eau -= plante.BesoinEauParJour * 2; // Double le besoin en eau de chaque plante
            }
        }
    }
}
