using System;
using Amazon;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            // cannot access RateCalculator because Its in another assembly as internal
            Amazon.RateCalculator calculator = new RateCalculator();
        }
    }
}
