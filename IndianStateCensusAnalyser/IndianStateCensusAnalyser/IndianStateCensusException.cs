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
            CSV_FILECODE_INCORRECT,
            CODE_FILE_TYPE_INCORRECT,
            CODE_INCORRECT_DELIMETER,
            CODE_INCORRECT_HEADER
        }
        public IndianStateExceptionType Type;
        public IndianStateCensusException(IndianStateExceptionType type, string message) : base(message)
        {
            this.Type = type;
        }
    }
}
