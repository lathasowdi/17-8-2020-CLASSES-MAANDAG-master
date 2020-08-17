using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Televisie
    {
        int volume = 0;
        public List<string> kanaalLijst { get; set; } = new List<string>();
        public int kanaalnum { get; set; } = 0;

        public Televisie()
        {
            kanaalLijst.Add("M");
            kanaalLijst.Add("Zen");
            kanaalLijst.Add("Karavit");
            kanaalLijst.Add("BBC");
            kanaalLijst.Add("FOX");
            kanaalLijst.Add("CNN");
            kanaalLijst.Add("DISCOVERY");
            kanaalLijst.Add("HBO");
        }

        public void kanaalincrease()
        {
            kanaalnum++;
            if (kanaalnum >= kanaalLijst.Count)
            {
                kanaalnum = 0;
            }
        }
        public override string ToString()
        {

            return $"Volume: {volume} Kanaal: {Kanaal()}";
        }
        public void kanaaldecrease()
        {
            kanaalnum--;
            if (kanaalnum < 0)
            {
                kanaalnum = kanaalLijst.Count - 1;
            }
        }
        public string Kanaal()
        {
            return kanaalLijst[kanaalnum];
        }
       
        public void Volumedecrease()
        {
            volume--;
            if (volume < 0)
            {
                volume = 15;
            }
        }
        public void Volumeincrease()
        {
            volume++;
            if (volume > 15)
            {
                volume = 0;
            }
        }

    }
}
