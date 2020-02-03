using Domain.Modules.BlogInfoAgg;
using Domain.Seedwork;
using Infrastructure.Data.Seedwork;
using Infrastructure.Data.Seedwork.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Data.UnitOfWorks
{
    public class UnitOfWorkDbContext : BaseContext, IQueryableUnitOfWork
    {
        #region Constructors
        public UnitOfWorkDbContext()
        {

        }

        public UnitOfWorkDbContext(DbContextOptions<UnitOfWorkDbContext> options)
            : base(options)
        {
        }

        #endregion

        #region DbSet Members

        public DbSet<BlogInfo> BlogInfo { get; set; }

        #endregion


    }

}
