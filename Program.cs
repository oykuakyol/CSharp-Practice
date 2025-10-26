using System;
using System.Diagnostics;
using System.Drawing;
class Program2
{
    static void Main()
    {
        Console.WriteLine("Grade Point Average Calculator");
        // Take the course count
        
        Console.WriteLine("How many courses do you have?");
        bool isValidCount = int.TryParse(Console.ReadLine(), out int courseCount);
        if (!isValidCount || courseCount <= 0)
        {

            Console.WriteLine("Please enter a valid course count!");
            return;
        }
        double sum = 0;

        // Take grade for each course

        for (int i=1;i<= courseCount; i++)
        {
            Console.WriteLine($"Enter the {i} course grade");
            bool isValidGrade = double.TryParse(Console.ReadLine(), out double grade);

            if(!isValidGrade || grade<0||grade>100){
                Console.WriteLine("Please enter a valid grade between 0-100!");
                i--;  // Ask again for the same course
                continue;

            }
            sum += grade;
        }
        // Calculate the average
        double average = sum / courseCount;
   
       Console.WriteLine($"\nYour average is: {average:F2}");

        // Pass-fail control

        if (average >= 50)
        
            Console.WriteLine("Congrats,you passed! ");


          else
                Console.WriteLine("Unfortunately you failed.");

        }
    
    }

    



