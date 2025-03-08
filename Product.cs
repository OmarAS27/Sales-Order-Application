using System;
using System.Net;
using System.Numerics;
using System.Xml.Linq;

public class Product
{
	public int Product_Id { get; set; }
	public string Product_Name { get; set; }
	public double Product_Price { get; set; }
	public int Product_Quantity { get; set; }

	/*private static String ID_str = File.ReadAllText("Product_ID.txt");
	public static string[] ID_Product { set; get; }

    private static String NAME_str = File.ReadAllText("Product_NAME.txt");
    public static string[] NAME_Product { set; get; }
    private static String PRICE_str = File.ReadAllText("Product_PRICE.txt");
    public static string[] PRICE_Product { set; get; }
    private static String QUANTITY_str = File.ReadAllText("QUANTITY_ID.txt");
    public static string[] QUANTITY_Product { set; get; }*/

    public static List<Product> products = new List<Product>();
    public Product(int product_id , string product_name, double product_price,int product_quntity)
	{
		this.Product_Id = product_id;
		this.Product_Name = product_name;
		this.Product_Price = product_price;
		this.Product_Quantity = product_quntity;
	}

	public static void AddProduct(Product product)
	{
        /*File.AppendAllText("Product_ID.txt", product.Product_Id + " ");
        File.AppendAllText("Product_NAME.txt", product.Product_Name + " ");
        File.AppendAllText("Product_PRICE.txt", product.Product_Price + " ");
        File.AppendAllText("QUANTITY_ID.txt", product.Product_Quantity + " ");
		Product.assign();*/
        products.Add(product);
    }
	public static void Update(int product_id, string product_name, double product_price, int product_quntity)
	{
        /*File.WriteAllText("Product_ID.txt", "");
        File.WriteAllText("Product_NAME.txt", "");
        File.WriteAllText("Product_PRICE.txt", "");
        File.WriteAllText("QUANTITY_ID.txt", "");

		

		for(int i = 0; i < Product.ID_Product.Length; i++)
		{
			if(product_id.Equals(Product.ID_Product[i]))
			{
				Product.PRICE_Product[i] = product_price.ToString();
				Product.QUANTITY_Product[i] = product_quntity.ToString();
				Product.NAME_Product[i] = product_name;
				
			}
			File.AppendAllText("Product_ID.txt", ID_Product[i]+ " ");
			File.AppendAllText("Product_NAME.txt", NAME_Product[i]+ " ");
            File.AppendAllText("Product_PRICE.txt", PRICE_Product[i]+" ");
            File.AppendAllText("QUANTITY_ID.txt", QUANTITY_Product[i] +" ");

        }
		Product.assign();*/
        var product = products.Find(i => i.Product_Id == product_id);
        if (product != null)
        {
            product.Product_Price=product_price;
            product.Product_Quantity=product_quntity;
            product.Product_Name = product_name;
        }
    }

    public static void Delete(Product product)
    {
        /*File.WriteAllText("Product_ID.txt", "");
        File.WriteAllText("Product_NAME.txt", "");
        File.WriteAllText("Product_PRICE.txt", "");
        File.WriteAllText("QUANTITY_ID.txt", "");

        

        for (int i = 0; i < Product.ID_Product.Length; i++)
        {
            if (product.Product_Id.Equals(Product.ID_Product[i]))
            {
                continue;

            }
            File.AppendAllText("Product_ID.txt", ID_Product[i] + " ");
            File.AppendAllText("Product_NAME.txt", NAME_Product[i] + " ");
            File.AppendAllText("Product_PRICE.txt", PRICE_Product[i] + " ");
            File.AppendAllText("QUANTITY_ID.txt", QUANTITY_Product[i] + " ");

        }
        Product.assign();*/
        var pro = products.Find(i => i.Product_Id == product.Product_Id);
        if (product != null)
        {
            products.Remove(pro);   
        }

    }
    /*
    public static void assign()
	{
        


        ID_Product = ID_str.Split(" ");
		NAME_Product = NAME_str.Split(" ");
		PRICE_Product = PRICE_str.Split(" ");
		QUANTITY_Product = QUANTITY_str.Split(" ");


	}

    public static void create()
    {
        var file_product_id = File.Create("Product_ID.txt");
        var file_product_name = File.Create("Product_NAME.txt");
        var file_product_price = File.Create("Product_PRICE.txt");
        var file_product_Quantity = File.Create("QUANTITY_ID.txt");

        file_product_id.Close();
        file_product_name.Close();
        file_product_price.Close();
        file_product_Quantity.Close();
    }*/

    public static void Print()
	{

        foreach(Product product in products)
        {
            Console.WriteLine("\nProduct_Id:" + product.Product_Id+
                "\nProduct_Name:" + product.Product_Name +
                "\nProduct_price:" + product.Product_Price +
                "\nProduct_Quntity:" + product.Product_Quantity
                );
        }
    }
}
