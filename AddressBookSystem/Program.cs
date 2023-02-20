﻿namespace AddressBookSystem
{
    
        internal class Program
        {
        static void Main(string[] args)
        {   //print Message
            Console.WriteLine("Welcome to Address Book  System");

            //Create contact
            CreateContact.PersonDetails();
            Console.ReadLine();

            //add a new contact
            AddContact.GetCustomer();
            AddContact.ListingPeople();

            // Modify existing contact
            EditContact.GetCustomer();
            EditContact.Modify();
            EditContact.ListingPeople();

            //delete a person          
            DeleteContact.GetCustomer();
            DeleteContact.Modify();
            DeleteContact.ListingPeople();
            DeleteContact.RemovePeople();

        }
    }
    }
