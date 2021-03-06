using System;
using System.Collections.Generic;
using System.Text;

namespace Nettbutikk
{
    class Members
    {
        public List<Member> LedZeppelin, Daftpunk, Dad;
        public Instruments Instruments; 

        public Members()
        {
            Instruments = new Instruments();
            LedZeppelin = new List<Member>
            {
                new Member("James Patrick", "Jimmy Page", Instruments.Guitar),
                new Member("John Henry Bonham", "John Bonham", Instruments.Drumset),
                new Member("John Richard Baldwin", "John Paul Jones", Instruments.BassGuitar),
                new Member("Robert Anthony Plant","Robert Plant", Instruments.Vocals),

            };
            Daftpunk = new List<Member>
            {
                new Member("Thomas Bangalter","Brain Mann", Instruments.KeyBoard),
                new Member("Guy-Manuel de Homem-Christo", "Rocket Mann", Instruments.DJ),
            };
            Dad = new List<Member>
            {
                new Member("Jesper Binzer","jepz", Instruments.Vocals),
                new Member("Jacob Binzer","jacoh",Instruments.Guitar),
                new Member("stig Pedersen","SP", Instruments.BassGuitar),
                new Member("peter Jensen", "PJ",Instruments.Drumset),
            };
        }
    }
}
