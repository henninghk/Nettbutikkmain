using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nettbutikk;

namespace Nettbutikk
{
    class Albums
    {
        public List<List<Album>> All;
        public Genres Genres;
        
        public List<Album> LedZeppelin { get; }

        private readonly Album _mothership;
        private readonly List<string> _mothershipSongs;

        private readonly Album _ledZeppelinAlbum;
        private readonly List<string> _ledZeppelinAlbumSongs;

        public List<Album> DaftPunk { get; }

        private readonly Album _homework;
        private List<string> _homeworkSongs;

        private readonly Album _Discovery;
        private List<String> _DiscoverySongs;

        public List<Album> Dad { get; }

        private readonly Album _Aprayerfortheloud;
        private List<String> _AprayerfortheloudSongs;

        public Albums()
        {
            Genres = new Genres();
            _mothershipSongs = new List<string>
            {
                "Good Times Bad Times",
                "Communication Breakdown",
                "Dazed and Confused",
                "Babe I'm Gonna Leave You",
                "Whole Lotta Love",
                "Ramble On",
                "Heartbreaker",
                "Immigrant Song",
                "Since I've Been Loving You",
                "Rock and Roll",
                "Black Dog",
                "When the Levee Breaks",
                "Stairway to Heaven",
            };
            _ledZeppelinAlbumSongs = new List<string>
            {
                "Good Times Bad Times",
                "Babe I'm Gonna Leave You",
                "You Shook Me",
                "Dazed and Confused",
                "Your Time Is Gonna Come",
                "Black Mountain Side",
                "Communication Breakdown",
                "I Can't Quit You Baby",
                "How Many More Times",
            };
            _homeworkSongs = new List<string>
            {
                "Da Funk",
                "Daftendirekt",
                "WDPK 83.7 FM",
                "Revolution 909",
                "Phœnix",
                "Fresh",
                "Around the World",
                "RollinAndScratchin",
                "Teachers",
                "HighFidelity",
                "Rock'n Roll",
                "Oh Yeah",
                "Burning",
                "In do silver club",
                "Alive",
                "Funk ad",
            };
            _DiscoverySongs = new List<string>
            {
                "One More Time",
                "Aerodynamic",
                "Digital Love",
                "Harder,Better, Faster Stronger",
                "Crescendolls",
                "NightVision",
                "Superheroes",
                "High Life",
                "Something About Us",
                "Vouager",
                "Veridis Quo",
                "Short Circuit",
                "Face to Face",
                "Too Long",
            };
            _AprayerfortheloudSongs = new List<String>
            {
                "Burning Star",
                "A prayer for the Loud",
                "Nothing Ever Change",
                "The Sky is made of blues",
                "The Real Me",
                "no doubt about it",
                "A dug for the Heart",
                "musical chairs",
                "Time is a train",
                "Happy Days in hell",
            };

            _mothership = new Album(_mothershipSongs, "Mothership",2007, Genres.Rock);
            _ledZeppelinAlbum = new Album(_ledZeppelinAlbumSongs, "Led Zeppelin", 1969, Genres.Rock);
            _homework = new Album(_homeworkSongs, "Home Work", 1997, Genres.Electric);
            _Discovery = new Album(_DiscoverySongs, "Discovery", 2001, Genres.Electric);
            _Aprayerfortheloud = new Album(_AprayerfortheloudSongs, " A Prayer For the Loud", 2019, Genres.Rock);
            
            LedZeppelin = new List<Album>
            {
                _mothership,
                _ledZeppelinAlbum,
            };

            DaftPunk = new List<Album> 
            {
                _homework,
                _Discovery,
            };

            Dad = new List<Album>
            {
                _Aprayerfortheloud,
            };

            All = new List<List<Album>>
            {
                LedZeppelin, DaftPunk, Dad,
            }.Select(A => A.OrderBy(a => a.ReleaseDate).ToList()).ToList();
        }
    }
}
