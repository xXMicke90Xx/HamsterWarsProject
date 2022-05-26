using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterWars.Server.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "id", "Age", "FavFood", "Games", "ImgName", "Losses", "Loves", "Name", "Wins" },
                values: new object[,]
                {
                    { 1, 4, "Cheese", 0, "hamster-1.jpg", 0, "Ball", "McFuzz", 0 },
                    { 2, 50, "Meatballs", 0, "hamster-2.jpg", 0, "Running wheel", "Karin", 0 },
                    { 3, 11, "Pizza", 0, "hamster-3.jpg", 0, "Nothing", "Nicolas", 0 },
                    { 4, 105, "Burrito", 0, "hamster-4.jpg", 0, "Dancing", "Pedro", 0 },
                    { 5, 2, "Pancakes", 0, "hamster-5.jpg", 0, "Pancakes", "Pancake", 0 },
                    { 6, 6, "Cables", 0, "hamster-6.jpg", 0, "Electricity", "Carl", 0 },
                    { 7, 59, "Bananas", 0, "hamster-7.jpg", 0, "Running around", "Mike", 0 },
                    { 8, 5000, "Magic Rabbits", 0, "hamster-8.jpg", 0, "Magic", "Wizard", 0 },
                    { 9, 30, "Coffee", 0, "hamster-9.jpg", 0, "Sauna", "Jorma", 0 },
                    { 10, 9, "Sausage", 0, "hamster-10.jpg", 0, "Who knows", "Codey", 0 },
                    { 11, 1, "Tamato", 0, "hamster-11.jpg", 0, "Friends", "Togepi", 0 },
                    { 12, 13, "Beans", 0, "hamster-12.jpg", 0, "Sleeping", "Poopers", 0 },
                    { 13, 20, "Pineapple", 0, "hamster-13.jpg", 0, "Kama Sutra", "Kyle", 0 },
                    { 14, 666, "Human leftovers", 0, "hamster-14.jpg", 0, "Playing with Demons", "Pog", 0 },
                    { 15, 21, "Beer", 0, "hamster-15.jpg", 0, "Music", "DJ", 0 },
                    { 16, 4, "Soup", 0, "hamster-16.jpg", 0, "Sleeping", "Blanket", 0 },
                    { 17, 12, "...", 0, "hamster-17.jpg", 0, "Who's Asking?", "Paranoia", 0 },
                    { 18, 30, "COINS", 0, "hamster-18.jpg", 0, "CHESTS", "Pirate", 0 },
                    { 19, 4, "Cheeseballs", 0, "hamster-19.jpg", 0, "Cat", "Green", 0 },
                    { 20, 420, "Dutch stuff", 0, "hamster-20.jpg", 0, "Blowing clouds", "Snoop", 0 },
                    { 21, 3, "Wheat", 0, "hamster-21.jpg", 0, "Playing with rats", "Dave", 0 },
                    { 22, 5, "Candy", 0, "hamster-22.jpg", 0, "RACING", "McQueen", 0 },
                    { 23, 8, "Twinkies", 0, "hamster-23.jpg", 0, "Eat,Sleep,Twinkies,Repeat", "Chuck", 0 },
                    { 24, 5, "Grass", 0, "hamster-24.jpg", 0, "Hide under beds", "Soda", 0 },
                    { 25, 0, "?", 0, "hamster-25.jpg", 0, "?", "Questionmark", 0 },
                    { 26, 1, "Hamstermilk", 0, "hamster-26.jpg", 0, "Hamster Wheel!!!!!", "Milk", 0 },
                    { 27, 40, "Marshmellows", 0, "hamster-27.jpg", 0, "Playing with my bro's", "Boy", 0 },
                    { 28, 40, "Marshmellows", 0, "hamster-28.jpg", 0, "Playin with my bro's", "Kid", 0 },
                    { 29, 3, "Acid", 0, "hamster-29.jpg", 0, "Experimenting", "Chemical", 0 },
                    { 30, 0, "Poop", 0, "hamster-30.jpg", 0, "Driving my owners to madness", "Little shit", 0 },
                    { 31, 9, "Everything", 0, "hamster-31.jpg", 0, "Everything that entertains", "Milo", 0 },
                    { 32, 40, "Pancakes", 0, "hamster-32.jpg", 0, "Playing guitar", "Lobba", 0 },
                    { 33, 6000, "Sausages", 0, "hamster-33.jpg", 0, "Breeding magical creatures", "Swagrid", 0 },
                    { 34, 1, "Ham", 0, "hamster-34.jpg", 0, "Going ham", "Mark", 0 },
                    { 35, 12, "Carrots", 0, "hamster-35.jpg", 0, "Running", "Sunny", 0 },
                    { 36, 5, "Paper", 0, "hamster-36.jpg", 0, "Sleeping", "Ash", 0 },
                    { 37, 6000, "Sausages", 0, "hamster-37.jpg", 0, "Breeding magical creatures", "Swagrid", 0 },
                    { 38, 2, "Meat", 0, "hamster-38.jpg", 0, "Reading books", "Alfons", 0 },
                    { 39, 30, "Chicken", 0, "hamster-39.jpg", 0, "Racing", "Tetris", 0 },
                    { 40, 3, "Cheese", 0, "hamster-40.jpg", 0, "Working out", "Pepsi", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "id",
                keyValue: 40);
        }
    }
}
