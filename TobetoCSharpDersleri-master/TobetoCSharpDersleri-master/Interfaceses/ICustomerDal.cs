using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceses
{
    internal interface ICustomerDal
    {
        //veritabanı işlemlerini Dal şeklinde yaparız.
        void Add();
        void Update();
        void Delete();

    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add() {
            Console.WriteLine("SQL added");
        }

        public void Update()
        {
            Console.WriteLine("SQL Updated");
        }

        public void Delete()
        {
            Console.WriteLine("SQL Deleted");
        }
    }

    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL added");
        }

        public void Update()
        {
            Console.WriteLine("SQL Updated");
        }

        public void Delete()
        {
            Console.WriteLine("SQL Deleted");
        }
    }

    class CustomeManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
