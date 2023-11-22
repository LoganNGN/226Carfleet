﻿using System.Collections.Generic;
using System.IO.Pipes;
using System.Threading;

namespace Carfleet
{
    public class Person
    {
        #region private attributes
        private string _name;
        private string _firstname;
        private string _phonenumber;
        private string _emailaddress;
        private List<string> _languages;
        #endregion private attributes

        #region public methods
        public Person(string name, string firstname, string phonenumber, string emailaddress, List<string> languages = null)
        {
            _name = name;
            _firstname = firstname;
            _phonenumber = phonenumber;
            _emailaddress = emailaddress;
            _languages = languages;
        }

        public string Name
        {
            get 
            { 
                return _name; 
            }
            set
            {
                _name = value;
            }
        }

        public string Firstname
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
            }
        }

        public string Phonenumber
        {
            get
            {
                return _phonenumber;
            }
            set { _phonenumber = value; }
        }

        public string Emailaddress
        {
            get
            {
                return _emailaddress;
            }
            set
            {
                _emailaddress = value;
            }
        }

        public List<string> Languages
        {
            get
            {
                return _languages;
            }
            set 
            { 
                _languages = value;
            }
        }
        #endregion public methods
    }
}