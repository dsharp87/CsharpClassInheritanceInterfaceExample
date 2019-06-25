using System;

namespace classes
{
    public class ChildHopper: Parental, ICanJump
    {
        public int timesJumped = 0;
        public int legCount;

        private int earCount = 0;

        public int EarCount
        {
            get { return earCount; }
            set { earCount = value; }
        }

        public ChildHopper(string aName): base(aName)
        {
            Random random = new Random();
            Order = random.Next(11,21);
        }

        public new void move()
        {
            distance += 10;
        }

        public string hop()
        {
            Random random = new Random();
            int hopDistance = random.Next(11,21);
            distance += hopDistance;
            return "I hopped " + hopDistance + " distance!";
        }

        string ICanJump.hop()
        {
            throw new NotImplementedException();
        }
    }
}