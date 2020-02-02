using Infrastructure.Data.Seedwork.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.UnitOfWorks
{
    public class UnitOfWork : BaseContext
    {
        #region Constructors
        public UnitOfWork()
        {

        }

        public UnitOfWork(DbContextOptions<UnitOfWork> options)
            : base(options)
        {
        }

        #endregion

        #region DbSet Members



        //public DbSet<BlogInfo> BlogInfo { get; set; }

        //public DbSet<BlogClass> BlogClass { get; set; }

        //public DbSet<BlogArticle> BlogArticle { get; set; }


        //DbSet<Customer> _customers;
        //public virtual DbSet<Customer> Customers
        //{
        //    get
        //    {
        //        if (_customers == null)
        //            _customers = base.Set<Customer>();

        //        return _customers;
        //    }
        //}

        //DbSet<Product> _products;
        //public virtual DbSet<Product> Products
        //{
        //    get
        //    {
        //        if (_products == null)
        //            _products = base.Set<Product>();

        //        return _products;
        //    }
        //}

        //DbSet<Software> _software;
        //public virtual DbSet<Software> Software
        //{
        //    get
        //    {
        //        if (_software == null)
        //            _software = base.Set<Software>();

        //        return _software;
        //    }
        //}

        //DbSet<Book> _books;
        //public virtual DbSet<Book> Books
        //{
        //    get
        //    {
        //        if (_books == null)
        //            _books = base.Set<Book>();

        //        return _books;
        //    }
        //}

        //DbSet<Order> _orders;
        //public virtual DbSet<Order> Orders
        //{
        //    get
        //    {
        //        if (_orders == null)
        //            _orders = base.Set<Order>();

        //        return _orders;
        //    }
        //}

        //DbSet<Country> _countries;
        //public virtual DbSet<Country> Countries
        //{
        //    get
        //    {
        //        if (_countries == null)
        //            _countries = base.Set<Country>();

        //        return _countries;
        //    }
        //}


        //DbSet<BankAccount> _bankAccounts;
        //public virtual DbSet<BankAccount> BankAccounts
        //{
        //    get
        //    {
        //        if (_bankAccounts == null)
        //            _bankAccounts = base.Set<BankAccount>();

        //        return _bankAccounts;
        //    }
        //}

        #endregion

    }
}
