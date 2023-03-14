using System;

namespace RaceTrack.RaceTrack.Cars
{
    public abstract class RaceCar
    {
        protected RaceCar()
        {
            Position = 0;
        }

        public string Name { get; set; }
        public int Position { get; set; }
        public int TopSpeed { get; set; }

        public void Accelerate(int driverSkill)
        {
            // applying a random amount of variability to affect the outcome
            var random = new Random();
            var randomRange = random.Next(-1, 20);
            Position += driverSkill * TopSpeed * randomRange;

            if (Position > 0)
                Console.WriteLine($"{Name} moves ahead to {Position}!");
            else if (Position < 0)
                Console.WriteLine($"{Name} moves backwards to {Position}!??");
            else
                Console.WriteLine($"{Name} has stopped!?");
        }

        public abstract void StartEngine();

        public void SmackTalking(int drivingSkills)
        {
            drivingSkills = (int)(TopSpeed * .75);

            if (drivingSkills <= 23)
                Console.WriteLine($"{Name} - I'll catch up!");
            else if (drivingSkills >= 24)
                Console.WriteLine($"{Name} - I WILL BE THE WINNER!");

        }


        public virtual void Brake()
        {
            Console.WriteLine($"The {Name} ends in position {Position}!");
        }


    }
} 