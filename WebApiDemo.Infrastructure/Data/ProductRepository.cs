using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Core.Entities;
using WebApiDemo.Core.Interfaces;

namespace WebApiDemo.Infrastructure
{
    public class ProductRepository : IProductRepository
    {
        IEnumerable<ProductDetails> data = new List<ProductDetails>() {
            new ProductDetails{
             ID = 1,
             Name = "Grand Theft Auto V - PlayStation 3",
             Price = 19.99,
             Description = "Comes in original case with manual. Game is in excellent condition.",
             Published = true
            },

            new ProductDetails{
             ID = 2,
             Name = "Spider-Man - PlayStation 5",
             Price = 49.99,
             Description = "Comes in original case with manual. Game is in excellent condition.",
             Published = true
            },

            new ProductDetails{
             ID = 3,
             Name = "Fortnite - PlayStation 3",
             Price = 36.99,
             Description = "Comes in original case with manual. Game is in excellent condition.",
             Published = false
            },

             new ProductDetails{
             ID = 4,
             Name = "Days Gone - PlayStation 5",
             Price = 20.99,
             Description = "Comes in original case with manual. Game is in excellent condition.",
             Published = true
            },

             new ProductDetails{
             ID = 5,
             Name = "Horizon zero dawn - X-Box",
             Price = 15.99,
             Description = "Comes in original case with manual. Game is in excellent condition.",
             Published = false
            },
        };
        public Task<ProductDetails> GetProductDetailsAsync(int productId)
        {
            //Here we can do an actuacl data base call to fetch the data from database
            //We can use auto mapper to automaticall map data to ProductDetails

            var productDetails = data.Where(x => x.ID == productId);

            return (Task<ProductDetails>)productDetails;
        }
    }
}
