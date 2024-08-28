using System.Net.Http.Headers;
using System.Text;
using System.Xml.Serialization;

namespace ContactManagementSystem
{
    public class ContactManager
    {
        static string currentDirectory = Directory.GetCurrentDirectory();
        static string pathDirectory = Path.GetFullPath(Path.Combine(currentDirectory, @"..\..\..\"));
        static string path = Path.Combine(pathDirectory, "contacts.txt");
        static void Main(string[] args)

        {
            Console.WriteLine("Contact Management System");
            Console.WriteLine("1. Add a Contact");
            Console.WriteLine("2. View All Contacts");
            Console.WriteLine("3. Edit a Contact");
            Console.WriteLine("4. Delete a Contact");
            Console.WriteLine("5. Exit");
            string command=Console.ReadLine();
            while(command!="5")
            {
                switch (command)
                {
                    case "1":
                        {
                            AddContact();
                            break;
                        };
                    case "2":
                        {
                            ViewAllContacts();
                            break;
                        }
                    case "3":
                        {
                            EditContact();
                            break;
                        }
                    case "4":
                        {
                           DeleteContact();
                            break;
                        }

                }
                Console.WriteLine("Enter new command:");
                command = Console.ReadLine();
            }
        }
        public static void SavingInFile(string line)
        {
            if (File.Exists(path))
            {
                try
                {
                        File.AppendAllText(path,line+Environment.NewLine);
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            else
            {
                File.WriteAllText(path, line + Environment.NewLine);
            }
        }
        public static void AddContact()
        {
            Console.WriteLine("Name:");
            string name=Console.ReadLine();
            Console.WriteLine("Phone number:");
            string phone=Console.ReadLine();
            Console.WriteLine("Email address:");
            string email=Console.ReadLine();
            string contact = $"{name}, {phone}, {email}";
            SavingInFile(contact);

        }
        public static void ViewAllContacts()
        {
            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        Console.WriteLine("All Contacts");
                        int count = 1;
                        string command= sr.ReadLine();  
                        while (command != null)
                        {
                            string[] line = command.Split(',');
                            Console.WriteLine($"{count}. {line[0]} {line[1]} {line[2]}");
                            count++;
                            command = sr.ReadLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("The list is empthy.");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static void EditContact()
        {
            Console.WriteLine("Enter the name of the contact you want to edit:");
            string oldName=Console.ReadLine();
            Console.WriteLine("Edit name:");
            string newName=Console.ReadLine();
            Console.WriteLine("Edit Phone:");
            string newPhone=Console.ReadLine();
            Console.WriteLine("Edit email:");
            string newEmail=Console.ReadLine();
            StringBuilder newFile = new StringBuilder();
            bool found = false;
            if(File.Exists(path))
            {
                try 
                {
                    using (StreamReader sr=new StreamReader(path))
                    {
                        string line = sr.ReadLine();
                        string[] contact;
                        while(line!=null)
                        {
                            contact = line.Split(",");
                            if (contact[0]==oldName)
                            {
                                line = $"{newName}, {newPhone}, {newEmail}";
                                found = true;
                            }
                            newFile.AppendLine(line);
                            line = sr.ReadLine();
                        }
                    }
                    if(!found)
                    {
                        Console.WriteLine("Not contact with that name is found");
                    }
                    else
                    {
                        File.WriteAllText(path, newFile.ToString());
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("There isn't any contacts saved yet.");
            }
        }
        public static void DeleteContact()
        {
            Console.WriteLine("Enter the name of the contact you want to delete:");
            string name = Console.ReadLine();
            StringBuilder newFile = new StringBuilder();
            bool found = false;
            if (File.Exists(path))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        string line = sr.ReadLine();
                        string[] contact;
                        while (line != null)
                        {
                            contact = line.Split(",");
                            if (contact[0] == name)
                            {
                                found = true;
                            }
                            else
                            {
                                newFile.AppendLine(line);
                            }
                            line = sr.ReadLine();
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("Not contact with that name is found");
                    }
                    else
                    {
                        Console.WriteLine($"Contact with {name} is deleted successfully!");
                        File.WriteAllText(path, newFile.ToString());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("There isn't any contacts saved yet.");
            }
        }
    }
}
