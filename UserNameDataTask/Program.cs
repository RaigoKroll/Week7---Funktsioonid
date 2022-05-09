using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime;
            //programm küsib kasutajal sisestada numbrit 1-3;
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnime tagurpidi
            //kui kasutaja valib '2', siis kuvatakse kasutaja eesnime esimest tähte
            //kui kasutaja valib '3', siis kuvatakse kasutaja eesnime pikkust

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();

            Console.WriteLine("Sisesta number 1-3:");
            char userNumber = Convert.ToChar(Console.ReadLine());

            switch(userNumber)
            {
                case '1':
                    reverse(userName);
                break;
                case '2':
                    letter(userName);
                break;
                case '3':
                    length(userName);
                break;
            }

        }
        public static void reverse(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }
        public static void letter(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");
        }

        public static void length(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
        }
        
        
           
        
        
        

        
    
    }
}
