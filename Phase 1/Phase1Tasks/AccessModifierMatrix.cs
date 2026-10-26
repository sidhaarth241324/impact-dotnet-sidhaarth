using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public class AccessModifierMatrix
    {
        public string publicField = "Public";
        private string privateField = "Private";
        protected string protectedField = "Protected";
        internal string internalField = "Internal";

        protected internal string protectedInternalField = "Protected Internal";
        private protected string privateProtectedField = "Private Protected";

        public void DisplayFields()
        {
            Console.WriteLine(publicField);
            Console.WriteLine(privateField);
            Console.WriteLine(protectedField);
            Console.WriteLine(internalField);
            Console.WriteLine(protectedInternalField);
            Console.WriteLine(privateProtectedField);
            //All these members can be accessed inside this class.
        }
    }

    public class DerivedClass : AccessModifierMatrix
    {
        public void DisplayDerivedFields()
        {
            Console.WriteLine(publicField); // Accessible
            //Console.WriteLine(privateField); // Not Accessible
            Console.WriteLine(protectedField); // Accessible
            Console.WriteLine(internalField); // Accessible
            Console.WriteLine(protectedInternalField); // Accessible
            Console.WriteLine(privateProtectedField); // Accessible
        }
    }
}
