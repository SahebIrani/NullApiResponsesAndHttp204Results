using System;

namespace Demo.SinjulMSBH.Results
{
    public class ResponseResult
    {
        public bool IsError { get; set; }
        public string ResultValue { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }

    public class ResponseResult2
    {
        public string ResultValue { get; set; }

        public bool IsError { get; set; }
        public bool NoData { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
