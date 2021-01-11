using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using ThAmCo.Catering.Data;


namespace ThAmCo.Catering.Data
{
    public class CateringContext : DbContext
    {
        public DbSet<FoodBooking> FoodBookings { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuFoodItem> MenuFoodItems {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Catering;");

        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Relationships between the tables

            base.OnModelCreating(builder);
                        
            builder.Entity<MenuFoodItem>()
                .HasKey(m => new { m.FoodItemId, m.MenuId });

            builder.Entity<MenuFoodItem>()
                .HasOne(m => m.Menu)
                .WithMany(f => f.MenuFoods)
                .HasForeignKey(m => m.MenuId);

            builder.Entity<MenuFoodItem>()
                .HasOne(f => f.FoodItem)
                .WithMany(m => m.MenuFoodItems)
                .HasForeignKey(f => f.FoodItemId);
                                   

            //Seed Data
            builder.Entity<FoodItem>().HasData(
                    new FoodItem { FoodItemId = 1, Description = "First food", UnitPrice = 1.00},
                    new FoodItem { FoodItemId = 2, Description = "Second food", UnitPrice = 2.00},
                    new FoodItem { FoodItemId = 3, Description = "Third food", UnitPrice = 3.00}
                );

            builder.Entity<Menu>().HasData(
                    new Menu { MenuId = 1, MenuName = "First menu"},
                    new Menu { MenuId = 2, MenuName = "Second menu"},
                    new Menu { MenuId = 3, MenuName = "Third menu"}
                );

            builder.Entity<FoodBooking>().HasData(
                    new FoodBooking { FoodBookingId = 1, ClientReferenceId = 1, NumberOfGuests = 5, MenuId = 1},
                    new FoodBooking { FoodBookingId = 2, ClientReferenceId = 2, NumberOfGuests = 3, MenuId = 2},
                    new FoodBooking { FoodBookingId = 3, ClientReferenceId = 3, NumberOfGuests = 8, MenuId = 3}
                );
                        
        }

    }

    

    
}
