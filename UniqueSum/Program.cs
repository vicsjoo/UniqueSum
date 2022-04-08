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
        static int maxPets = Enum.GetValues(typeof(Pets)).Cast<int>().Max();


        static void Main(string[] args)
        {
            string nPets = " ";

            foreach (Pets pet in Enum.GetValues(typeof(Pets)))
            {
                nPets += String.Format("{0} = {1} ", pet, ((int)pet));
            }
            Console.WriteLine("Please type the sum of your desired pets. \n----------------------------------------");
            Console.WriteLine(nPets);

          //  AllPermutations();
            Console.WriteLine("---------------------------------------");
            answerparser();

            Main(null);



        }

        private static void AllPermutations()
        {
            for (int i = 0; i <= maxPets; i++)
            {
                Console.WriteLine("{0,3} - {1:G}", i, (Pets)i);
            }
        }

        static void answerparser()
        {
            try
            {
                int answer = Int32.Parse(Console.ReadLine());
                if (answer > maxPets)
                {
                   // throw new Exception();
                }
               
                Pets myPets = (Pets)answer;
                Console.WriteLine(myPets);


            }
            catch (Exception)
            {

                Console.WriteLine("The value must be a numerical sum");
                answerparser();
            }
        }
    }
}
