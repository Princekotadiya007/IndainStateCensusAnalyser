using IndianStateCensusAnalyser;

namespace IndianStateCensusAnlyserTest
{
    public class Tests
    {
        public static string filePath = @"D:\RFP-demo\IndainStateCensusAnalyser\IndianStateCensusAnalyser\IndianStateCensusAnalyser\File\StateCensusData.csv";
        public static string stateIncorrectPath = @"D:\RFP-demo\IndainStateCensusAnalyser\IndianStateCensusAnalyser\IndianStateCensusAnalyser\File\StateCensusDataaa.csv";
        public static string stateIncorrectFilePath = @"D:\RFP-demo\IndainStateCensusAnalyser\IndianStateCensusAnalyser\IndianStateCensusAnalyser\File\StateCensusData.txt";

        CsvStateCensus csvStateCensus = new CsvStateCensus();
        StateCensusAnalyzer stateCensusAnalyzer = new StateCensusAnalyzer();

        [Test]
        public void GivenStateCensusDataShouldMatchNumberOfReturnMatches()
        {
            Assert.AreEqual(stateCensusAnalyzer.ReadStateCensusData(filePath), csvStateCensus.ReadStateCensusData(filePath));
        }
        [Test]
        public void GivenIncorrectCsvfileReturnCustomException()
        {
            try
            {
                int record = stateCensusAnalyzer.ReadStateCensusData(stateIncorrectPath);
            }
            catch(IndianStateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Incorrect file path");
            }
        }
        [Test]
        public void GivenIncorrectFileType_ShouldReturnCustomException()
        {
            try
            {
                int record = stateCensusAnalyzer.ReadStateCensusData(stateIncorrectFilePath);
            }
            catch (IndianStateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "File type is incorrect");
            }
        }
    }
}