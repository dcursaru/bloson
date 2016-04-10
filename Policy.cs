using System;
using System.Diagnostics;

namespace ConsoleApplication
{
    internal class Policy
    {
        private readonly string _policyNumber;

        public Policy(string policyNumber)
        {
            _policyNumber = policyNumber;
            PolicyNumber = policyNumber;
        }

        public string PolicyNumber { get; private set; }

        private void Test()
        {
            const int age = 10;
            Debug.Print(Format("My age is {0}", age.ToString()));
        }

        public void Test(string name)
        {
            if (name != null) Debug.Print($"My name is {name}");
        }
    }
}