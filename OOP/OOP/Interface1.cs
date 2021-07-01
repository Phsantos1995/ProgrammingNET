using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    interface Interface1
    {

        void animalSound();

    }
     
     class PIG2 : Interface1
    {
        public void animalSound()
        {
            Console.WriteLine("dedede Interface1");
        }
    }



}
