using System;
using System.Net;
using System.Runtime.Serialization;

namespace CM.Email.Sdk.Exceptions
{
    public class ApiResponseException : Exception
    {
        public HttpStatusCode StatusCode { get; }
        public string Content { get; }
        public string MessageCode { get; }
        public string MessageDetail { get; }

        public ApiResponseException()
        {
        }

        public ApiResponseException(string message) : base(message)
        {
        }

        public ApiResponseException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ApiResponseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public ApiResponseException(HttpStatusCode statusCode, string content, string message, string messageCode, string messageDetail) : base(message)
        {
            StatusCode = statusCode;
            Content = content;
            MessageCode = messageCode;
            MessageDetail = messageDetail;
        }
    }
}
