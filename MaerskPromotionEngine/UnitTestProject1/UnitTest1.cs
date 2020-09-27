using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;
using Repository;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        ProductService objprod = new ProductService();
        List<Product> products = new List<Product>();

        [TestMethod]
        public void TestCheckPrice()
        {

            string type = "A"; ;
            Product p = new Product(type);
            products.Add(p);

            int totalPrice = objprod.GetTotalPrice(products);
            Assert.IsNotNull(totalPrice);
            Assert.AreEqual(50, totalPrice);

            // now we can write ASSERT for all(A,B,C,D) in one go.

        }
    }
}
