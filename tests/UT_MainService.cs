using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cam.Plugins;
using Cam.Network.P2P.Payloads;
using Cam;
using Cam.Persistence;
//using Settings = Cam.Plugins.Settings;
using System.Collections.Generic;
using Cam.Cryptography;
using System.Numerics;
using System.Collections;
using System.Linq;
using System;
using Moq;
// Cam-server
using Cam.Shell;
using Cam.SmartContract;

namespace CamCli.UnitTests
{
    [TestClass]
    public class UT_MainService
    {
        private static readonly Random _random = new Random(11121990);

        MainService uut;

        [TestInitialize]
        public void TestSetup()
        {
            uut = new MainService();
        }

        [TestMethod]
        public void TestTemplate()
        {
            // Nothing to do here now... put some tests
        }
    }
}
