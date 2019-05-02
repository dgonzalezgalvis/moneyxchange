using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoneyXchange.Api;
using MoneyXchange.Api.Controllers;
using MoneyXchange.Api.Models;

namespace MoneyXchange.Api.Tests.Controllers
{
    [TestClass]
    public class ExchangesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Disponer
            ExchangesController controller = new ExchangesController();

            // Actuar
            IEnumerable<Exchange> result = controller.GetExchanges();

            // Declarar
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetById()
        {
            // Disponer
            ExchangesController controller = new ExchangesController();

            // Actuar
            var result = controller.GetExchange(1);

            // Declarar
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Post()
        {
            // Disponer
            ExchangesController controller = new ExchangesController();

            var exchange = new Exchange()
            {
                Id = 1,
                currency = "COP",
                factor = 1
            };

            // Actuar
            controller.PostExchange(exchange);

            // Declarar
        }

        [TestMethod]
        public void Put()
        {
            // Disponer
            ExchangesController controller = new ExchangesController();

            var exchange = new Exchange()
            {
                Id = 1,
                currency = "COP",
                factor = 1
            };

            // Actuar
            controller.PutExchange(5, exchange);

            // Declarar
        }

        [TestMethod]
        public void Delete()
        {
            // Disponer
            ExchangesController controller = new ExchangesController();

            // Actuar
            controller.DeleteExchange(5);

            // Declarar
        }
    }
}
