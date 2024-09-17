using System;
using System.Collections.Generic;


namespace Address_Book_Application
{
    internal class Program
    {
        static List<Contact> contacts = new List<Contact>();

        static void Main(string[] args)
        {
            Boolean exit = false;

            while (!exit)
            {
                
                Console.WriteLine("Address Book");
                Console.WriteLine("1. View Contacts");
                Console.WriteLine("2. Add Contact");
                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Exit");

                switch (Console.ReadLine()) 
                {
                    case "1": ViewContacts();
                        break;
                    case "2": AddContact();
                        break; 
                    case "3": EditContact();
                        break;
                    case "4": DeleteContact();
                        break;
                    case "5": exit = true;
                        break;
                }
            }
            
        }

        private static void DeleteContact()
        {
            Console.WriteLine("Enter ID to delete a contact");
            int delete_index = int.Parse(Console.ReadLine()) - 1;

            contacts.RemoveAt(delete_index);

            Console.WriteLine("Deletion completed successfully");
            ViewContacts();
            Console.WriteLine("enter any key to continue...");
            Console.ReadKey();
        }

        private static void EditContact()
        {
            Console.WriteLine("Enter ID you want EDIT");
            int index = int.Parse(Console.ReadLine())-1;

            Console.WriteLine("enter new name");
            string new_name = Console.ReadLine();
            Console.WriteLine("enter mailid");
            string new_mailid = Console.ReadLine();

            contacts[index] = new Contact(new_name, new_mailid);

            Console.WriteLine("Contact Modified Successfully");
            Console.WriteLine("New Contacts List");
            ViewContacts();
            Console.WriteLine("Press any Key to continue...");
            Console.ReadKey();

        }

        private static void ViewContacts()
        {
            
            Console.WriteLine("Contacts");
            for (int i = 0; i < contacts.Count; i++)
            {
                Console.WriteLine("Name : {0} and MailID : {1}", contacts[i].Name, contacts[i].Mailid);
            }
            Console.ReadKey();
            
        }

        static void AddContact()
        {
            
            Console.WriteLine("Add Contact");

            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter MailID");
            string mailid = Console.ReadLine();

            contacts.Add(new Contact(name, mailid));

            Console.WriteLine("Contact added successfully!");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}

class Contact
{
    public string Name { get; set; }
    public string Mailid { get; set; }

    public Contact(string name, string mailid)
    {
        this.Name = name;
        this.Mailid = mailid;
    }

}

