using System;
using System.Data;
using ContactsDataAccessLayer;

namespace ContactsBusinessLayer
{
    public class clsCountry
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public string Code { get; set; }
        public string PhoneCode { get; set; }

        enum enMode { AddNew = 1, Update = 2 }
        enMode Mode;

        private clsCountry(int ID, string CountryName,string Code,string PhoneCode)
        {
            this.CountryID = ID;
            this.CountryName = CountryName;
            this.Code = Code;
            this.PhoneCode = PhoneCode;
            Mode = enMode.Update;
        }

        public clsCountry()
        {
            CountryID = -1;
            CountryName = string.Empty;
            Code = string.Empty;
            PhoneCode = string.Empty;
            Mode = enMode.AddNew;
        }

        private bool _AddNewCountry()
        {
            this.CountryID = clsCountriesData.AddNewCountry(this.CountryName,this.Code,this.PhoneCode);

            return (CountryID != -1);
        }

        private bool _UpdateCountry()
        {
            return clsCountriesData.UpdateCountry(this.CountryID, this.CountryName,this.Code,this.PhoneCode);
        }

        public static clsCountry FindCountry(int ID)
        {
            string CountryName = "", Code ="",PhoneCode ="" ;
            if (clsCountriesData.Find(ID, ref CountryName,ref Code,ref PhoneCode))
            {
                return new clsCountry(ID, CountryName,Code,PhoneCode);
            }
            return null;

        }

        public static clsCountry FindCountry(string CountryName)
        {
            int Id = 0;
            string Code = "", PhoneCode = "";

            if (clsCountriesData.Find(ref Id, CountryName ,ref Code, ref PhoneCode))
            {
                return new clsCountry(Id, CountryName,Code,PhoneCode);
            }
            return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCountry())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    break;
                case enMode.Update:
                    return _UpdateCountry();
            }
            return false;
        }

        public static bool DeleteCountry(int CountryId)
        {
            return clsCountriesData.DeleteCountry(CountryId);
        }

        public static DataTable GetAllCountries()
        {
            return clsCountriesData.GetAllCountries();
        }

        public static bool IsCountryExist(int CountryId)
        {
            return clsCountriesData.IsCountryExist(CountryId);
        }
        public static bool IsCountryExist(string CountryName)
        {
            return clsCountriesData.IsCountryExist(CountryName);
        }

    }
}
