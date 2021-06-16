using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyRealWorldUnitTest.Web.Controllers;
using UdemyRealWorldUnitTest.Web.Models;
using UdemyRealWorldUnitTest.Web.Repository;

namespace UdemyRealWorldUnitTest.Test
{
    public class ProductControllerTest
    {
        private readonly Mock<IRepository<Product>> _mockRepo;

        private readonly ProductsController _controller;
        private List<Product> products;

        public ProductControllerTest()
        {
            _mockRepo = new Mock<IRepository<Product>>();
            _controller = new ProductsController(_mockRepo.Object);

            products = new List<Product>() {
               new Product { Id = 1, Name = "Kalem", Price = 100, Stock = 50, Color = "Kırmızı" },
               new Product {Id=2,Name="Defter", Price=200, Stock=50, Color="Mavi" }
            };
        }
    }
}
