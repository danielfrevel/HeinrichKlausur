using System;
namespace hs
{
    class Messung
    {
        public int Puls { get; set; }
        public int Warnung { get; set; }
        public int Blutdruck { get; set; }
        public int Temperatur { get; set; }


        public Messung(int puls, int warnung, int temp, int blutdruck)
        {

            Puls = puls;
            Warnung = warnung;
            Temperatur = temp;
            Blutdruck = blutdruck;
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
            if (messung.Puls > 150)
                Console.WriteLine($"Warnung: Art: PulsWarnung{messung.Warnung}; Prio=2");
            if (messung.Puls > 200)
                Console.WriteLine($"Warnung: Art: PulsWarnung{messung.Warnung}; Prio=1");

            if (messung.Blutdruck > 100)
                Console.WriteLine($"Warnung: Art: BlutdruckWarnung{messung.Warnung}; Prio=3");
            if (messung.Blutdruck > 150)
                Console.WriteLine($"Warnung: Art: BlutdruckWarnung{messung.Warnung}; Prio=2");

            if (messung.Blutdruck > 200)
                Console.WriteLine($"Warnung: Art: BlutdruckWarnung{messung.Warnung}; Prio=1");


            if (messung.Temperatur > 100)
                Console.WriteLine($"Warnung: Art: TemperaturWarnung{messung.Warnung}; Prio=3");
            if (messung.Temperatur > 150)
                Console.WriteLine($"Warnung: Art: TemperaturWarnung{messung.Warnung}; Prio=2");

            if (messung.Temperatur > 200)
                Console.WriteLine($"Warnung: Art: TemperaturWarnung{messung.Warnung}; Prio=1");


        }
    }

}

