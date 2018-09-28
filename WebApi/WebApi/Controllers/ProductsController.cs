using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class ProductsController : ApiController
    {
        public static List<Products> Products;
        public ProductsController()
        {
            Products = new List<Products>() {
                new Products{ ID = 1,
                                ProductName = "Mobile",//department
                                Customers = new List<Customers>{
                                                new Customers{ Customer_ID = 1, CustomerName = "John"},
                                                new Customers{ Customer_ID = 2, CustomerName = "Martin"}
                                                            }
                },
                new Products{ ID = 2,
                                ProductName = "Ipad",
                                Customers = new List<Customers>{
                                                new Customers{ Customer_ID = 3, CustomerName = "Mathew"},
                                                new Customers{ Customer_ID = 4, CustomerName = "albert"}
                                                            }
                }
            };
        }

        [HttpGet]
        public List<Products> GetAllProducts()
        {
            return Products;
        }

    }
}
