using System;

namespace OOP
{
    class Program:Heranca// Herança
    {
        static void Main(string[] args)
        {

            Animal my = new Animal(); //polymorphism
            Animal myPig = new Pig(); //polymorphism
            Animal myDog = new Dog(); //polymorphism


            PIG1 py = new PIG1();//abstraion
            py.animalSound();// void chama abstraion
            py.sleep(); // void chama abstraion



            my.AnimalSound();// void chama polymorphism
            myPig.AnimalSound();// void chama polymorphism
            myDog.AnimalSound();// void chama polymorphism



            PIG2 dig= new PIG2();//cria OO para interface

            dig.animalSound();
            Console.WriteLine(dig);









            Pessoa p = new Pessoa();//Objetivo de Orientacao

            Heranca u = new Heranca();//herança cria um objetivo

            u.F();


            Console.WriteLine(u);//resultado herança




           
            
               
            p.falar(); // resultado objetivo de orientacao
            p.andar(10);// resultado objetivo de orientacao
            Console.WriteLine("Hello World!"+p); // resultado objetivo de orientacao teste funciona "Hello world"











        }
    }
}
