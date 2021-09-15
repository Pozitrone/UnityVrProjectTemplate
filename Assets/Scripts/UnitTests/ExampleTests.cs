using NUnit.Framework;
using UnityEngine;
using Runtime;

namespace UnitTests
{
    public class ExampleTests
    {
        // Use [Test] for basic testing
        // Use [UnityTest] for IEnumerators

        [Test]
        public void TestMethod()
        {
            int x = 27;
            int y = Random.Range(26, 28);
            
            Assert.That(x == y, "X != Y"); // Make sure that x == y, otherwise return a message that X != Y
            Assert.Fail();
        }
    }
}
