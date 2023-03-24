using IndianStateCensusAnalyser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnlyserTest
{
    public class StateCodeTest
    {
        public static string stateCodePath = @"D:\RFP-demo\IndainStateCensusAnalyser\IndianStateCensusAnalyser\IndianStateCensusAnalyser\File\StateCode.csv";
        public static string incorrectStatePath = @"D:\RFP-demo\IndainStateCensusAnalyser\IndianStateCensusAnalyser\IndianStateCensusAnalyser\File\StateCode.csv";

        StateCodeAnalyser stateAnalyserCode = new StateCodeAnalyser();
        CsvStateCode csvStateCode = new CsvStateCode();

        [Test]
        public void GivenStateCodeData_ShouldMatchNumbersOfRetrunMatches()
        {
            Assert.AreEqual(stateAnalyserCode.ReadStateCodeData(stateCodePath), csvStateCode.ReadStateCodeData(stateCodePath));
        }
    }
}
