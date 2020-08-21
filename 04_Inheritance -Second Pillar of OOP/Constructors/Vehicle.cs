﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initialized.");
        //}

        public Vehicle(string registrationNumber)
        {
            this._registrationNumber = registrationNumber;

            Console.WriteLine("Vehicle is being initialized. {0}", registrationNumber);
        }
    }
}