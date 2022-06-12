using Abstract__Factory.Factories;
using Abstract__Factory.ShirtProducts;
using Abstract__Factory.TrousersProducts;
using System;

namespace Abstract__Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClothesFactory factory = new CasualClothesFactory();

            Shirt shirt = factory.CreateShirt();
            Trousers trousers = factory.CreateTrousers();

            shirt.LookOfDay();
            trousers.DescribeYourClothes();

        }
    }
}
