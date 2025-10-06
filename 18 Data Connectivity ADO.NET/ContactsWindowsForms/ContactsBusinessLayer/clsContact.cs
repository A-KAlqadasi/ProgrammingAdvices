using System;
using System.Data;
using ContactsDataAccessLayer;

namespace ContactsBusinessLayer
{
    public class clsContact
    {
        enum enMode {AddNew=1 , Update=2 }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int CountryID { get; set; }
        public string ImagePath { get; set; }
         enMode Mode  ;
        public clsContact()
        {
            ID = -1;
            FirstName = string.Empty;
            LastName = string.Empty;
            Birthdate = DateTime.Now;
            Email = string.Empty;
            Phone = string.Empty;
            Address = string.Empty;
            CountryID = -1;
            ImagePath = string.Empty;
            Mode = enMode.AddNew;
        }


        private clsContact(int id , string firstName , string lastName , DateTime birthdate ,string email,string phone,
            string address , int countryId , string imagePath)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthdate;
            Email = email;
            Phone = phone;
            Address = address;
            CountryID = countryId;
            ImagePath = imagePath;
            Mode = enMode.Update;
        }


        private bool _AddNewContact()
        {

           this.ID  = clsContactData.InsertNewContact(FirstName,LastName, Birthdate, 
                        Email,Phone,Address,CountryID,ImagePath);
            
            return (this.ID != -1);
        }
        private bool _UpdateContact()
        {
            return clsContactData.UpdateContact(ID,FirstName,LastName,Birthdate,Email,Phone,Address,CountryID,ImagePath);

        }
        public static clsContact Find(int ID)
        {
            string firstName = "", lastName = "", email = "", phone = "", address = "", imagePath = "";
            int countryId = -1;
            DateTime birthdate =DateTime.Now; 

            if(clsContactData.GetContactInfoById(ID,ref firstName,ref lastName,
                ref birthdate,ref email, ref phone , ref address, ref countryId ,ref imagePath) )
            {
                return new clsContact(ID ,firstName,lastName,
                    birthdate,email,phone,address,countryId,imagePath);
            }
            else 
                return null;

        }

        public static bool DeleteContact(int ID)
        {
            return clsContactData.DeleteContact(ID);
        }

        public static DataTable GetAllContacts()
        {
            return clsContactData.GetAllContacts();
        }

        public static bool IsContactExist(int ContactId)
        {
            return clsContactData.IsContactExist(ContactId);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewContact())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;
                    }
                    break;
                case enMode.Update:
                    return _UpdateContact();

            }
            return false;
        }



    }
}
