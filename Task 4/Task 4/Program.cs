using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("My Awesome Contact Manager");
Console.WriteLine("Welcome to your contact list");

ContactManager contactManager = new ContactManager();
bool running = true;

while (running)
{
    Console.WriteLine("\nMain Menu:");
    Console.Write("1. Add Contact      ");
    Console.Write("2. View Contacts     ");
    Console.Write("3. Search Contacts      ");
    Console.Write("4. Edit Contact        ");
    Console.Write("5. Delete Contact     ");
    Console.WriteLine("6. Exit");
    Console.Write("Choose an option: ");

    if (int.TryParse(Console.ReadLine(), out int choice))
    {
        switch (choice)
        {
            case 1:
                contactManager.AddContact();
                break;
            case 2:
                contactManager.ViewContacts();
                break;
            case 3:
                contactManager.SearchContact();
                break;
            case 4:
                contactManager.EditContact();
                break;
            case 5:
                contactManager.DeleteContact();
                break;
            case 6:
                running = false;
                Console.WriteLine("Goodbye!");
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid number.");
    }
}


public class Contact
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }

    public Contact(int id, string name, string phone, string email, string address)
    {
        Id = id;
        Name = name;
        Phone = phone;
        Email = email;
        Address = address;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Phone: {Phone}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Address: {Address}");
    }

    public void DisplayInList()
    {
        Console.WriteLine($"{Id,-4} {Name,-15} {Phone,-15} {Email,-20} {Address}");
    }
}


public class ContactManager
{
    private List<Contact> contacts;
    private int nextId;

    public ContactManager()
    {
        contacts = new List<Contact>();
        nextId = 1;
    }

