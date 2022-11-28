using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1prt
{
    class Program
    {
        static void Main(string[] args)
        {
        
            {

                // declare all the variable  
                string firstName, lastName, jobTitle, workLocation, studyArea, educationLevel, university, hobby, weakness, strength;

                //  get first name
                Console.WriteLine("what is your first name?");
                firstName = Console.ReadLine();

                // get last name
                Console.WriteLine("what is your last name?");
                lastName = Console.ReadLine();

                // get the title of the job
                Console.WriteLine("what is your title of your job?");
                jobTitle = Console.ReadLine();

                // get location of job where he/she works
                Console.WriteLine("where do you work?");
                workLocation = Console.ReadLine();

                // get highest education achieved
                Console.WriteLine("what is your highest level of education/degree (BS,MS,MBA,Ph.D)?");
                educationLevel = Console.ReadLine();

                // get area of study
                Console.WriteLine("what is your area of study?");
                studyArea = Console.ReadLine();

                // get university name from where he/she pass out
                Console.WriteLine("From which university you attend?");
                university = Console.ReadLine();

                // get hobby
                Console.WriteLine("what is your hobby?");
                hobby = Console.ReadLine();

                // get strength
                Console.WriteLine("what is your strength?");
                strength = Console.ReadLine();

                // get weakness
                Console.WriteLine("what is your weakness?");
                weakness = Console.ReadLine();

              
              
             
                Console.WriteLine(firstName + " " + lastName + " is " + jobTitle + " at " + workLocation + ". " + firstName + " holds a " + educationLevel + " in " + studyArea + " from " + university
                + ". My hobby is " + hobby + ". " + "My strength is " + strength + " and weakness is " + weakness + ".");
            }
        }

    }
}

