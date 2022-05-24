using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class FreeBookDbContext:IdentityDbContext
    {
        public FreeBookDbContext(DbContextOptions<FreeBookDbContext> options):base (options)
        {


        }
    }
}
