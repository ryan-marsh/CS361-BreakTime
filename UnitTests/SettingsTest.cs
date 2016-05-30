using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreakTime;

namespace UnitTests
{
    // This class tests whether or not all user settings can
    // be changed, written and read from files successfully.
    [TestClass]
    public class SettingsTest
    {
        // If Settings.UserName is changed and written, it is read back from the file successfully.
        [TestMethod]
        public void TestWriteUserName()
        {
            Settings.UserName = "Name";
            Settings.WriteUserSettings();
            Settings.ReadUserSettings();

            Assert.AreEqual("Name", Settings.UserName);
        }

        // If Settings.WhatHurts is changed and written, it is read back from the file successfully.
        [TestMethod]
        public void TestWriteWhatHurts()
        {
            Settings.WhatHurts.back = true;
            Settings.WriteUserSettings();
            Settings.ReadUserSettings();

            Assert.IsTrue(Settings.WhatHurts.back);
            Assert.IsFalse(Settings.WhatHurts.elbows);
            Assert.IsFalse(Settings.WhatHurts.eyes);
            Assert.IsFalse(Settings.WhatHurts.feet);
            Assert.IsFalse(Settings.WhatHurts.hands);
            Assert.IsFalse(Settings.WhatHurts.head);
            Assert.IsFalse(Settings.WhatHurts.knees);
            Assert.IsFalse(Settings.WhatHurts.legs);
            Assert.IsFalse(Settings.WhatHurts.neck);
            Assert.IsFalse(Settings.WhatHurts.shoulders);
            Assert.IsFalse(Settings.WhatHurts.wrists);
        }

        // If Settings.Interval is changed and written, it is read back from the file successfully.
        [TestMethod]
        public void TestWriteInterval()
        {
            Settings.Interval = TimeSpan.FromMinutes(30.0);
            Settings.WriteUserSettings();
            Settings.ReadUserSettings();

            Assert.AreEqual(30, Settings.Interval.Minutes);
        }
    }
}
