using JardinBotanique.ContenuJardin;

namespace JardinBotanique.Meteo
{
    public abstract class Intemperie
    {
        public string Nom { get; }
        public Intemperie(string nom)
        {
            Nom = nom;
        }

        public abstract void Impacter(Jardin jardin);
    }
}
