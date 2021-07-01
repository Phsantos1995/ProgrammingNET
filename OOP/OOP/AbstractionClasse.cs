using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class AbstractionClasse


    {
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("abstraion Zzz");
        }




    }


    class PIG1 : AbstractionClasse
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("abstraion dede");
        }
    }
}

