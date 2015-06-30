using System;
using System.Diagnostics;
using System.Linq;
using Xunit;

namespace GAEvents
{
    public class Benchmark
    {
        [Fact]
        public void should_send_event()
        {
            var st = new Stopwatch();
            st.Start();
            Enumerable.Range(0, 400).ToList().ForEach(i =>
            {
                GoogleAnalyticsApi.TrackEvent("Advertisement", "Perf", Guid.NewGuid().ToString());
            });
            st.Stop();
            Console.Out.WriteLine(st.ElapsedMilliseconds);
        } 
    }
}