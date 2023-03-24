using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyser
{
    public class StateCensusAnalyzer
    {
        public int ReadStateCensusData(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new IndianStateCensusException(IndianStateCensusException.IndianStateExceptionType.FILE_INCORRECT, "Incorrect file path");
            }
            if (!filePath.EndsWith(".csv"))
            {
                throw new IndianStateCensusException(IndianStateCensusException.IndianStateExceptionType.FILE_TYPE_INCORRECT, "File type is incorrect");
            }
            var csvReader = File.ReadAllLines(filePath);
            string header = csvReader[0];
            if (header.Contains("/"))
            {
                throw new IndianStateCensusException(IndianStateCensusException.IndianStateExceptionType.INCORRECT_DELIMETER, "Delimeter is incorrect");
            }
            using (var render = new StreamReader(filePath))
            {
                using (var csv = new CsvReader(render, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<StateCensusAnalyserModel>().ToList();
                    foreach (var record in records)
                    {
                        //Console.WriteLine($"{record.State} {record.Population} {record.AreaInSqKm} {record.DensityPerSqKm}");
                        Console.WriteLine(record);
                    }
                    return records.Count() - 1;
                }
            }
        }
        public bool ReadStateCensusData(string filePath, string actualHeader)
        {
            var csvReader = File.ReadAllLines(filePath);
            string header = csvReader[0];
            if (header.Equals(actualHeader))
                return true;
            else
                throw new IndianStateCensusException(IndianStateCensusException.IndianStateExceptionType.INCORRECT_HEADER, "Header is incorrect");
        }
    }
}
