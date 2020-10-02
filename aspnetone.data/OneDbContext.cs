using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace aspnetone.data
{
    public class OneDbContext : DbContext
    {
        public OneDbContext(DbContextOptions<OneDbContext> options) : base(options)
        {

        }
    }
}
