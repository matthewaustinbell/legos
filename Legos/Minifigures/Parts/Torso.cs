using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts
{
    class torso
    {
        public HandType HandType { get; set; }
        public abstract bool ChestHair { get; }
        public string Shirt { get; set; }
        public int NumberOfArms { get; set; }
    }
}
