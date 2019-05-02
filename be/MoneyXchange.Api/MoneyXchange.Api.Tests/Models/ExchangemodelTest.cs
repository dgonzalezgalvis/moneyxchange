using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyXchange.Api.Models;

namespace MoneyXchange.Api.Tests.Models
{
    [TestClass]
    class ExchangeModelTest
    {
        [TestMethod]
        public void Exchange()
        {
            // Disponer


            // Actuar
            var exchange = new Exchange()
            {
                Id = 1,
                currency = "COP",
                factor = 1
            };

            // Declarar
            Assert.IsNotNull(exchange);
            Assert.AreEqual(exchange.currency, "COP");
            Assert.AreEqual(exchange.factor, 1);
        }
    }
}
