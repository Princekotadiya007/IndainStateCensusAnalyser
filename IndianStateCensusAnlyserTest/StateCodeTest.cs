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
        public static string incorrectStatePath = @"D:\RFP-demo\IndainStateCensusAnalyser\IndianStateCensusAnalyser\IndianStateCensusAnalyser\File\StateCodes.csv";

        StateCodeAnalyser stateAnalyserCode = new StateCodeAnalyser();
        CsvStateCode csvStateCode = new CsvStateCode();

        [Test]
        public void GivenStateCodeData_ShouldMatchNumbersOfRetrunMatches()
        {
            Assert.AreEqual(stateAnalyserCode.ReadStateCodeData(stateCodePath), csvStateCode.ReadStateCodeData(stateCodePath));
        }
        [Test]
        public void GivenIncorrectStateCodeCSVFilePath_ShouldReturnCustomException()
        {
            try
            {
                int record = stateAnalyserCode.ReadStateCodeData(incorrectStatePath);
            }
            catch (IndianStateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect state code file path");
            }
        }
    }
}
