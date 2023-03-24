using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyser
{
    public class Program
    {
        public static string filePath = @"D:\RFP-demo\IndainStateCensusAnalyser\IndianStateCensusAnalyser\IndianStateCensusAnalyser\File\StateCensusData.csv";
        public static string filePath1 = @"D:\RFP-demo\IndainStateCensusAnalyser\IndianStateCensusAnalyser\IndianStateCensusAnalyser\File\StateCode.csv";
        static void Main(string[] args)
        {
            CsvStateCensus csvState = new CsvStateCensus();
            csvState.ReadStateCensusData(filePath);

            CsvStateCode csvStateCode = new CsvStateCode();
            csvStateCode.ReadStateCodeData(filePath1);

            Console.ReadLine();
        }
    }
}
