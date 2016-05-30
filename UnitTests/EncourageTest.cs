using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreakTime;

namespace UnitTests
{
    // This class tests the cases where encouragement data should be
    // pulled from the web server or not pulled from the web server.
    [TestClass]
    public class EncourageTest
    {
        // If frmEncouragement.Popup(true) is called, encouragement text is received.
        [TestMethod]
        public void TruePopup()
        {
            var enc = new frmEncouragement();

            enc.triggerTruePopup();

            Assert.AreNotEqual("", enc.getTxtEncouragement());

            enc.Dispose();
        }

        // If frmEncouragement.Popup(false) is called, encouragement text is not received.
        [TestMethod]
        public void FalsePopup()
        {
            var enc = new frmEncouragement();

            enc.triggerFalsePopup(false);

            Assert.AreEqual("", enc.getTxtEncouragement());

            enc.Dispose();
        }
    }
}
