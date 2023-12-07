using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Météo_2.Ressources
{
    public class Ville
    {
        public List<String> LsVille;
        public Ville()
        {
            LsVille = new List<string>();

            LsVille.Add("Aix-en-Provence");
            LsVille.Add("Amiens");
            LsVille.Add("Annecy");
            LsVille.Add("Angers");
            LsVille.Add("Antibes");
            LsVille.Add("Argenteuil");
            LsVille.Add("Asnières-sur-Seine");
            LsVille.Add("Aubervilliers");
            LsVille.Add("Avignon");
            LsVille.Add("Besançon");
            LsVille.Add("Bordeaux");
            LsVille.Add("Boulogne-Billancourt");
            LsVille.Add("Brest");
            LsVille.Add("Caen");
            LsVille.Add("Calais");
            LsVille.Add("Champigny-sur-Marne");
            LsVille.Add("Clermont-Ferrand");
            LsVille.Add("Colombes");
            LsVille.Add("Courbevoie");
            LsVille.Add("Créteil");
            LsVille.Add("Dijon");
            LsVille.Add("Dunkerque");
            LsVille.Add("Grenoble");
            LsVille.Add("La-Rochelle");
            LsVille.Add("Le-Havre");
            LsVille.Add("Le-Mans");
            LsVille.Add("Lille");
            LsVille.Add("Limoges");
            LsVille.Add("Lyon");
            LsVille.Add("Marseille");
            LsVille.Add("Metz");
            LsVille.Add("Montpellier");
            LsVille.Add("Montreuil");
            LsVille.Add("Mulhouse");
            LsVille.Add("Nancy");
            LsVille.Add("Nantes");
            LsVille.Add("Naves-Parmelan");
            LsVille.Add("Nice");
            LsVille.Add("Nîmes");
            LsVille.Add("Nanterre");
            LsVille.Add("Orléans");
            LsVille.Add("Paris");
            LsVille.Add("Pau");
            LsVille.Add("Perpignan");
            LsVille.Add("Poitiers");
            LsVille.Add("Reims");
            LsVille.Add("Rennes");
            LsVille.Add("Roubaix");
            LsVille.Add("Rouen");
            LsVille.Add("Rueil-Malmaison");
            LsVille.Add("Saint-Denis");
            LsVille.Add("Saint-Etienne");
            LsVille.Add("Saint-Maur-des-Fossés");
            LsVille.Add("Saint-Paul");
            LsVille.Add("Saint-Pierre");
            LsVille.Add("Strasbourg");
            LsVille.Add("Toulon");
            LsVille.Add("Toulouse");
            LsVille.Add("Tourcoing");
            LsVille.Add("Tours");
            LsVille.Add("Villeurbanne");
            LsVille.Add("Vitry-sur-Seine");
            LsVille.Add("Versailles");
        }

        public List<string> AjouterVille(String ville)
        {
            LsVille.Add(ville);
            return LsVille;
        }
    }
}
