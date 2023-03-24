using IndianStateCensusAnalyser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnlyserTest
{
    public class StateCodeTest
    {
        public static string stateCodePath = @"D:\RFP-demo\IndainStateCensusAnalyser\IndianStateCensusAnalyser\IndianStateCensusAnalyser\File\StateCode.csv";
        public static string incorrectStatePath = @"D:\RFP-demo\IndainStateCensusAnalyser\IndianStateCensusAnalyser\IndianStateCensusAnalyser\File\StateCodes.csv";
        public static string incorrectFilePath = @"D:\RFP-demo\IndainStateCensusAnalyser\IndianStateCensusAnalyser\IndianStateCensusAnalyser\File\StateCode.txt";
        public static string delimeter = @"D:\RFP-demo\IndainStateCensusAnalyser\IndianStateCensusAnalyser\IndianStateCensusAnalyser\File\StateCodeDelimeter.csv";

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
        [Test]
        public void GivenIncorrectStateCodeCSVFileType_ShouldReturnCustomException()
        {
            try
            {
                int record = stateAnalyserCode.ReadStateCodeData(incorrectFilePath);
            }
            catch (IndianStateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect state code file type");
            }
        }
        [Test]
        public void GivenIncorrectStateCodeFileDelimeter_ShouldReturnCustomException()
        {
            try
            {
                int record = stateAnalyserCode.ReadStateCodeData(delimeter);
            }
            catch (IndianStateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect state code delimeter");
            }
        }
        [Test]
        public void GivenIncorrectStateCodeHeader_ShouldReturnCustomException()
        {
            try
            {
                bool record = stateAnalyserCode.ReadStateCodeData(stateCodePath, "SrNo,Name,TIN,StateCode,");
                Assert.IsTrue(record);
            }
            catch (IndianStateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "State code header is incorrect");
            }
        }
    }
}