    public void AddContact()
    {
        Console.WriteLine("\n--- Add New Contact ---");

        Console.Write("Enter Name: ");
        string name = Console.ReadLine() ?? "";

        Console.Write("Enter Phone: ");
        string phone = Console.ReadLine() ?? "";

        Console.Write("Enter Email: ");
        string email = Console.ReadLine() ?? "";

        Console.Write("Enter Address: ");
        string address = Console.ReadLine() ?? "";

        
        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone))
        {
            Console.WriteLine("Error: Name and phone are required.");
            return;
        }

        
        if (contacts.Any(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine($"A contact with the name '{name}' already exists.");
            return;
        }

        Contact newContact = new Contact(nextId, name, phone, email, address);
        contacts.Add(newContact);
        nextId++;

        Console.WriteLine($"\n✅ Contact '{name}' added successfully (ID: {newContact.Id})");
    }

    public void ViewContacts()
    {
        Console.WriteLine("\n--- Contact List ---");

        if (contacts.Count == 0)
        {
            Console.WriteLine("No contacts in the manager.");
            return;
        }

        Console.WriteLine("ID   Name            Phone           Email               Address");
        Console.WriteLine("-------------------------------------------------------------------");

        foreach (var contact in contacts.OrderBy(c => c.Name))
        {
            contact.DisplayInList();
        }

        Console.WriteLine($"\nTotal: {contacts.Count} contacts");
    }

    public void SearchContact()
    {
        Console.WriteLine("\n--- Search Contact ---");

        if (contacts.Count == 0)
        {
            Console.WriteLine("No contacts in the manager.");
            return;
        }

        Console.WriteLine("Search options:");
        Console.WriteLine("1. By ID");
        Console.WriteLine("2. By Name");
        Console.WriteLine("3. By Phone");
        Console.Write("Choose an option: ");

        if (int.TryParse(Console.ReadLine(), out int searchOption))
        {
            List<Contact> results = new List<Contact>();

            switch (searchOption)
            {
                case 1:
                    Console.Write("Enter contact ID: ");
                    if (int.TryParse(Console.ReadLine(), out int searchId))
                    {
                        var contact = contacts.FirstOrDefault(c => c.Id == searchId);
                        if (contact != null)
                            results.Add(contact);
                    }
                    break;

                case 2:
                    Console.Write("Enter name to search: ");
                    string searchName = Console.ReadLine() ?? "";
                    results = contacts.Where(c =>
                        c.Name.Contains(searchName, StringComparison.OrdinalIgnoreCase)).ToList();
                    break;

                case 3:
                    Console.Write("Enter phone to search: ");
                    string searchPhone = Console.ReadLine() ?? "";
                    results = contacts.Where(c =>
                        c.Phone.Contains(searchPhone)).ToList();
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }

            DisplaySearchResults(results);
        }
        else
        {
            Console.WriteLine("Invalid option.");
        }
    }

    private void DisplaySearchResults(List<Contact> results)
    {
        if (results.Count == 0)
        {
            Console.WriteLine("No contacts found.");
            return;
        }

        Console.WriteLine($"\n--- Search Results ({results.Count} found) ---");
        foreach (var contact in results)
        {
            Console.WriteLine("\n" + new string('-', 40));
            contact.DisplayInfo();
        }
    }

    public void EditContact()
    {
        Console.WriteLine("\n--- Edit Contact ---");

        if (contacts.Count == 0)
        {
            Console.WriteLine("No contacts in the manager.");
            return;
        }

        ViewContacts();
        Console.Write("\nEnter the ID of the contact to edit: ");

        if (int.TryParse(Console.ReadLine(), out int selectedId))
        {
            var contact = contacts.FirstOrDefault(c => c.Id == selectedId);

            if (contact == null)
            {
                Console.WriteLine("No contact found with that ID.");
                return;
            }

            Console.WriteLine("\nSelected contact:");
            contact.DisplayInfo();

            Console.WriteLine("\nEnter new data (leave blank to keep current value):");

            Console.Write($"Name [{contact.Name}]: ");
            string newName = Console.ReadLine() ?? "";
            if (!string.IsNullOrWhiteSpace(newName))
                contact.Name = newName;

            Console.Write($"Phone [{contact.Phone}]: ");
            string newPhone = Console.ReadLine() ?? "";
            if (!string.IsNullOrWhiteSpace(newPhone))
                contact.Phone = newPhone;

            Console.Write($"Email [{contact.Email}]: ");
            string newEmail = Console.ReadLine() ?? "";
            contact.Email = newEmail;

            Console.Write($"Address [{contact.Address}]: ");
            string newAddress = Console.ReadLine() ?? "";
            contact.Address = newAddress;

            Console.WriteLine($"\n✅ Contact '{contact.Name}' updated successfully.");
        }
        else
        {
            Console.WriteLine("Invalid ID.");
        }
    }

    public void DeleteContact()
    {
        Console.WriteLine("\n--- Delete Contact ---");

        if (contacts.Count == 0)
        {
            Console.WriteLine("No contacts in the manager.");
            return;
        }

        ViewContacts();
        Console.Write("\nEnter the ID of the contact to delete: ");

        if (int.TryParse(Console.ReadLine(), out int selectedId))
        {
            var contact = contacts.FirstOrDefault(c => c.Id == selectedId);

            if (contact == null)
            {
                Console.WriteLine("No contact found with that ID.");
                return;
            }

            Console.WriteLine("\nContact to delete:");
            contact.DisplayInfo();

            Console.Write("\nAre you sure you want to delete this contact? (Y/N): ");
            string confirmation = Console.ReadLine() ?? "";

            if (confirmation.Equals("Y", StringComparison.OrdinalIgnoreCase) ||
                confirmation.Equals("YES", StringComparison.OrdinalIgnoreCase))
            {
                contacts.Remove(contact);
                Console.WriteLine($"\n✅ Contact '{contact.Name}' deleted successfully.");
            }
            else
            {
                Console.WriteLine("Deletion cancelled.");
            }
        }
        else
        {
            Console.WriteLine("Invalid ID.");
        }
    }

    
    public int TotalContacts()
    {
        return contacts.Count;
    }

    public bool ContactExists(int id)
    {
        return contacts.Any(c => c.Id == id);
    }

    public Contact GetContact(int id)
    {
        return contacts.FirstOrDefault(c => c.Id == id);
    }
}