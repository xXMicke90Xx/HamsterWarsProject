using HamsterWars.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace HamsterWars.Server.DataBase
{
    public class HamsterDBContext : DbContext
    {
        public DbSet<Hamster> Hamsters { get; set; }

        public HamsterDBContext(DbContextOptions<HamsterDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hamster>().HasData(
                new List<Hamster>
                { new Hamster
                {
                    id = 1,
                    Name = "McFuzz",
                    Age = 4,
                    FavFood = "Cheese",
                    Loves = "Ball",
                    ImgName = "hamster-1.jpg"
                },
                new Hamster
                {
                    id = 2,
                    Name = "Karin",
                    Age = 50,
                    FavFood = "Meatballs",
                    Loves = "Running wheel",
                    ImgName = "hamster-2.jpg"
                },
                new Hamster
                {
                    id=3,
                    Name = "Nicolas",
                    Age = 11,
                    FavFood = "Pizza",
                    Loves = "Nothing",
                    ImgName = "hamster-3.jpg"
                },
                new Hamster
                {
                    id = 4,
                    Name = "Pedro",
                    Age = 105,
                    FavFood = "Burrito",
                    Loves = "Dancing",
                    ImgName = "hamster-4.jpg"
                },
                new Hamster
                {
                    id = 5,
                    Name = "Pancake",
                    Age = 2,
                    FavFood = "Pancakes",
                    Loves = "Pancakes",
                    ImgName = "hamster-5.jpg"
                },
                new Hamster
                {
                    id = 6,
                    Name = "Carl",
                    Age = 6,
                    FavFood = "Cables",
                    Loves = "Electricity",
                    ImgName = "hamster-6.jpg"
                },
                new Hamster
                {
                    id = 7,
                    Name = "Mike",
                    Age = 59,
                    FavFood = "Bananas",
                    Loves = "Running around",
                    ImgName = "hamster-7.jpg"
                },
                new Hamster
                {
                    id = 8,
                    Name = "Wizard",
                    Age = 5000,
                    FavFood = "Magic Rabbits",
                    Loves = "Magic",
                    ImgName = "hamster-8.jpg"
                },
                new Hamster
                {
                    id = 9,
                    Name = "Jorma",
                    Age = 30,
                    FavFood = "Coffee",
                    Loves = "Sauna",
                    ImgName = "hamster-9.jpg"
                },
                new Hamster
                {
                    id = 10,
                    Name = "Codey",
                    Age = 9,
                    FavFood = "Sausage",
                    Loves = "Who knows",
                    ImgName = "hamster-10.jpg"
                },
                new Hamster
                {
                    id = 11,
                    Name = "Togepi",
                    Age = 1,
                    FavFood = "Tamato",
                    Loves = "Friends",
                    ImgName = "hamster-11.jpg"
                },
                new Hamster
                {
                    id = 12,
                    Name = "Poopers",
                    Age = 13,
                    FavFood = "Beans",
                    Loves = "Sleeping",
                    ImgName = "hamster-12.jpg"
                },
                new Hamster
                {
                    id = 13,
                    Name = "Kyle",
                    Age = 20,
                    FavFood = "Pineapple",
                    Loves = "Kama Sutra",
                    ImgName = "hamster-13.jpg"
                },
                new Hamster
                {
                    id = 14,
                    Name = "Pog",
                    Age = 666,
                    FavFood = "Human leftovers",
                    Loves = "Playing with Demons",
                    ImgName = "hamster-14.jpg"
                },
                new Hamster
                {
                    id = 15,
                    Name = "DJ",
                    Age = 21,
                    FavFood = "Beer",
                    Loves = "Music",
                    ImgName = "hamster-15.jpg"
                },
                new Hamster
                {
                    id = 16,
                    Name = "Blanket",
                    Age = 4,
                    FavFood = "Soup",
                    Loves = "Sleeping",
                    ImgName = "hamster-16.jpg"
                },
                new Hamster
                {
                    id = 17,
                    Name = "Paranoia",
                    Age = 12,
                    FavFood = "...",
                    Loves = "Who's Asking?",
                    ImgName = "hamster-17.jpg"
                },
                new Hamster
                {
                    id = 18,
                    Name = "Pirate",
                    Age = 30,
                    FavFood = "COINS",
                    Loves = "CHESTS",
                    ImgName = "hamster-18.jpg"
                },
                new Hamster
                {
                    id = 19,
                    Name = "Green",
                    Age = 4,
                    FavFood = "Cheeseballs",
                    Loves = "Cat",
                    ImgName = "hamster-19.jpg"
                },
                new Hamster
                {
                    id = 20,
                    Name = "Snoop",
                    Age = 420,
                    FavFood = "Dutch stuff",
                    Loves = "Blowing clouds",
                    ImgName = "hamster-20.jpg"
                },
                new Hamster
                {
                    id = 21,
                    Name = "Dave",
                    Age = 3,
                    FavFood = "Wheat",
                    Loves = "Playing with rats",
                    ImgName = "hamster-21.jpg"
                },
                new Hamster
                {
                    id = 22,
                    Name = "McQueen",
                    Age = 5,
                    FavFood = "Candy",
                    Loves = "RACING",
                    ImgName = "hamster-22.jpg"
                },
                new Hamster
                {
                    id = 23,
                    Name = "Chuck",
                    Age = 8,
                    FavFood = "Twinkies",
                    Loves = "Eat,Sleep,Twinkies,Repeat",
                    ImgName = "hamster-23.jpg"
                },
                new Hamster
                {
                    id = 24,
                    Name = "Soda",
                    Age = 5,
                    FavFood = "Grass",
                    Loves = "Hide under beds",
                    ImgName = "hamster-24.jpg"
                },
                new Hamster
                {
                    id = 25,
                    Name = "Questionmark",
                    Age = 0,
                    FavFood = "?",
                    Loves = "?",
                    ImgName = "hamster-25.jpg"
                },
                new Hamster
                {
                    id = 26,
                    Name = "Milk",
                    Age = 1,
                    FavFood = "Hamstermilk",
                    Loves = "Hamster Wheel!!!!!",
                    ImgName = "hamster-26.jpg"
                },
                new Hamster
                {
                    id = 27,
                    Name = "Boy",
                    Age = 40,
                    FavFood = "Marshmellows",
                    Loves = "Playing with my bro's",
                    ImgName = "hamster-27.jpg"
                },
                new Hamster
                {
                    id = 28,
                    Name = "Kid",
                    Age = 40,
                    FavFood = "Marshmellows",
                    Loves = "Playin with my bro's",
                    ImgName = "hamster-28.jpg"
                },
                new Hamster
                {
                    id = 29,
                    Name = "Chemical",
                    Age = 3,
                    FavFood = "Acid",
                    Loves = "Experimenting",
                    ImgName = "hamster-29.jpg"
                },
                new Hamster
                {
                    id = 30,
                    Name = "Little shit",
                    Age = 0,
                    FavFood = "Poop",
                    Loves = "Driving my owners to madness",
                    ImgName = "hamster-30.jpg"
                },
                new Hamster
                {
                    id = 31,
                    Name = "Milo",
                    Age = 9,
                    FavFood = "Everything",
                    Loves = "Everything that entertains",
                    ImgName = "hamster-31.jpg"
                },
                new Hamster
                {
                    id = 32,
                    Name = "Lobba",
                    Age = 40,
                    FavFood = "Pancakes",
                    Loves = "Playing guitar",
                    ImgName = "hamster-32.jpg"
                },
                new Hamster
                {
                    id = 33,
                    Name = "Swagrid",
                    Age = 6000,
                    FavFood = "Sausages",
                    Loves = "Breeding magical creatures",
                    ImgName = "hamster-33.jpg"
                },
                new Hamster
                {
                    id = 34,
                    Name = "Mark",
                    Age = 1,
                    FavFood = "Ham",
                    Loves = "Going ham",
                    ImgName = "hamster-34.jpg"
                },
                new Hamster
                {
                    id = 35,
                    Name = "Sunny",
                    Age = 12,
                    FavFood = "Carrots",
                    Loves = "Running",
                    ImgName = "hamster-35.jpg"
                },
                new Hamster
                {
                    id = 36,
                    Name = "Ash",
                    Age = 5,
                    FavFood = "Paper",
                    Loves = "Sleeping",
                    ImgName = "hamster-36.jpg"
                },
                new Hamster
                {
                    id = 37,
                    Name = "Swagrid",
                    Age = 6000,
                    FavFood = "Sausages",
                    Loves = "Breeding magical creatures",
                    ImgName = "hamster-37.jpg"
                },
                new Hamster
                {
                    id = 38,
                    Name = "Alfons",
                    Age = 2,
                    FavFood = "Meat",
                    Loves = "Reading books",
                    ImgName = "hamster-38.jpg"
                },
                new Hamster
                {
                    id = 39,
                    Name = "Tetris",
                    Age = 30,
                    FavFood = "Chicken",
                    Loves = "Racing",
                    ImgName = "hamster-39.jpg"
                },new Hamster
                {
                    id = 40,
                    Name = "Pepsi",
                    Age = 3,
                    FavFood = "Cheese",
                    Loves = "Working out",
                    ImgName = "hamster-40.jpg"
                },
                });


        }

    }
}
