using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C2CApps.Core;

namespace C2CApps.Testing
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void Test_Brand()
        {
            Pentax camera = new Pentax();
            Assert.IsTrue(camera.Brand == "Pentax");
        }

        [TestMethod]
        public void Text_SwitchOn()
        {
            Pentax camera = new Pentax();
            camera.Channel.SwitchOn();
            Assert.IsTrue(camera.DeviceStatus == "On");
            Assert.IsTrue(camera.Zoom == "normal");
        }

        [TestMethod]
        public void Text_SwitchOff()
        {
            Pentax camera = new Pentax();
            camera.Channel.SwitchOff();
            Assert.IsTrue(camera.DeviceStatus == "Off");
        }

        [TestMethod]
        public void Text_ZoomIn_1_Times()
        {
            Pentax camera = new Pentax();
            camera.Channel.SwitchOn();
            camera.Channel.ZoomIn();
            Assert.IsTrue(camera.Zoom == "1 X time");
        }

        [TestMethod]
        public void Text_ZoomIn_2_Times()
        {
            Pentax camera = new Pentax();
            camera.Channel.SwitchOn();
            camera.Channel.ZoomIn();
            camera.Channel.ZoomIn();
            Assert.IsTrue(camera.Zoom == "2 X times"); /* Reach Pentax zoom in capability */
        }

        [TestMethod]
        public void Text_ZoomIn_Beyond()
        {
            Pentax camera = new Pentax();
            camera.Channel.SwitchOn();
            camera.Channel.ZoomIn();
            camera.Channel.ZoomIn();
            camera.Channel.ZoomIn();
            camera.Channel.ZoomIn();
            Assert.IsTrue(camera.Zoom == "2 X times"); /* Because the maximum zoomin on Pentax is 2, they zoom level will remain 2 eventhough user tries to keep zoom in further */
        }
    }
}
