using System;

namespace XRayTest.Models
{
    public class TestResult
    {
        public string Message { get; set; }
        public string Time { get; set; } = DateTime.Now.ToString("s");
    }
}