using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyser
{
    public class IndianStateCensusException : Exception
    {
        public enum IndianStateExceptionType
        {
            FILE_INCORRECT,
            FILE_TYPE_INCORRECT,
            INCORRECT_DELIMETER,
            INCORRECT_HEADER,
            CSV_FILECODE_INCORRECT
        }
        public IndianStateExceptionType Type;
        public IndianStateCensusException(IndianStateExceptionType type, string message) : base(message)
        {
            this.Type = type;
        }
    }
}
