﻿using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer {DateOfBirth = new DateTime(1995,01,31), FirstName = "Ebru", LastName ="Gedikli", NationalityId = "12345678910" });

        }
    }
}
