using Sales_Order_Application;
using System;

public class Stock
{

    public static List<Product> products =new List<Product>();

    public static int Count = products.Count();

    public static void AddStock(Product product)
    {
        Product.AddProduct(product);
        Stock.products.Add(product);
    }

    public static void DeleteStock(Product product)
    {
        Stock.products.Remove(product);
        Product.Delete(product);
    }

    public static void Search_Quantity(int product_id)
    {
        Product product = products.Find(pro => pro.Product_Id == product_id);
        if (product == null)
        {
            Console.WriteLine("Not Found");
            Thread.Sleep(5000);
            Program.Continue(true);
        }
        else
        {
            Console.WriteLine("Product: " + product.Product_Name + "\n Product_Quantity: " + product.Product_Quantity);
        }

        
    }
    public static Product Search_Product(int product_id)
    {
        Product product = products.Find(pro => pro.Product_Id == product_id);
        if (product != null)
        {
            return product;
        }
        else
        {
            Console.WriteLine("NOT FOUND");
            Thread.Sleep(5000);
            Program.Continue(true);
            return null;
        }

        

    }
}
