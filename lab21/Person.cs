using System;
using System.Collections.Generic;
using System.Text;

namespace lab21
{
    class Person
    {
        private string name;

        public string Name
        { 
            get { return name; }
            set { name = value; }
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Person p = obj as Person;
            if (p == null)
                return false;
            else
                return this.Name.Equals(p.Name);
        }
    }


}
