using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace _3312FinalSpring22.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {

            using (var context = new PurseDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<PurseDbContext>>()))
                {
                    if(context.Purse.Any())
                    {
                        return;
                    }

                    context.Purse.AddRange(
                        new Purse
                        {
                            PSize = "L",
                            PColor = "White",
                            PBrand = "Nine West",
                            PStyle = "Hand"
                        },
                        new Purse
                        {
                            PSize = "S",
                            PColor = "Green",
                            PBrand = "Coach",
                            PStyle = "Body"
                        },
                        new Purse
                        {
                            PSize = "M",
                            PColor = "Red",
                            PBrand = "Kate Spade",
                            PStyle = "Messenger"
                        },
                        new Purse
                        {
                            PSize = "M",
                            PColor = "Gray",
                            PBrand = "Michael Kors",
                            PStyle = "Body"
                        },
                        new Purse
                        {
                            PSize = "L",
                            PColor = "Black",
                            PBrand = "Kenneth Cole",
                            PStyle = "Body"
                        },
                        new Purse
                        {
                            PSize = "S",
                            PColor = "Pink",
                            PBrand = "Addidas",
                            PStyle = "Hand"
                        },
                        new Purse
                        {
                            PSize = "XL",
                            PColor = "Blue",
                            PBrand = "Swiss",
                            PStyle = "Messenger"
                        },
                        new Purse
                        {
                            PSize = "S",
                            PColor = "White",
                            PBrand = "Guess",
                            PStyle = "Clutch"
                        }
                    );
                    
                    context.SaveChanges();
                }

            using (var context = new ShoeDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ShoeDbContext>>()))
                {
                    if(context.Shoe.Any())
                    {
                        return;
                    }

                    context.Shoe.AddRange(
                        new Shoe
                        {
                            Size = 10,
                            Color = "Red",
                            Brand = "Vera Wang"
                        },
                        new Shoe
                        {
                            Size = 11.5,
                            Color = "Black",
                            Brand = "Jimmy Choo"
                        },
                        new Shoe
                        {
                            Size = 9,
                            Color = "White",
                            Brand = "Gucci"
                        },
                        new Shoe
                        {
                            Size = 8.5,
                            Color = "Blue/White",
                            Brand = "Prada"
                        },
                        new Shoe
                        {
                            Size = 6,
                            Color = "White",
                            Brand = "Sketchers"
                        },
                        new Shoe
                        {
                            Size = 7,
                            Color = "Black",
                            Brand = "Fila"
                        },
                        new Shoe
                        {
                            Size = 8,
                            Color = "Pink",
                            Brand = "Clarks"
                        },
                        new Shoe
                        {
                            Size = 11,
                            Color = "Red",
                            Brand = "Easy Spirit"
                        },
                        new Shoe
                        {
                            Size = 5,
                            Color = "Green",
                            Brand = "Ralph Lauren"
                        },
                        new Shoe
                        {
                            Size = 9,
                            Color = "Purple",
                            Brand = "Nine West"
                        }
                    );
                    
                    context.SaveChanges();
                }
        }
        public int ShoeId {get; set;}

        public int Size {get; set;}
        public string Brand {get; set;}
        public string Color {get; set;}
        public int PurseId {get; set;}

        public double PSize {get; set;}
        public string PBrand {get; set;}
        public string PColor {get; set;}
        public string PStyle  {get; set;}
    }
}