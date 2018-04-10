using Amazon.XRay.Recorder.Core;

namespace XRayTest.Controllers
{
    public static class XRayTest
    {
        public static void CreateSubsegment()
        {
            var recorder = AWSXRayRecorder.Instance;

            recorder.BeginSubsegment("Test");
            recorder.EndSubsegment();
        }
    }
}