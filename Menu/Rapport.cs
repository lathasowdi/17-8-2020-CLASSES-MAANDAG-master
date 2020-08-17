using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Rapport
    {
        List<int> punten = new List<int>();
        public Dictionary<string, List<int>> rapportList { get; set; } = new Dictionary<string, List<int>>();

        public Rapport()
        {
            rapportList.Add("Nederlands", new List<int>());
            rapportList.Add("Economie", new List<int>());
            rapportList.Add("Wiskunde", new List<int>());
            rapportList.Add("Informatica", new List<int>());
            rapportList.Add("Engels", new List<int>());
            rapportList.Add("Wetenscap", new List<int>());
            rapportList.Add("Frans", new List<int>());
            rapportList.Add("sport", new List<int>());
        }
    }
}
