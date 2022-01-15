using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodDaVinci
{
    struct Postac
    {
        public string name;
        public string surname;
        public int age;
        public string profession;
        public string hobby;
        public Postac(string name_, string surname_, int age_, string profession_, string hobby_)
        {
            name = name_;
            surname = surname_;
            age = age_;
            profession = profession_;
            hobby = hobby_;
        }
    }
}
