using IndianStateCensusAnalyser;

namespace IndianStateCensusAnlyserTest
{
    public class Tests
    {
        public static string filePath = @"D:\RFP-demo\IndainStateCensusAnalyser\IndianStateCensusAnalyser\IndianStateCensusAnalyser\File\StateCensusData.csv";
        public static string stateIncorrectPath = @"D:\RFP-demo\IndainStateCensusAnalyser\IndianStateCensusAnalyser\IndianStateCensusAnalyser\File\StateCensusDataaa.csv";
        public static string stateIncorrectFilePath = @"D:\RFP-demo\IndainStateCensusAnalyser\IndianStateCensusAnalyser\IndianStateCensusAnalyser\File\StateCensusData.txt";
        public static string incorrectDelimeterPath = @"D:\RFP-demo\IndainStateCensusAnalyser\IndianStateCensusAnalyser\IndianStateCensusAnalyser\File\StateCensusDelimeter.csv";

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
        [Test]
        public void GivenIncorrectFileDelimeter_ShouldReturnCustomException()
        {
            try
            {
                int record = stateCensusAnalyzer.ReadStateCensusData(incorrectDelimeterPath);
            }
            catch (IndianStateCensusException ex)
            {
                Assert.AreEqual(ex.Message, "Delimeter is incorrect");
            }
        }
    }
}
