using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace ConsoleAppExercise
{
    class ID
    {
        string name;
        string surname;
        string hometown;
        int age;
        char gender;
        public string NAME
        {
            get { return name; }
            set { name = value.ToLower(); }
        }
        public string SURNAME
        {
            get { return surname; }
            set { surname = value.ToUpper(); }
        }
        public string HOMETOWN
        {
            get { return hometown; }
            set { hometown = value; }
        }
        public int AGE
        {
            get { return age; }
            set { age = value; }
        }
        public char GENDER
        {
            get { return gender; }
            set { gender = value; }
        }
        public ID()
        {
            name = "";
            surname = "";
            age = 18;
            gender = 'W';
            hometown = "Ankara";
        }
    }
}
