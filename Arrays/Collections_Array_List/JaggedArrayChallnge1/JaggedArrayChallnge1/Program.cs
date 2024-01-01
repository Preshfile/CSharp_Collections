namespace JaggedArrayChallenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a jagged array of three friends with family members each
            //let each friend introduce their family members

            string[][] friendsFamilyMembers = new string[][]
            {
                new string[]{"Ann", "Ugo", "Ola"},
                new string[]{"Sani", "Mamud", "Kuwai"},
                new string[]{"Ade", "Lanre"}
            };

            //introducing family members to the other
            //Console.WriteLine("Hi {0}, meet {1}, my sister.", friendsFamilyMembers[1][0], friendsFamilyMembers[0][0]);
            //Console.WriteLine("Hi {0}, meet {1}, my mom.", friendsFamilyMembers[2][1], friendsFamilyMembers[1][2]);
            //Console.WriteLine("Hi {0}, meet {1}, my bother.", friendsFamilyMembers[2][0], friendsFamilyMembers[0][2]);

            //Introducing each and all families
            for (int i = 0; i <  friendsFamilyMembers.Length; i++)
            {
                //Console.WriteLine("{0}: say hello", friendsFamilyMembers[i][0]);
                //Console.WriteLine("{0}: say hello", friendsFamilyMembers[i][1]);
                //Console.WriteLine("{0}: say hello", friendsFamilyMembers[i][2]);

                for (int j = 0; j < friendsFamilyMembers[i].Length; j++)
                {
                   // Console.WriteLine("{0}: says hello", friendsFamilyMembers[i][j]);

                    //Console.WriteLine(); //adding line break to each family member
                }
            }


            //another way
            string[] joesFamily = new string[] { "Gloria", "Benson", "Jude" };
            string[] amakasFamily = new string[] { "Ekene", "Nkechi", "Udoka" };
            string[] wendisFamily = new string[] { "Grace", "Lorri", "Sandra" };

            string[][] friendsFamily = new string[][]
           {
                joesFamily,
                amakasFamily,
                wendisFamily,
           };

            //introducing family members to the other
            Console.WriteLine("Hi {0}, meet {1}, my sister.", friendsFamily[1][0], friendsFamily[0][0]);
            Console.WriteLine("Hi {0}, meet {1}, my mom.", friendsFamily[2][1], friendsFamily[1][2]);
            Console.WriteLine("Hi {0}, meet {1}, my bother.", friendsFamily[2][0], friendsFamily[0][2]);

            //Introducing each and all families
            for (int i = 0; i < friendsFamily.Length; i++)
            {
                //Console.WriteLine("{0}: say hello", friendsFamily[i][0]);
                //Console.WriteLine("{0}: say hello", friendsFamily[i][1]);
                //Console.WriteLine("{0}: say hello", friendsFamily[i][2]);

                for (int j = 0; j < friendsFamily[i].Length; j++)
                {
                    // Console.WriteLine("{0}: says hello", friendsFamily[i][j]);

                    //Console.WriteLine(); //adding line break to each family member
                }
            }



            Console.ReadKey();
        }
    }
}