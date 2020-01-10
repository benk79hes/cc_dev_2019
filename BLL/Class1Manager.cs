using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using DAL;
using DTO;

namespace BLL
{
    public class Class1Manager : IClass1Manager
    {
        private IClass1DB class1DB { get; }

        public Class1Manager(IClass1DB class1DB)
        {
            this.class1DB = class1DB;
        }

        public List<Class1> GetAllClass1()
        {
            return class1DB.GetAllClass1();
        }

    }
}
