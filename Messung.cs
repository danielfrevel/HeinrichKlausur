using System;
namespace hs
{
    class Messung
    {
        public int Puls { get; set; }
        public int Warnung { get; set; }

        public Messung(int puls, int warnung)
        {

            Puls = puls;
            Warnung = warnung;
        }
    }


    class MessungManager
    {

        public MessungManager()
        {

        }
        public void addMessung(Messung messung)
        {
            if (messung.Puls > 100)
                Console.WriteLine($"Warnung: Art: PulsWarnung{messung.Warnung}; Prio=3");
            if (messung.Puls > 100)
                Console.WriteLine($"Warnung: Art: PulsWarnung{messung.Warnung}; Prio=2");
            if (messung.Puls > 100)
                Console.WriteLine($"Warnung: Art: PulsWarnung{messung.Warnung}; Prio=1");

        }
    }

}

