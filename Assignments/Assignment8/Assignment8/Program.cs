using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class Program
    {
        static void Main(string[] args)
        {
            GermanShepard dog = new GermanShepard();
            dog.Name = "Max";
            dog.Origin = Country.Bosnia;      
            dog.BirthDate = new DateTime(2017, 10, 10);
            dog.Gender = GenderType.Male;
            dog.Weight = 32.54;
            dog.Size = SizeType.Big;

            dog.Output();


            

        }
    }
    class Animal
    {
        string name = "";
        DateTime birthDate = new DateTime();
        Country origin = new Country();

        public string Name { get { return name; } set { name = value; } }
        public DateTime BirthDate { get { return birthDate; } set { birthDate = value; } }
        public Country Origin { get { return origin; } set { origin = value; } }


    }

    interface Dog
    {
        void Eat();
        void Drink();
        void Sit();
    }

    class GermanShepard : Animal, Dog
    {
        GenderType gender = new GenderType();
        double weight = 0;
        bool isSecurityGuard = false;
        Training trainable = new Training();
        SizeType size = new SizeType();

        public GenderType Gender { get{return gender;} set{gender= value;} }
        public double Weight { get { return weight; } set { weight = value; } }
        public bool IsSecurityGuard { get { return isSecurityGuard; } set { isSecurityGuard = value; } }
        public Training Trainable { get { return trainable; } set { trainable = value; } }
        public SizeType Size { get { return size; } set { size = value; } }



        public void Eat()
        { Console.WriteLine("Dog is eating."); }
        public void Eat(string name)
        {Console.WriteLine($"{name} is eating.");}

        public void Drink()
        { Console.WriteLine("Dog is drinking."); }
        public void Drink(string name)
        {Console.WriteLine($"{name} is drinking.");}

        public void Sit()
        { Console.WriteLine("Dog is sitting."); }
        public void Sit(string name)
        {Console.WriteLine($"{name} is sitting."); }

        public void Output()
        {
            Console.WriteLine($"The dog's name is {Name}, from {Origin}, and it was born on {BirthDate.ToShortDateString()}.\n{Name} is a {Gender} and weighs {Weight} kilograms and its size is {Size}.");
            Sit();
            Eat(Name);
            Drink(Name);


        }

        
    }

    enum Country
    {
        Austria,
        England,
        Bosnia,
        USA,
        China,
        Thailand,
        Morocco,
        India,
        Japan,
        Spain,
        Argentina
    }

    enum GenderType
    {
        Male,
        Female
    }

    enum Training
    {
        Easy,
        Medium,
        Hard
    }

    enum SizeType
    {
        Tiny,
        Small,
        Mediumsized,
        Big,
        Huge

    }
    
        
}
