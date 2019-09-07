using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Legos.Minifigures.Parts
{
    class PirateTorso : Torso
    {
        public override bool ChestHair => true;

        public PirateTorso(HandType handType)
        {
            HandType = HandType;
            Shirt = "Froofy with ruffles";
        }

        public override void Flex()
        {
            Console.WriteLine("The pirate torse flexed swashbuckingly.");
            
        }

        public override void Fight()
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
