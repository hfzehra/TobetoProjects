using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tobeto.Core.Persistance.Repositories;

namespace Domain.Entities
{
    public class Category :Entity<int>
    {
        public string Name { get; set; }

        public Category() { }
        public Category(int id, string name) :this() 
        {
            Id = id;
            Name = name;
        }
    }
}
