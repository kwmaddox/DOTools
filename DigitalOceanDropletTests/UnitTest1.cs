using System;
using NUnit.Framework;
using DigitalOcean;

namespace DigitalOceanDropletTests
{
    [TestFixture]
    public class CreateDroplet
    {
        private Droplet droplet;
        [SetUp]
        public void Init()
        {
            droplet = new Droplet();
        }

        [Test]
        public void ReturnsADroplet()
        {
            var result = droplet.create();
            Assert.IsInstanceOf<Droplet>(result);
        }

        [Test]
        public void ConstructsDropletWithGivenValues()
        {
            droplet = new Droplet(
                name:"testName",
                region:"testRegion",
                size:"testSize",
                image:"testImage"   
            );


            Assert.AreEqual(droplet.name, "testName");

            Assert.AreEqual(droplet.region, "testRegion");
            Assert.AreEqual(droplet.size, "testSize");
            Assert.AreEqual(droplet.image, "testImage");


        }

        [Test]
        public void DefaultConstructorSetsDefaultValues()
        {
            Assert.AreEqual(droplet.name, "Placeholder Name");
            Assert.AreEqual(droplet.region, "nyc1");
            Assert.AreEqual(droplet.size, "s-1vcpu-1gb");
            Assert.AreEqual(droplet.image, "ubuntu-16-04-x64");
        }
    }
}
