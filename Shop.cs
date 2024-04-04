using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Shop
    {
        private string _name {  get; set; }
        private string _description { get; set; }
        private string _address {  get; set; }
        private string _phone { get; set; }
        private string _email { get; set; }
        public Shop()
        {
            _name = string.Empty;
            _description = string.Empty;
            _address = string.Empty;
            _phone = string.Empty;
            _email = string.Empty;
        }
        public Shop(string name):this()
        { _name = name; }
        public Shop(string name,string description):this(name)
        { _description = description; }
        public Shop(string name, string description, string address):this(name,description)
        { _address = address; }
        public Shop(string name, string description, string address,string phone):this(name, description,address)
        { _phone = phone; }
        public Shop(string name, string description, string address, string phone,string email) : this(name, description, address,phone)
        { _email = email; }
        public void ShowInformShop()
        {
            Console.WriteLine($"Name: {_name ?? "no name"}");
            Console.WriteLine($"Description: {_description ?? "no description"}");
            Console.WriteLine($"Address: {_address ?? "no address"}");
            Console.WriteLine($"Phone: {_phone ?? "no phone"}");
            Console.WriteLine($"Email: {_email ?? "no email"}");

        }



    }
}
