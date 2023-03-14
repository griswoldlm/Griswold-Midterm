using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class VWGolf : RaceCar
    { 
        public VWGolf()
        {
            Name = "VW Golf";
            TopSpeed = 90;
        }


        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} is not kaputt and revs its engine!");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name}'s brake fluid leaked all over the track. Look out!");
            base.Brake();
        }

    }
}
