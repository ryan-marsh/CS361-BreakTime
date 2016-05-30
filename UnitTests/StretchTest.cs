using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreakTime;

namespace UnitTests
{
    // This class tests whether or not stretch data can be obtained from the web server.
    [TestClass]
    public class StretchTest
    {
        // If frmStretch.getRandomStretch() is called, an image is obtained.
        [TestMethod]
        public void StretchImageObtained()
        {
            var stretch = new frmStretch();

            stretch.callGetRandomStretch();

            Assert.IsTrue(stretch.hasImage());
        }

        // If frmStretch.getRandomStretch() is called, a description is obtained.
        [TestMethod]
        public void StretchDescriptionObtained()
        {
            var stretch = new frmStretch();

            stretch.callGetRandomStretch();

            Assert.IsTrue(stretch.hasDescription());
        }

        // If frmStretch.getRandomStretch() is called, a name is obtained.
        [TestMethod]
        public void StretchNameObtained()
        {
            var stretch = new frmStretch();

            stretch.callGetRandomStretch();

            Assert.IsTrue(stretch.hasName());
        }
    }
}
