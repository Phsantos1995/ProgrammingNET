using   System;


namespace ConsoleApp2
{ 
    class Program
    {


        private string name;
        private int idade;

        public Program()
        {
            Console.WriteLine("Foi criando um objeto pessoa");

        }









       





        public class Pessoa : Program
        {
            public string matricula;

            public Pessoa()
            {
                Console.WriteLine("jiejdiwejdowe");
            }

        }

        







        
        static void Main(string[] args)
        {

            Program p = new Program();
            p.name = "deded";
            p.idade = 30;

            Console.WriteLine("Resposta:", p.name, p.idade); ;

            Pessoa pess = new Pessoa();

            pess.name = "PP";
            pess.idade = 3123;

            pess.matricula = "212323";

            Console.WriteLine(pess.name, pess.idade, pess.matricula);



        }
    }
}
