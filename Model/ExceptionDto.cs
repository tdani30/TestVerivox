using System;

namespace TestVerivox.Model
{
    public class ExceptionDto : Exception
    {
        public ExceptionDto(string message, int statusCode) : base(message)
        {
            StatusCode = statusCode;
        }
        public int StatusCode { set; get; }
    }
}
