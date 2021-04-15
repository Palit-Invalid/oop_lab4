using System;

namespace oop_lab4
{
    class building
    {
        private string name;
        public double height;

        
        public building()
        {
            name = "default_name";

        }
        public building(string name, double height)
        {
            this.name = name;
            this.height = height;
        }
        public string Name
        {
            get 
            {
                return name; 
            }
            set
            {
                name = value;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public void printAll()
        {
            Console.Write("Name\t" + name + "\n");
            Console.Write("Height\t" + height + "\n");
        }
        public double foundation()
        {
            return height*0.03;
        }
    }

    class office:building
    {
        int num_floor;

        public office(string name, double height, int num_floor):base(name, height)
        {
            this.num_floor = num_floor;
        }
        public new double foundation()
        {
            if (num_floor > 10)
            {
                return height*0.03 + 0.005*num_floor;
            }
            else
            {
                return height*0.03;
            }
            
        }
    }

    class factory:building
    {
        double weight;

        public factory():base()
        {
            
        }
        public factory(string name, double height, double weight):base(name, height)
        {
            this.weight = weight;
        }
        public new double foundation()
        {
            return height*0.03 + 0.000002*weight;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            factory fac = new factory("name", 10, 1000);
            Console.WriteLine("Name factory: " + fac.Name);
            Console.WriteLine("Weight factory: " + fac.Height);
            Console.WriteLine("Foundation: " + fac.foundation());

            office off = new office("name", 10, 15);
            Console.WriteLine("Name office: " + off.Name);
            Console.WriteLine("Weight office: " + off.Height);
            Console.WriteLine("Foundation: " + off.foundation());
        }
    }
}
