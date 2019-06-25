using System;

namespace classes
{
    public class Parental
    {
        
        static int parentCount = 0;
        public string name;

        private int order;

        public int distance = 0;

        public Parental(string name)
        {
            this.name = name;
            Random random = new Random();
            order = random.Next(1,11);
            parentCount++;
        }

        public void move()
        {
            distance += 5;
        }

        public void move(int amount)
        {
            distance += amount;
        }

        public int Order
        {
            get {return order;}
            set 
            { 
                if(value >= 1 && value <= 10)
                {
                    order = value;
                }
                else
                {
                    Random random = new Random();
                    order = random.Next(1,11); 
                }
            }
        }













    }
}