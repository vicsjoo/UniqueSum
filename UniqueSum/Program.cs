using System;
using System.Linq;

namespace UniqueSum
{
    class Program
    {
        [Flags]
        enum Pets
        { 
            None = 0,
            Dog = 1,
            Cat = 2,
            Duck = 4,
            Bunny = 8,
            Parrot = 16
        }
        static int maxPets = (Enum.GetValues(typeof(Pets)).Cast<int>().Max())*2;
        

        static void Main(string[] args)
        {
            UILines();
            Console.WriteLine(EveryPet());
            UILines();
            Console.WriteLine(String.Format("Please enter the sum of your desired pets, <{0}. Or enter H to have a list of all permutations.", maxPets));
            UILines();

            answerparser();

            Main(null);



        }

        private static void UILines()
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
        }

        static string EveryPet()
        {
            string tmp = "";
            foreach (Pets pet in Enum.GetValues(typeof(Pets)))
            {
                tmp += String.Format("{0} = {1}. ", pet, ((int)pet));
            }
            return tmp;
        }
   

        private static void AllPermutations()
        {
            UILines();
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
                    return;
                }
                int answer_int = Int32.Parse(answer);
                if (answer_int >= maxPets)
                {
                   throw new Exception();
                }
                                                  
               
                Pets myPets = (Pets)answer_int;
                UILines();
                Console.WriteLine(String.Format("{0} = {1}", myPets, answer_int));


            }
            catch (Exception)
            {
                UILines();
                Console.WriteLine(String.Format("The value must be a numerical sum, less than {0}.", maxPets )); ;
                UILines();
                answerparser();
            }
        }
    }
}
