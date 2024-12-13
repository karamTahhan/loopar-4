using System; 

namespace loopar_4
{
    class program
    {
        static void Main(string[] args)
        {
            string password;

            do
            {
                Console.WriteLine("ange lösenord");
                password = Console.ReadLine();


            } while (password != "hemligt");
            Console.WriteLine("rätt lösenord");


        }
    }
}