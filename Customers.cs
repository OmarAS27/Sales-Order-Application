using System;
using System.Net;
using System.Numerics;
using System.Xml.Linq;

namespace Sales_Order_Application
{
	public class Customers : Customer
	{
        public static List<Customer> customers_company = new List<Customer>();
        public static List<Customer> customers_person = new List<Customer>();
        public Customers(bool is_company, string name, string address, int id, string phone) : base(is_company, name, address, id, phone)
		{
		}

		public static int Count { get; set; }

		public static void AddCustomer(Customer customer)
		{
			
			Count++;
			
			if (customer.is_company)
			{
              /*  File.AppendAllText("Customers_id_company.txt", customer.id_company + " ");
                File.AppendAllText("Customers_phone_company.txt", customer.phone_company + " ");
                File.AppendAllText("Customers_name_company.txt", customer.company_name + " ");
				File.AppendAllText("Customers_address_company.txt", customer.loaction + " ");*/

                customers_company.Add(customer);
			}
			else
			{
                /*File.AppendAllText("Customers_id_person.txt", customer.id_person + " ");
                File.AppendAllText("Customers_phone_person.txt", customer.phone_person + " ");
                File.AppendAllText("Customers_name_person.txt", customer.fullname + " ");
				File.AppendAllText("Customers_address_person.txt", customer.billing_address + " ");*/
                customers_person.Add(customer);
			}

			//Customer.assign();

            

		}

        public static void EditCustomer(bool is_company, string name, string address, int id, string phone)
		{
          /*  File.WriteAllText("Customers_id_person.txt","");
            File.WriteAllText("Customers_phone_person.txt", "");
            File.WriteAllText("Customers_name_person.txt", "");
            File.WriteAllText("Customers_address_person.txt","");
            File.WriteAllText("Customers_id_company.txt", "");
            File.WriteAllText("Customers_phone_company.txt", "");
            File.WriteAllText("Customers_name_company.txt", "");
            File.WriteAllText("Customers_address_company.txt","");*/

            Customer customer = new Customer(is_company, name, address, id, phone);

            if (is_company)
            {
                
				/*for (int i = 0; i < Customer.Customers_id_person.Length; i++)
				{
					if(Convert.ToInt32(Customer.Customers_id_person[i]) == id)
					{
						Customers_person_name[i]=customer.fullname;
						Customers_person_address[i]=customer.billing_address;
						Customers_person_phone[i]=customer.phone_person;
						

                    }
                    File.AppendAllText("Customers_id_person.txt", Customers_id_person[i] + " ");
                    File.AppendAllText("Customers_phone_person.txt", Customers_person_phone[i] + " ");
                    File.AppendAllText("Customers_name_person.txt", Customers_person_name[i] + " ");
                    File.AppendAllText("Customers_address_person.txt", Customers_person_address[i] + " ");

                }*/
                var company = customers_company.Find(i => i.id_company == id);
                if(company != null)
                {
                    company.loaction = address;
                    company.company_name = name;
                    company.phone_company = phone;
                }
            }
            else
            {
                var person = customers_person.Find(i => i.id_person == id);
                if (person != null)
                {
                    person.billing_address = address;
                    person.fullname = name;
                    person.phone_person = phone;
                }
             /*   for (int i = 0; i < Customer.Customers_id_company.Length; i++)
                {
                    if(Convert.ToInt32(Customer.Customers_id_company[i]) == id)
					{
                        Customers_company_name[i] = customer.company_name;
                        Customers_company_address[i]=customer.loaction;
                        Customers_company_phone[i]=customer.phone_company;

                    }
                    File.AppendAllText("Customers_id_company.txt", Customers_id_company[i] + " ");
                    File.AppendAllText("Customers_phone_company.txt", Customers_company_phone[i] + " ");
                    File.AppendAllText("Customers_name_company.txt", Customers_company_name[i] + " ");
                    File.AppendAllText("Customers_address_company.txt", Customers_company_address[i] + " ");

                }*/

            }

            //Customer.assign();
        }


        public static void DeleteCustomer(bool is_company, int id)
        {
           /* File.WriteAllText("Customers_id_person.txt", "");
            File.WriteAllText("Customers_phone_person.txt", "");
            File.WriteAllText("Customers_name_person.txt", "");
            File.WriteAllText("Customers_address_person.txt", "");
            File.WriteAllText("Customers_id_company.txt", "");
            File.WriteAllText("Customers_phone_company.txt", "");
            File.WriteAllText("Customers_name_company.txt", "");
            File.WriteAllText("Customers_address_company.txt", "");*/


            if (is_company)
            {



                var company = customers_company.Find(i => i.id_company == id);
                if (company != null)
                {
                    customers_company.Remove(company);
                }

               /* for (int i = 0; i < Customer.Customers_id_person.Length; i++)
                {
                    if (Convert.ToInt32(Customer.Customers_id_person[i]) == id)
                    {
                        continue;

                    }
                    File.AppendAllText("Customers_id_person.txt", Customers_id_person[i] + " ");
                    File.AppendAllText("Customers_phone_person.txt", Customers_person_phone[i] + " ");
                    File.AppendAllText("Customers_name_person.txt", Customers_person_name[i] + " ");
                    File.AppendAllText("Customers_address_person.txt", Customers_person_address[i] + " ");
                }*/
            }
            else
            {

                var person = customers_person.Find(i => i.id_person == id);
                if (person != null)
                {
                    customers_company.Remove(person);
                }

               /* for (int i = 0; i < Customer.Customers_id_company.Length; i++)
                {
                    if (Convert.ToInt32(Customer.Customers_id_company[i]) == id)
                    {
                        continue;

                    }
                    File.AppendAllText("Customers_id_company.txt", Customers_id_company[i] + " ");
                    File.AppendAllText("Customers_phone_company.txt", Customers_company_phone[i] + " ");
                    File.AppendAllText("Customers_name_company.txt", Customers_company_name[i] + " ");
                    File.AppendAllText("Customers_address_company.txt", Customers_company_address[i] + " ");

                }*/



            }

            //Customer.assign();
        }

        public static Customer Company_Search(int company_Id)
        {
            var company = customers_company.Find(i => i.id_company == company_Id);
            if (company != null)
            {
                return company;
            }
            else
            {
                Console.WriteLine("Not Found");
                Thread.Sleep(5000);
                Program.Continue(true);
                return null;

            }
        }

        public static Customer Person_Search(int person_Id)
        {
            var person = customers_person.Find(i => i.id_person == person_Id);
            if (person != null)
            {
                return person;
            }
            else
            {
                Console.WriteLine("Not Found");
                Thread.Sleep(5000);
                Program.Continue(true);
                return null;
            }
        }
        public static void print()
        {
            
                foreach(var person in customers_person)
                {
                    Console.WriteLine("\nCustomer(Person):\n Id: " + person.id_person
                +
                "\nName: " +person.fullname +
                "\naddress: " + person.billing_address +
                "\nphone: " + person.phone_person);
                }

          
                foreach(var company in customers_company)
                {
                Console.WriteLine("\nCustomer(Company):\n Id: " + company.id_company
            + "\nName: " + company.company_name +
            "\naddress: " + company.loaction +
            "\nphone: " + company.phone_company);
                }

            
        }
    }
}