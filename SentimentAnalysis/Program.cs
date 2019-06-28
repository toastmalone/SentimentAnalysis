using System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.ML;
using Microsoft.ML.Data;
using static Microsoft.ML.DataOperationsCatalog;
using Microsoft.ML.Trainers;
using Microsoft.ML.Transforms.Text;


namespace SentimentAnalysis
{
    
    class Program
    {
        static readonly string _dataPath = Path.Combine(Environment.CurrentDirectory, "Data", "yelp_labelled.txt");
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
