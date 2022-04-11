using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Calculating.Exceptions
{
    // Custom exception для ошибки с отрицательным значением входящих переменных фигур 
    [Serializable]
    public class NegativeVariableException : Exception
    {

        private static readonly string DefaultMessage = "Variable can`t be negative";
        public NegativeVariableException() : base(DefaultMessage) { }
        public NegativeVariableException(string message) : base(message) { }
        public NegativeVariableException(string message, System.Exception innerException)
        : base(message, innerException) { }

       
        protected NegativeVariableException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

    }
}
