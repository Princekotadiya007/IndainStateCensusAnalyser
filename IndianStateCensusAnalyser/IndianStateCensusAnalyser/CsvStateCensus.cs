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
    public class CsvStateCensus
    {
        public int ReadStateCensusData(string filePath)
        {
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
                    return records.Count()-1;
                }
            }
        }
    }
}
