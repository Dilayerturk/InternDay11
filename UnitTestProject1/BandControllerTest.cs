using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MOQExample;
using FluentAssertions;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class BandControllerTest
    {
        [TestMethod]
        public void MethodToTest()
        {
            // CREATE LIST OF BANDS TO RETURN
            var ListofBands = new List<Band>();
            ListofBands.Add(new Band
            {
                Name = "Uzay",
                Origin = "İzmir",
                Genre = "Rock",
                BestSong = "Sabır"
            });

            Mock<IRepository> mockRepository = new Mock<IRepository>();
            mockRepository.Setup(x => x.GetBands()).Returns(ListofBands);
            var bandController = new BandController(mockRepository.Object);
            bandController.MethodToTest();
            bandController.Should().NotBeNull();
        }
    }
}
