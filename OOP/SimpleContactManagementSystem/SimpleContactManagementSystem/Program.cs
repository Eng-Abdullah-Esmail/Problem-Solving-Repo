using System;
using System.Collections.Generic;

class Contact
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }

    public Contact(string name, string phoneNumber, string email, string address)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
        Address = address;
    }

    public override string ToString()
    {
        return string.Format("{0}, {1}, {2}, {3}", Name, PhoneNumber, Email, Address);
    }
}

class ContactManager
{
    private List<Contact> contacts;

    public ContactManager()
    {
        contacts = new List<Contact>();
    }

    public void AddContact(string name, string phoneNumber, string email, string address)
    {
        Contact contact = new Contact(name, phoneNumber, email, address);
        contacts.Add(contact);
    }

    public void RemoveContact(Contact contact)
    {
        contacts.Remove(contact);
    }

    public List<Contact> GetAllContacts()
    {
        return contacts;
    }

    public Contact GetContactByName(string name)
    {
        return contacts.Find(c => c.Name == name);
    }

    public List<Contact> GetContactsByAddress(string address)
    {
        return contacts.FindAll(c => c.Address == address);
    }
}

class Program
{
    static void Main(string[] args)
    {
        ContactManager contactManager = new ContactManager();

        contactManager.AddContact("John Smith", "555-1234", "john@example.com", "123 Main St");
        contactManager.AddContact("Jane Doe", "555-5678", "jane@example.com", "456 Elm St");

        Contact foundContact = contactManager.GetContactByName("Jane Doe");
        Console.WriteLine("Found contact: {0}", foundContact);

        List<Contact> allContacts = contactManager.GetAllContacts();
        Console.WriteLine("All contacts:");
        foreach (Contact contact in allContacts)
        {
            Console.WriteLine(contact);
        }

        List<Contact> matchingContacts = contactManager.GetContactsByAddress("123 Main St");
        Console.WriteLine("Matching contacts:");
        foreach (Contact contact in matchingContacts)
        {
            Console.WriteLine(contact);
        }
        Console.ReadKey();
    }
}