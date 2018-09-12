using System;
using System.Collections.Generic;
using System.Text;

namespace Starting
{
    public class Dog
    {
        private string name;


        public string Name
        {
            //Console.WriteLine("Welcome!!");
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public Dog()
        {
                
        }

        public Dog(string name)
        {
            this.name = name;
        }

        public void Bark()
        {
            Console.WriteLine("{0} said Wow wow", name ?? "Unnamed dog");
        }
        

        
    }
}
