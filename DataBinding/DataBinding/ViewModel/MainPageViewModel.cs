using DataBinding.Model;
using System;
using System.Collections.Generic;

namespace DataBinding.ViewModel
{
    public class MainPageViewModel
    {
        public List<Contact> Contacts { get; set; }

        public MainPageViewModel()
        {

            Contacts = new List<Contact>();
            var listOfContacts = ContactGenerator.CreateContacts();
            Contacts = listOfContacts;

        }
    }
}
