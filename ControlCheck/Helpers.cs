using System;
using System.Collections.Generic;
using System.Text;

namespace ControlCheck
{
    class Helpers
    {

        public List<Stanowiska> WygenerowanieDanychStanowiska()
        {
            var stanowiska = new List<Stanowiska>();

            var stanowisko1 = new Stanowiska()
            {
                Id = 1,
                NazwaStanowiska = "Junior",
                ZarobkiOd = 1000,
                ZarobkiDo = 4000
            };
            stanowiska.Add(stanowisko1);

            var stanowisko2 = new Stanowiska()
            {
                Id = 2,
                NazwaStanowiska = "Middle",
                ZarobkiOd = 4001,
                ZarobkiDo = 6000
            };
            stanowiska.Add(stanowisko2);

            var stanowisko3 = new Stanowiska()
            {
                Id = 3,
                NazwaStanowiska = "Senior",
                ZarobkiOd = 6001,
                ZarobkiDo = 9000
            };
            stanowiska.Add(stanowisko3);

            return stanowiska;
        }


        public void WygenerowanieDanycPracownika()
        {
            var person = new Bogus.Person();

            person.();
        }


    }
}
