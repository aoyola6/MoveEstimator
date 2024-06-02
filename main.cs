using System;
namespace MoveEstimator{

    
}

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the estimated number of hours for the job: ");
            double hours = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the number of miles involved in the move: ");
            double miles = Convert.ToDouble(Console.ReadLine());
            // Constants for the rates
            const double BASE_RATE = 200;
            const double HOURLY_RATE = 150;
            const double MILEAGE_RATE = 2;
            // Calculate the total moving fee
            double totalFee = (hours * HOURLY_RATE) + (miles * MILEAGE_RATE) + BASE_RATE;
            // Display the total moving fee
            Console.WriteLine($"The total moving fee is: ${totalFee:F2}");
        }
    }




    
