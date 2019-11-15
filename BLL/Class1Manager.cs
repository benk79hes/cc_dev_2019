using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using DAL;
using DTO;

namespace BLL
{
    public class Class1Manager
    {
        public Class1DB Class1DB { get; }

        public Class1Manager(IConfiguration configuration)
        {
            Class1DB = new Class1DB(configuration);
        }

        public List<Class1> GetAllClass1()
        {
            return Class1DB.GetAllClass1();
        }

    }
}
