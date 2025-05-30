using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_Dev.Models
{
    public class AppDBContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierBill> SupplierBills { get; set; }
        public DbSet<SupplierBillItem> SupplierBillItems { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerBill> CustomerBills { get; set; }
        public DbSet<CustomerBillItem> CustomerBillItems { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=StockManagement-Dev;Trusted_Connection=True;Trust server certificate=true ");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<SupplierBillItem>()
                .HasOne(i => i.SupplierBill)
                .WithMany(b => b.Items)
                .HasForeignKey(i => i.SupplierBillID)
                .OnDelete(DeleteBehavior.Cascade);



            modelBuilder.Entity<SupplierBillItem>()
                .HasOne(i => i.Product)
                .WithMany()
                .HasForeignKey(i => i.ProductID)
                .OnDelete(DeleteBehavior.Restrict);




            modelBuilder.Entity<CustomerBillItem>()
                .HasOne(i => i.CustomerBill)
                .WithMany(b => b.Items)
                .HasForeignKey(i => i.CustomerBillID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CustomerBillItem>()
                .HasOne(i => i.Product)
                .WithMany()
                .HasForeignKey(i => i.ProductID)
                .OnDelete(DeleteBehavior.Restrict);



           
         

            // seeding customers
            modelBuilder.Entity<Customer>().HasData(
               Enumerable.Range(1, 10).Select(i => new Customer
               {
                   CustomerID = i,
                   Name = $"Customer {i}",
                   Phone = $"123456789{i}",
               })
             );


            // seeding suppliers
            modelBuilder.Entity<Supplier>().HasData(
                Enumerable.Range(1, 10).Select(i => new Supplier
                {
                    SupplierID = i,
                    Name = $"Supplier {i}",
                    Phone = $"987654321{i}",

                })
            );

            // seeding products
            modelBuilder.Entity<Product>().HasData(
                Enumerable.Range(1, 10).Select(i => new Product
                {
                    ProductID = i,
                    Name = $"Product {i}",
                    UnitPrice = 10 + i * 10,
                    QuantityInStock = 50,
                    SupplierID = i 
                })
            );

            // seeding supplier bills
            modelBuilder.Entity<SupplierBill>().HasData(
                Enumerable.Range(1, 10).Select(i => new SupplierBill
                {
                    SupplierBillID = i,
                    SupplierID = i,
                    BillDate = DateTime.Now.AddDays(-i),
                    TotalAmount = 0 // This will be calculated later
                })
            );



            // seeding customer bills
            modelBuilder.Entity<CustomerBill>().HasData(
                Enumerable.Range(1, 10).Select(i => new CustomerBill
                {
                    CustomerBillID = i,
                    CustomerID = i,
                    BillDate = DateTime.Now.AddDays(-i),
                    TotalAmount = 0 // This will be calculated later
                })
            );



            // seeding supplier bill items
            modelBuilder.Entity<SupplierBillItem>().HasData(
                Enumerable.Range(1, 10).Select(i => new SupplierBillItem
                {
                    SupplierBillItemID = i,
                    SupplierBillID = i,
                    ProductID = i % 10 + 1, // Cycle through products
                    Quantity = 5,
                    UnitPrice = 100 + (i % 10) * 10 // Varying unit price
                })
            );



            // seeding customer bill items
            modelBuilder.Entity<CustomerBillItem>().HasData(
                Enumerable.Range(1, 10).Select(i => new CustomerBillItem
                {
                    CustomerBillItemID = i,
                    CustomerBillID = i,
                    ProductID = i % 10 + 1, // Cycle through products
                    Quantity = 3,
                    UnitPrice = 100 + (i % 10) * 10 // Varying unit price
                })
            );

          

        



        }

    }
}
