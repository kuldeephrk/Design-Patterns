using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Policy
    {
        private int Id { get; set; } = 123;
        private string Insured { get; set; } = "John Roy";
        // Method 1
        private static Policy _instance;
        public static Policy Instance => _instance ?? (_instance = new Policy());
        // Method 2
        private static readonly Policy _instance2 = new Policy();
        public static Policy Instance2 => _instance2;

        public Policy() { }
        public string GetInsuredName() => Insured;
    }
}
