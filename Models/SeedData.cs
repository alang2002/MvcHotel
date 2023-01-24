using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcHotel.Data;
using System;
using System.Linq;

namespace MvcHotel.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcHotelContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcHotelContext>>()))
            {
                // Look for any Guests.
                if (context.Guest.Any())
                {
                    return;   // DB has been seeded
                }

                context.Guest.AddRange(
                    new Guest
                    {
                        FName = "Bob",
                        LName = "Bob",
                        PhoneNum = 1234567890,
                        CheckInDate = DateTime.Parse("2023-01-01"),
                        CheckOutDate = DateTime.Parse("2023-01-08")
                    },

                    new Guest
                    {
                        FName = "Spike",
                        LName = "Spiegel",
                        PhoneNum = 1122334563,
                        CheckInDate = DateTime.Parse("2023-01-11"),
                        CheckOutDate = DateTime.Parse("2023-01-18")
                    },

                    new Guest
                    {
                        FName = "Cole",
                        LName = "Cassidy",
                        PhoneNum = 1122334567,
                        CheckInDate = DateTime.Parse("2023-01-05"),
                        CheckOutDate = DateTime.Parse("2023-01-09")
                    },

                    new Guest
                    {
                        FName = "Peter",
                        LName = "Parker",
                        PhoneNum = 1010101100,
                        CheckInDate = DateTime.Parse("2023-01-08"),
                        CheckOutDate = DateTime.Parse("2023-01-09")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}