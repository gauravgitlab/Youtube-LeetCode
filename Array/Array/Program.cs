using System;
using System.Text;

namespace Array 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // DVD
            DVD[] dvdCollection = new DVD[15];

            // range 0 to N-1 ( where n is 15)

            // if we put avengers in 8th place
            DVD avengersDvD = new DVD("The Avengers", 2012, "Joss Whedon");
            DVD incrediblesDVD = new DVD("The incredibles", 2004, "Brad Bird");
            DVD findingDoryDVD = new DVD("Finding Dory", 2016, "Andrew Stanton");
            DVD lionKindDvD = new DVD("The Lion King", 2019, "Job Favreau");
            DVD starWarsDVD = new DVD("Star Wars", 1977, "George Lucas");

            dvdCollection[7] = avengersDvD;

            // incredibles into the 4th place : index 3
            dvdCollection[3] = incrediblesDVD;

            // finding dory into 10th place : index 9
            dvdCollection[9] = findingDoryDVD;

            // lion king into 3rd place : index 2
            dvdCollection[2] = lionKindDvD;

            // reading
            Console.WriteLine(dvdCollection[7].ToString());
            Console.WriteLine(dvdCollection[3].ToString());
            Console.WriteLine(dvdCollection[9].ToString());
            Console.WriteLine(dvdCollection[2].ToString());

            // index = 3
            dvdCollection[3] = starWarsDVD;
            Console.WriteLine(dvdCollection[7].ToString());
            Console.WriteLine(dvdCollection[3].ToString());
            Console.WriteLine(dvdCollection[9].ToString());
            Console.WriteLine(dvdCollection[2].ToString());
        }
    }
}
