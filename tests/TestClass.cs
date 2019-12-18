// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using D4H.NET;
using D4H.NET.Requests;
using NUnit.Framework;

namespace D4H.NET_Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            var client = new APIClient("YOUR TOKEN HERE");
            var eventRequest = new EventRequest(client);
            var result = eventRequest.GetEventsAsync().Result;

        }
    }
}
