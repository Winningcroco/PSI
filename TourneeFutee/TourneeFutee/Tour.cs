using System.ComponentModel.DataAnnotations;

namespace TourneeFutee
{
    // Modélise une tournée dans le cadre du problème du voyageur de commerce
    public class Tour
    {
        // TODO : ajouter tous les attributs que vous jugerez pertinents 
        private float cost; // coût total de la tournée
        private List<(string source, string destination)> segments; // liste des trajets de la tournée
        private List<string> vertices;// séquence ordonnée des villes (pour la persistance)

        public Tour()
        {
            this.cost = float.PositiveInfinity;
            this.segments = new List<(string source, string destination)>();
            this.vertices = new List<string>();
        }
        public Tour(List<string> vertices,float cost)
        {
            this.cost = cost;
            this.vertices = new List<string>(vertices);
            this.segments = new List<(string source, string destination)>();
            for (int i = 0; i < vertices.Count - 1; i++)
            {
                string src = vertices[i];
                string dst = vertices[i + 1];
                this.segments.Add((src, dst));
            }
        }
        // propriétés

        // Coût total de la tournée
        public float Cost
        {
            get { return this.cost; }
            set { this.cost = value; }
            // TODO : implémenter
        }

        // Nombre de trajets dans la tournée
        public int NbSegments
        {
            get { return this.segments.Count; }  // TODO : implémenter
        }
        public List<string> Vertices
        {
            get { return this.vertices; }
        }


        // Renvoie vrai si la tournée contient le trajet `source`->`destination`
        public bool ContainsSegment((string source, string destination) segment)
        {
            return this.segments.Contains(segment);    // TODO : implémenter 
        }


        // Affiche les informations sur la tournée : coût total et trajets
        public void Print()
        {
            Console.WriteLine(ToString());// TODO : implémenter 
        }
        public void AddSegment(string source, string destination)
        {
            segments.Add((source, destination));
        }

        // TODO : ajouter toutes les méthodes que vous jugerez pertinentes 
        public override string ToString()
        {
            string result = "Coût total : " + cost + "\nTrajets :\n";
            foreach (var segment in segments)
            {
                result += segment.source + " -> " + segment.destination + "\n";
            }
            return result;
        }
    }
}
