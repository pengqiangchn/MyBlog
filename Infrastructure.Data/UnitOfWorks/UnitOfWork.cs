using Domain.Modules;
using Domain.Modules.BlogEntitys;
using Infrastructure.Data.Seedwork;
using Infrastructure.Data.Seedwork.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.Data.UnitOfWorks
{
    public class UnitOfWork : BaseContext, IQueryableUnitOfWork
    {
        #region Constructors
        public UnitOfWork()
        {

        }

        public UnitOfWork(DbContextOptions<UnitOfWork> options)
            : base(options)
        {



        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //创建种子数据
            modelBuilder.Entity<BlogUser>().HasData(new BlogUser
            {
                Id = new Guid("00000001-0000-0000-0000-000000000000"),
                UserName = "Admin",
                PassWord = "df6234833d7d4d76a96654a1c89ac08f"   //12347890
            });


            modelBuilder.Entity<BlogInfo>().HasData(new BlogInfo
            {
                Id = new Guid("00000001-0001-0000-0000-000000000000"),
                BlogName = "MyBlog",
                CreateTime = DateTime.Parse("2020-02-02"),
                UserId = new Guid("00000001-0000-0000-0000-000000000000"),
            });

            //创建实体关系
            //博客信息
            modelBuilder.Entity<BlogInfo>().HasOne(x => x.User)
                .WithOne(x => x.BlogInfo).HasForeignKey<BlogInfo>(x => x.UserId);

            ///分类信息
            modelBuilder.Entity<BlogClass>().HasOne(x => x.BlogInfo)
                .WithMany(x => x.Classes).HasForeignKey(x => x.BlogId);

            //modelBuilder.Entity<BlogClass>().HasOne(x => x.ParentClass)
            //    .WithMany(x => x.Childrens).HasForeignKey(x => x.ParentId);

            //文章信息
            modelBuilder.Entity<BlogArticle>().HasOne(x => x.BlogInfo)
                .WithMany(x => x.Articles).HasForeignKey(x => x.BlogId);

            modelBuilder.Entity<BlogArticle>().HasOne(x => x.BlogClass)
                .WithMany(x => x.Articles).HasForeignKey(x => x.ClassId);

        }


        #endregion

        #region DbSet Members

        public DbSet<BlogUser> BlogUsers { get; set; }

        public DbSet<BlogInfo> BlogInfos { get; set; }

        public DbSet<BlogClass> BlogClasses { get; set; }

        public DbSet<BlogArticle> BlogArticles { get; set; }

        #endregion


    }

}
