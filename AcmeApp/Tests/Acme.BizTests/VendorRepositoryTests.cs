using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class VendorRepositoryTests
    {
        [TestMethod()]
        public void RetieveValueIntTest()
        {
            // Arrange
            var repository = new VendorRepository();
            var expected = 42;

            // Act
            var actual = repository.RetieveValue<int>("Select ...", 42);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetieveValueStringTest()
        {
            // Arrange
            var repository = new VendorRepository();
            var expected = "test";

            // Act
            var actual = repository.RetieveValue("Select ...", "test");

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}