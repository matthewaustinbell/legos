using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Legos.Minifigures.Parts
{
    class YodaHead: Head
    {
        public bool HasEars { get; private set; }

        public YodaHead()
        {
            Size = HeadSize.Small;
            HasEars = true;
        }


        public override void Talk()
        {
            Console.WriteLine("Talking head I am.");
        }

        public void Battle()
        {
            HasEars = false;
        }

    }
}
