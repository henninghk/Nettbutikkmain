using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nettbutikk
{
    class Bands
    {
        public List<Band> All;
        public Band LedZeppelin, DaftPunk, Dad;
        public Members Members;
        public Genres Genres;
        public Albums Albums;
        
        public Bands()
        {
            Genres = new Genres();
            Members = new Members();
            Albums = new Albums();
            
            LedZeppelin = new Band("Led Zeppelin", Members.LedZeppelin, "England", Genres.Rock, Albums.LedZeppelin);
            DaftPunk = new Band("Daft Punk", Members.Daftpunk, "France", Genres.Electric, Albums.DaftPunk);
            Dad = new Band("DAD", Members.Dad, "Denmark", Genres.Rock, Albums.Dad);
            All = new List<Band>
            {   
                LedZeppelin, 
                DaftPunk,
                Dad,
            };
        }
        public Band GetBand(string command)
            => All.FirstOrDefault(b => b.Name == command);
        public string MakeBandNamesStr()
        {
            var str = string.Empty;
            foreach (var band in All)
            {
                str += "  " + band.MakeNameStr();
            }
            return str;
        }
    }
}
