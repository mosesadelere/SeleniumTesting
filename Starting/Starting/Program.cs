using System;

namespace Starting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            string firstDogName = null;
            Console.Write("Enter frist dog name: ");
            firstDogName = Console.ReadLine();
            Dog firstDog = new Dog(firstDogName);

            Dog secondDog = new Dog();
            Console.Write("Enter the second dog name: ");
            string secondDogName = Console.ReadLine();
            secondDog.Name = secondDogName;

            Dog thirdDog = new Dog();

            Dog[] dogs = new Dog[] { firstDog, secondDog, thirdDog };

            foreach (Dog dog in dogs)
            {
                dog.Bark();
            }
            
           
        }
    }
}
