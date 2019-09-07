using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Legos.Minifigures.Parts
{
    class PirateTorso
    {
        public string Shirt { get; set; }
        public int NumberOfArms { get; set; }
        public HandType HandType { get; set; }
        public bool ChestHair => true;

        public PirateTorso(HandType HandType)
        {
            HandType = HandType;
            Shirt = "Froofy with ruffles";
        }

        public void Flex()
        {
            Console.WriteLine("The pirate torse flexed swashbuckingly.");
            
        }

        public void Fight()
        {
            Console.WriteLine("The pirate torse flexed swashbuckingly.");

        }
    }

    enum HandType
    {
        regular,
        Hook,
        None
    }
}
