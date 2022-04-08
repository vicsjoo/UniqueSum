using System;
using System.Linq;

namespace UniqueSum
{
    class Program
    {
        [Flags]
        enum Pets
        { 
            Dog = 1,
            Cat = 2,
            Duck = 4,
            Bunny = 8,
            Parrot = 16

        }
        static int maxPets = (Enum.GetValues(typeof(Pets)).Cast<int>().Max())*2;
        static string everyPet;

        static void Main(string[] args)
        {
            Get_everyPet_String();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(everyPet);
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(String.Format("Please enter the sum of your desired pets, <{0}. Or enter H to have a list of all permutations.", maxPets));


            answerparser();

            Main(null);



        }

        private static void Get_everyPet_String()
        {
            foreach (Pets pet in Enum.GetValues(typeof(Pets)))
            {
                everyPet += String.Format("{0} = {1}. ", pet, ((int)pet));
            }
        }

        private static void AllPermutations()
        {
            for (int i = 0; i <= maxPets-1; i++)
            {
                Console.WriteLine("{0,3} - {1:G}", i, (Pets)i);
            }
        }

        static void answerparser()
        {
            try
            {
                string answer = Console.ReadLine();
                if (answer == "H")
                {
                    AllPermutations();
                }
                int answer_int = Int32.Parse(answer);
                if (answer_int >= maxPets)
                {
                   throw new Exception();
                }
                if (answer_int == 0)
                {
                    Console.WriteLine("None");
                    return;
                }
           
                                   
               
                Pets myPets = (Pets)answer_int;
                Console.WriteLine(myPets);


            }
            catch (Exception)
            {

                Console.WriteLine(String.Format("The value must be a numerical sum, less than {0}.", maxPets )); ;
                answerparser();
            }
        }
    }
}
