using System;


namespace ConsoleApp4
{
    public enum LivingEnviromwnt
    {
        Forest,
        Mountains,
        Sea,
        Dezert
    }
    public enum TypeOfAnimal
    {
        Predator,
        Hybrid,
        Herbivor
    }
    public enum Сontinent
    {
        Africa,
        Eurasia,
        NorthAmerica,
        SouthAmerica,
        Australia
    }
    public enum Ability
    {
        Can,
        CanNot
    }
    class Animal
    {
        private int age;
        private string name;
        private int numberOfLimbs;
        private Сontinent continent;
        private TypeOfAnimal typeOfAnimal;
        private LivingEnviromwnt livingEnviromwnt;
       

        public Animal()
        {
           

        }
        public Animal(string name,int age, int numberOfLimbs,Сontinent continent, TypeOfAnimal typeOfAnimal, LivingEnviromwnt livingEnviromwnt)
        {
            this.name=name;
            this.age=age;
            this.numberOfLimbs=numberOfLimbs;
            this.continent =continent;
            this.livingEnviromwnt = livingEnviromwnt;
            this.typeOfAnimal = typeOfAnimal;
            Console.WriteLine("Constructor: "+this.name + " " + this.age + " " + this.numberOfLimbs + " " + this.continent + " " + this.livingEnviromwnt + " " + this.typeOfAnimal);
        }

        

        public int Age
        {
            set { age = value; }
            get { return age; }
        }
        public int NumberOfLimbs
        {
            set { numberOfLimbs = value; }
            get { return numberOfLimbs; }
        }
     

        public string Name
        {
            get { return name; }
            set { name = value;}
        }
        public Сontinent Continent
        {
            get { return continent; }
            set { continent = value; }
        }
        public TypeOfAnimal TypeOfAnimal
        {
            get { return typeOfAnimal; }
            set { typeOfAnimal = value; }
        }
        public LivingEnviromwnt LivingEnviromwnt
        {
            get { return livingEnviromwnt; }
            set { livingEnviromwnt = value; }
        }
        public static bool operator !=(Animal firstAnimal, Animal secondAnimal)
        {
            return firstAnimal.Equals(secondAnimal);
        }
        public static bool operator ==(Animal firstAnimal, Animal secondAnimal)
        {
            return firstAnimal.Equals(secondAnimal);
        }
        public void GetSound(Ability ability)
        {
            if(ability == 0)
            {
                Console.WriteLine(name + " can get sound");
                
            }
            else if((int)ability==1)
            {
                Console.WriteLine(name + " can not get sound");
            }
        }
        public void CanFly(Ability ability)
        {
            if (ability == 0)
            {
                Console.WriteLine(name + " can fly");

            }
            else if ((int)ability == 1)
            {
                Console.WriteLine(name + " can not fly");
            }

        }
        public void CanSwim(Ability ability)
        {

            if (ability == 0)
            {
                Console.WriteLine(name + " can swim");

            }
            else if ((int)ability == 1)
            {
                Console.WriteLine(name + " can can not swim");
            }
        }
        public void ExistsTail(Ability ability)
        {
            if (ability == 0)
            {
                Console.WriteLine(name + " has a tail");

            }
            else if ((int)ability == 1)
            {
                Console.WriteLine(name + " has not a tail");
            }
        }




    }
    class Program
    {
        static void Main(string[] args)
        {
            bool equals;
            Animal bear=new Animal("whiteBear",10, 4, Сontinent.NorthAmerica, TypeOfAnimal.Hybrid, LivingEnviromwnt.Forest);
            Animal whale = new Animal("blueWhale",30,4, Сontinent.Australia, TypeOfAnimal.Hybrid, LivingEnviromwnt.Sea);
            
            bear.Age = 11;
            equals = bear.Name == whale.Name;
            bear.GetSound(Ability.CanNot);

            Console.WriteLine("equals: " + equals);
           
        }
    }
}