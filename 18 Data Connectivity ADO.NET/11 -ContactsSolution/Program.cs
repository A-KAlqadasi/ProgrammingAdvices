using System;
using System.Data;
using System.Diagnostics.Contracts;
using System.Xml.Linq;
using ContactsBusinessLayer;


namespace ContactsSolution
{
    internal class Program
    {

        public static void TestFindContact(int ID)
        {
            clsContact contact = clsContact.Find(ID);

            if (contact !=null)
            {
                Console.WriteLine($"ID        : {contact.ID}");
                Console.WriteLine($"FirstName : {contact.FirstName}");
                Console.WriteLine($"LastName  : {contact.LastName}");
                Console.WriteLine($"BirthDate : {contact.Birthdate.ToString()}");
                Console.WriteLine($"Email     : {contact.Email}");
                Console.WriteLine($"Phone     : {contact.Phone}");
                Console.WriteLine($"CountryId : {contact.CountryID}");
                Console.WriteLine($"Image Path: {contact.ImagePath}");
            }
            else
            {
                Console.WriteLine($"Contact with Id[{ID}] not found!.");
            }
        }

        public static void TestAddNewContact()
        {
            clsContact contact1 = new clsContact();
            contact1.FirstName = "mohammed";
            contact1.LastName = "Basheer";
            contact1.Birthdate = new DateTime(2004, 6, 1);
            contact1.Email = "mohammed@gmail.com";
            contact1.Address = "123 Estanbul main street";
            contact1.Phone = "010001";
            contact1.CountryID = 6;
            contact1.ImagePath = "";

            if(contact1.Save())
            {
                Console.WriteLine($"New contact inserted successfully with ID {contact1.ID}");
            }
            else
            {
                Console.WriteLine("Adding new contact faild :-(");
            }

        }
        
        public static void TestUpdateContact(int ContactID)
        {
            clsContact contact1 = clsContact.Find(ContactID);

            if (contact1 != null)
            {
                contact1.ID = ContactID;
                contact1.FirstName = "Lean";
                contact1.LastName = "Abdulkawi";
                contact1.Birthdate = new DateTime(2015, 3, 1);
                contact1.Email = "lean@gmail.com";
                contact1.Address = "123 main street";
                contact1.Phone = "010001";
                contact1.CountryID = 6;
                contact1.ImagePath = "";
                
                if (contact1.Save())
                {
                    Console.WriteLine("Contact updated successfully");
                }

            }
            else
            {
                Console.WriteLine("Contact Not Found");
            }
           

        }

        public static void TestDeleteContact(int  ContactID)
        {

            if (clsContact.IsContactExist(ContactID))
            {
                if (clsContact.DeleteContact(ContactID))
                {
                    Console.WriteLine("Contact deleted Successfully");
                }
                else
                {
                    Console.WriteLine("Contact deletion faild!");
                }
            }
            else
            {
                Console.WriteLine($"Contact With Id {ContactID} is not found");
            }

            
        }

        public static void TestListAllContacts()
        {
            DataTable dataTable = clsContact.GetAllContacts();
            Console.WriteLine("Contact Data");
            Console.WriteLine("ID  Full Name");
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine($"{row["ContactID"]}    {row["FirstName"]}  {row["LastName"]}");
            }
        }

        public static void TestIsContactExist(int ContactID)
        {
            if(clsContact.IsContactExist(ContactID))
            {
                Console.WriteLine($"Contact With Id {ContactID} is exist");
            }
            else
            {
                Console.WriteLine($"Contact With Id {ContactID} is not exist");
            }
        }

        // ----------------------------------Countries
        static void TestFindCountry(int CountryId)
        {
            clsCountries country = clsCountries.FindCountry(CountryId);
            if (country != null)
            {
                Console.WriteLine($"ID         :{country.CountryID}");
                Console.WriteLine($"Name       :{country.CountryName}");
                Console.WriteLine($"Code       :{country.Code}");
                Console.WriteLine($"PhoneCode  :{country.PhoneCode}");

                Console.WriteLine("---------------");

            }
            else
            {
                Console.WriteLine($"Country with ID {CountryId} is not found");
            }
        }

        static void TestFindCountry(string CountryName)
        {
            clsCountries country = clsCountries.FindCountry(CountryName);
            if (country != null)
            {
                Console.WriteLine($"ID         :{country.CountryID}");
                Console.WriteLine($"Name       :{country.CountryName}");
                Console.WriteLine($"Code       :{country.Code}");
                Console.WriteLine($"PhoneCode  :{country.PhoneCode}");

                Console.WriteLine("---------------");
            }
            else
            {
                Console.WriteLine($"Country with Name {CountryName} is not found");
            }
        }

        static void TestAddNewCountry()
        {
            clsCountries country = new clsCountries();
            country.CountryName = "Yemen";
            country.Code = "";
            country.PhoneCode = "";

            if (country.Save())
            {
                Console.WriteLine("Country Added successfully with Id " + country.CountryID);
            }
            else
            {
                Console.WriteLine("Country adding faild!");
            }

        }

        static void TestUpdateCountry(int CountryId)
        {
            clsCountries country = clsCountries.FindCountry(CountryId);
            if (country != null)
            {
                country.CountryName = "Yemen";
                country.Code = "Ye";
                country.PhoneCode = "967";
                if (country.Save())
                {
                    Console.WriteLine("Country updated successfully!");
                }
            }
            else
            {
                Console.WriteLine("country is not found");
            }


        }

        static void TestDeleteCountry(int CountryId)
        {
            if (clsCountries.IsCountryExist(CountryId))
            {
                if (clsCountries.DeleteCountry(CountryId))
                {
                    Console.WriteLine("Country Deleted Successfully!");
                }
                else
                {
                    Console.WriteLine("Country deletion failed!");
                }
            }
            else
            {
                Console.WriteLine($"Country with Id {CountryId} is not exist");
            }

        }

        static void TestListAllCountries()
        {
            DataTable dataTable = clsCountries.GetAllCountries();
            Console.WriteLine("Countries Data");
            if (dataTable != null)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    Console.WriteLine($"{row["CountryID"]},  {row["CountryName"]} , {row["Code"]}, {row["PhoneCode"]}");
                }
                Console.WriteLine("-----------------------");
            }
            else
            {
                Console.WriteLine("No Countries available in the system");
            }
        }

        static void TestIsExistCountry(int CountryID)
        {
            if (clsCountries.IsCountryExist(CountryID))
            {
                Console.WriteLine($"Country with Id {CountryID} is exist");
            }
            else
            {
                Console.WriteLine($"Country with Id {CountryID} is not exist");
            }
        }

        static void TestIsExistCountry(string CountryName)
        {
            if (clsCountries.IsCountryExist(CountryName))
            {
                Console.WriteLine($"Country with Name [{CountryName}] is exist");
            }
            else
            {
                Console.WriteLine($"Country with Name [{CountryName}] is not exist");
            }
        }

        static void Main(string[] args)
        {

            //---------------------------- Contacts 
            //TestFindContact(6);

            //TestAddNewContact();
            //TestUpdateContact(1);
            // TestDeleteContact(100);
            //TestListAllContacts();
            //TestIsContactExist(1);
            //TestIsContactExist(100);

            //----------------------------Countries

            //TestFindCountry(6);
            //TestFindCountry("Yemen");
            //TestAddNewCountry();
            //TestUpdateCountry(6);

            //TestDeleteCountry(12);
            //TestListAllCountries();
            //TestIsExistCountry(1);
            //TestIsExistCountry(100);
            //TestIsExistCountry("Yemen");



            Console.ReadKey();

        }
    }
}
