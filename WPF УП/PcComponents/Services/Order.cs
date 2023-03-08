using PcComponents.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcComponents
{
    public class OrderedProduct
    {
        public Product Product;
        public int Quantity { get; set; }

        public OrderedProduct(Product product, int quantity)
        {
            Product = product;
            this.Quantity = quantity;
        }
    }

    public static class Order
    {
        public static List<OrderedProduct> Products = new List<OrderedProduct>();

        public static void AddProduct(Product p)
        {
            OrderedProduct? existedProduct = Products.Find(pr => pr.Product.Id == p.Id);

            if (existedProduct != null)
            {
                existedProduct.Quantity++;
            }
            else
            {
                OrderedProduct op = new OrderedProduct(p, 1);
                Products.Add(op);
            }
        }


        public static void RemoveProduct(int id)
        {
            OrderedProduct? op = Products.Find(pr => pr.Product.Id == id);
            if (op != null)
            {
                Products.Remove(op);
            }
		}
    }
}
