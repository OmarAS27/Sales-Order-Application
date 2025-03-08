using System;

public class Customer:Company,Person
{
    public String loaction { get; set; }
    public String company_name { get; set; }
    public String billing_address { get; set; }
    public String fullname { get; set; }
    public int id_company { get; set; }
    public string phone_company { get; set; }
    public int id_person { get; set; }
    public string phone_person { get; set; }
    public bool is_company { get; set; }

    /*private static String id_company_str = File.ReadAllText("Customers_id_company.txt");
    public static String[] Customers_id_company { get; set; }

    private static String phone_company_str = File.ReadAllText("Customers_phone_company.txt");
    public static String[] Customers_company_phone { get; set; }

    private static String id_person_str = File.ReadAllText("Customers_id_person.txt");
    public static String[] Customers_id_person { get; set; }

    private static String phone_person_str = File.ReadAllText("Customers_phone_person.txt");
    public static String[] Customers_person_phone { get; set; }

    private static String company_name_str = File.ReadAllText("Customers_name_company.txt");
    public static String[] Customers_company_name { get; set; }

    private static String company_address_str = File.ReadAllText("Customers_address_company.txt");
    public static String[] Customers_company_address { get; set; }

    private static String person_name_str = File.ReadAllText("Customers_name_person.txt");
    public static String[] Customers_person_name { get; set; }

    private static String person_address_str = File.ReadAllText("Customers_address_person.txt");
    public static String[] Customers_person_address { get; set; }*/
        
    public Customer(bool is_company,string name ,string address,int id , string phone)
	{
        
        this.is_company = is_company;
        

        if (is_company)
        {
            this.company_name = name;
            this.loaction = address;
            this.phone_company = phone;
            this.id_company = id;
        }
        else
        {
            this.fullname = name;
            this.billing_address= address;
            this.phone_person = phone;
            this.id_person = id;
        }

	}

    public void print()
    {
        if(this.is_company)
        {
            Console.WriteLine("\nCustomer(Company):\n Id: " + this.id_company
                + "\nName: " + this.company_name +
                "\naddress: " + this.loaction +
                "\nphone: " + this.phone_company);
        }
        else
        {
            Console.WriteLine("\nCustomer(Person):\n Id: " + this.id_person
                +
                "\nName: " + this.fullname +
                "\naddress: " + this.billing_address +
                "\nphone: " + this.phone_person);
        }
    }
    /*
    public static void assign()
    {
       

        Customers_person_address = person_address_str.Split(" ");
        Customers_person_name = person_name_str.Split(" ");
        Customers_company_address = company_address_str.Split(" ");
        Customers_company_name = company_name_str.Split(" ");
        Customers_id_person = id_person_str.Split(" ");
        Customers_person_phone = phone_person_str.Split(" ");
        Customers_id_company = id_company_str.Split(" ");
        Customers_company_phone = phone_company_str.Split(" ");
    }

    public static void create()
    {
        var file_company_id = File.Create("Customers_id_company.txt");
        var file_company_phone = File.Create("Customers_phone_company.txt");
        var file_person_id = File.Create("Customers_id_person.txt");
        var file_person_phone = File.Create("Customers_phone_person.txt");
        var file_company_name = File.Create("Customers_name_company.txt");
        var file_company_address = File.Create("Customers_address_company.txt");
        var file_person_name = File.Create("Customers_name_person.txt");
        var file_person_address = File.Create("Customers_address_person.txt");
        file_company_address.Close();
        file_company_id.Close();
        file_company_name.Close();
        file_company_phone.Close();
        file_person_address.Close();
        file_person_id.Close();
        file_person_name.Close();
        file_person_phone.Close();
    }*/
}
