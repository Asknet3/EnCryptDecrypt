using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WcfService
{
    public class Nome_Code
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }

    public class Nome_CodeContext : DbContext
    {
        public DbSet<Nome_Code> Names_Codes { get; set; }
    }
}