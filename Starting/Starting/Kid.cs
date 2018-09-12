using System;
using System.Collections.Generic;
using System.Text;

namespace Starting
{
    class Kid
    {

        public void CallTheDog(Dog dog)
        {
            Console.WriteLine("Come, {0} !", dog.Name);
        }

        public void WagTheDog(Dog dog)
        {
            dog.Bark();
        }
    }
}
