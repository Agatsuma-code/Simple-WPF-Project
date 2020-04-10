using PhoneBook.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Models {
    public class ModelContext : DbContext{
        public ModelContext() : base("name = con") {}
        public DbSet<Contact> ContactList { get; set; }
    }
}
