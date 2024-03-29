﻿using System;
using System.Collections.Generic;
using System.Text;
using ClinicApp.HelperClasses;

namespace ClinicApp.Users
{
    public abstract class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public char Gender { get; set; }
        public Roles Role { get; set; }
        public MessageBox MessageBox { get; set; }

        public abstract string Compress();
        public abstract int MenuWrite(); //Returns the number of options the user can choose from in the menu.
        public abstract void MenuDo(int option); //Executes the chosen option.
        public void Print(bool withRole = false)
        {
            Console.WriteLine("Username: " + UserName);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Last name: " + LastName);
            Console.WriteLine("Date of birth: " + DateOfBirth.ToString("dd/MM/yyyy"));
            Console.WriteLine("Gender: " + Gender);
            if(withRole)
                Console.WriteLine("Role: " + Role.ToString());
        }
        public string TextInTable(bool withRole = false)
        {
            string text = "| ";
            text += UserName + OtherFunctions.Space(20, UserName) + " | ";
            text += Name + OtherFunctions.Space(20, Name) + " | ";
            text += LastName + OtherFunctions.Space(20, LastName) + " | ";
            text += Gender + OtherFunctions.Space(10, "" + Gender) + " | ";
            text += DateOfBirth.ToString("dd/MM/yyyy") + OtherFunctions.Space(15, DateOfBirth.ToString("dd/MM/yyyy")) + " |";
            if(withRole)
                text += " " + Role.ToString() + OtherFunctions.Space(10, UserName) + " |";
            return text;
        }
    }
}
