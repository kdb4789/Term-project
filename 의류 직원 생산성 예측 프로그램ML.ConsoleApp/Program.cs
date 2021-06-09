// This file was auto-generated by ML.NET Model Builder. 

using System;
using 의류_직원_생산성_예측_프로그램ML.Model;

namespace 의류_직원_생산성_예측_프로그램ML.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                Date = @"1/1/2015",
                Quarter = @"Quarter1",
                Department = @"sweing",
                Day = @"Thursday",
                Team = 8F,
                Targeted_productivity = 0.8F,
                Smv = 26.16F,
                Wip = 1108F,
                Over_time = 7080F,
                Incentive = 98F,
                Idle_time = 0F,
                Idle_men = 0F,
                No_of_style_change = 0F,
                No_of_workers = 59F,
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Actual_productivity with predicted Actual_productivity from sample data...\n\n");
            Console.WriteLine($"Date: {sampleData.Date}");
            Console.WriteLine($"Quarter: {sampleData.Quarter}");
            Console.WriteLine($"Department: {sampleData.Department}");
            Console.WriteLine($"Day: {sampleData.Day}");
            Console.WriteLine($"Team: {sampleData.Team}");
            Console.WriteLine($"Targeted_productivity: {sampleData.Targeted_productivity}");
            Console.WriteLine($"Smv: {sampleData.Smv}");
            Console.WriteLine($"Wip: {sampleData.Wip}");
            Console.WriteLine($"Over_time: {sampleData.Over_time}");
            Console.WriteLine($"Incentive: {sampleData.Incentive}");
            Console.WriteLine($"Idle_time: {sampleData.Idle_time}");
            Console.WriteLine($"Idle_men: {sampleData.Idle_men}");
            Console.WriteLine($"No_of_style_change: {sampleData.No_of_style_change}");
            Console.WriteLine($"No_of_workers: {sampleData.No_of_workers}");
            Console.WriteLine($"\n\nPredicted Actual_productivity: {predictionResult.Score}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
