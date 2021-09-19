using Microsoft.EntityFrameworkCore.Migrations;

namespace movie_app_task_backend.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Release_year = table.Column<string>(type: "TEXT", nullable: true),
                    img_url = table.Column<string>(type: "TEXT", nullable: true),
                    isSeries = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActorMedia",
                columns: table => new
                {
                    ActorsId = table.Column<int>(type: "INTEGER", nullable: false),
                    MediaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorMedia", x => new { x.ActorsId, x.MediaId });
                    table.ForeignKey(
                        name: "FK_ActorMedia_Actors_ActorsId",
                        column: x => x.ActorsId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorMedia_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Rating_value = table.Column<float>(type: "REAL", nullable: false),
                    MediaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Screening",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<string>(type: "TEXT", nullable: true),
                    Time = table.Column<string>(type: "TEXT", nullable: true),
                    Place = table.Column<string>(type: "TEXT", nullable: true),
                    Number_of_seats = table.Column<int>(type: "INTEGER", nullable: false),
                    Number_of_tickets = table.Column<int>(type: "INTEGER", nullable: false),
                    MediaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screening", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Screening_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Chris Hemsworth" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 34, "Scottie Fleming" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 35, "Mara Baldwin" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 36, "Kristina Hardy" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 37, "Chris Brandt" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 38, "Alva Compton" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 39, "Victoria Alston" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 40, "Victoria Alston" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 41, "Victoria Alston" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 42, "Victoria Alston" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 43, "Victoria Alston" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 44, "Victoria Alston" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 45, "Victoria Alston" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 46, "Victoria Alston" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 47, "Victoria Alston" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 48, "Victoria Alston" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 49, "Victoria Alston" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 50, "Victoria Alston" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 51, "Victoria Alston" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 52, "Victoria Alston" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 53, "Victoria Alston" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 54, "Victoria Alston" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 56, "Victoria Alston" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 57, "Victoria Alston" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 58, "Victoria Alston" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 59, "Victoria Alston" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 60, "Victoria Alston" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 61, "Victoria Alston" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 33, "Melissa Schwartz" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 32, "Carlos Ross" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 55, "Victoria Alston" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 30, "Walter Blankenship" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 31, "Dwayne Wun" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Natalie Portman" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Tom Hiddleston" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Brianna Howe" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "James Hines" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 7, "Leon Jarvis" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 8, "Vinson Moran" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 9, "Simpson Evans" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 10, "Henry Molina" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 11, "Mccullough Curry" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 12, "Angelia Ruiz" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 13, "Hinton Love" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 14, "Adrienne Logan" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 15, "Broderick Moore" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Carver Wong" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 17, "Alisha Bentley" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 16, "Saundra West" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 28, "Bradly Obrien" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 27, "Odell Best" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 25, "Alec Davila" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 24, "Rey Romero" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 26, "Nellie Barr" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 29, "Demarcus Boyle" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 22, "Normand Hughes" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 21, "Miriam Cummings" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 20, "Deshawn Arias" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 19, "Larry Garcia" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 23, "Modesto Clements" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[] { 18, "Hiram Strickland" });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 64, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Work it", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 65, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Kate", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 66, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Grown ups 2", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 69, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "The Internship", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 68, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Blended", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 70, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Playing with fire", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 63, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Pitch perfect", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 71, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Monte Carlo", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 67, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Grown ups", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 72, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "She is all that", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 57, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "John Wick 2", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 61, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Just friends", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 60, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Rudy", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 59, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "The perfect date", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 58, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "John Wick", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 56, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "John Wick 3", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 55, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Hangover part 1", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 54, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Hangover part 2", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 53, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Hangover part 3", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 73, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "47 ronin", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 52, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Swiped", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 62, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Red 2", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 74, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Enola Holmes", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 89, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Constantine", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 76, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "In time", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 51, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Creed", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 98, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Shadow and Bone", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 97, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Good witch", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 96, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Superman and Louise", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 95, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Zero chill", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 94, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "How I met your mother", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 93, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Van Helsing", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 92, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "The Walking Dead", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 91, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Merlin", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 90, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Warrior nun", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 75, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Noah", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 88, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Journey 2", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 86, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Kong : skull island", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 85, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Good boys", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 84, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Sweet girl", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 83, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Baywatch", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 82, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Be somebody", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 81, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Tomb Raidler", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 80, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Warcraft", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 79, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Holidate", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 78, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "The Mask", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 77, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Midway", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 87, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Star trek", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 50, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Creed 2", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 20, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Invisible city", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 48, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Takers", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 21, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Locke is key", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 99, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Shadow hunters", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 19, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Teen wolf", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 18, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Marlon", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 17, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Lucifer", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 16, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Vampire diaries", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 15, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "ELite", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 14, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "The Flash", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 13, "A sixth-generation homesteader and devoted father, John Dutton controls the largest contiguous ranch in the United States. He operates in a corrupt world where politicians are compromised by influential oil and lumber corporations and land grabs make developers billions.", "2018-06-20", "Yellowstone", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN6RB1/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 12, "Michael Burnham and her companions in the USS Discovery travel into the far reaches of space to meet new lifeforms and discover new planets.", "2017-09-24", "Star Trek: Discovery", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN8KT4/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 11, "In the wake of a zombie apocalypse, various survivors struggle to stay alive. As they search for safety and evade the undead, they are forced to grapple with rival groups and difficult choices.", "2010-10-31", "The Walking Dead", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN90WK/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 10, "After having been missing for nearly 20 years, Rick Sanchez suddenly arrives at daughter Beth's doorstep to move in with her and her family.", "2013-09-17", "Rick and Morty", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN85RB/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 9, "Bilbo fights against a number of enemies to save the life of his Dwarf friends and protects the Lonely Mountain after a conflict arises.", "2014-12-11", "The Hobbit: The Battle of the Five Armies", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZTH3PF/image?locale=en-nz&purposes=BoxArt&mode=scale&q=90&w=162", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 8, "Bilbo Baggins, a hobbit, and his companions face great dangers on their journey to Laketown. Soon, they reach the Lonely Mountain, where Bilbo comes face-to-face with the fearsome dragon Smaug.", "2013-12-12", "The Hobbit: The Desolation of Smaug", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZJ5NLV/image?locale=en-au&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 7, "Bilbo Baggins, a hobbit, is persuaded into accompanying a wizard and a group of dwarves on a journey to reclaim the city of Erebor and all its riches from the dragon Smaug.", "2013-09-17", "The Hobbit: An Unexpected Journey", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL59HB/image?locale=en-au&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 6, "The former Fellowship members prepare for the final battle. While Frodo and Sam approach Mount Doom to destroy the One Ring, they follow Gollum, unaware of the path he is leading them to", "2013-09-17", "Lord Of The Rings: The Return Of The King", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL60J7/image?locale=en-gb&purposes=BoxArt&mode=scale&q=90&w=162", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 5, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Brooklyn Nine-Nine", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 4, "Bilbo Baggins, a hobbit, is persuaded into accompanying a wizard and a group of dwarves on a journey to reclaim the city of Erebor and all its riches from the dragon Smaug.", "2012-12-13", "The Hobbit: An Unexpected Journey", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL59HB/image?locale=en-au&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 3, "Frodo and Sam arrive in Mordor with the help of Gollum. A number of new allies join their former companions to defend Isengard as Saruman launches an assault from his domain", "2002-12-18", "Lord Of The Rings: The Two Towers", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL60J7/image?locale=en-gb&purposes=BoxArt&mode=scale&q=90&w=162", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 2, "After Princess Leia, the leader of the Rebel Alliance, is held hostage by Darth Vader, Luke and Han Solo must free her and destroy the powerful weapon created by the Galactic Empire.", "1977-05-17", "Star Wars: A New Hope", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZXZDZ3/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=225&w=150&", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 1, "Luke Skywalker attempts to bring his father back to the light side of the Force. At the same time, the rebels hatch a plan to destroy the second Death Star.", "1983-05-25", "Star Wars: Return of the Jedi", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZZCMJ4/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 22, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Fate", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 23, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "The Crew", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 24, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Riverdale", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 25, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "The Ranch", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 47, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Crash pad", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 46, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Shaft", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 45, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Zoung adult", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 44, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Transporter 1", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 43, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Transporter 2", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 42, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Transporter 3", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 41, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Wonder", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 40, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "POMS", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 39, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Defiance", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 38, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Gladiator", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 49, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Creed 3", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 37, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Aladdin", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 35, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Endless love", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 34, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "The half of it", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 33, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Before I fall", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 32, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Just like heaven", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 31, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "The Ranch", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 30, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Money heist", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 29, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "The Witcher", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 28, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Good Girls", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 27, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Cobra kai", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 26, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Family guy", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 36, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Robin Hood", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", false });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "Release_year", "Title", "img_url", "isSeries" },
                values: new object[] { 100, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "2013-09-17", "Dare me", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", true });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 1, 1, 4.6f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 22, 22, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 21, 21, 4.6f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 20, 20, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 19, 19, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 18, 18, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 17, 17, 4.6f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 16, 16, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 15, 15, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 14, 14, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 13, 13, 4.6f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 12, 12, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 11, 11, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 10, 10, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 9, 9, 4.6f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 8, 8, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 7, 7, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 6, 6, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 5, 5, 4.6f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 4, 4, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 3, 3, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 2, 2, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 23, 23, 4.5f });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[] { 24, 24, 4.5f });

            migrationBuilder.CreateIndex(
                name: "IX_ActorMedia_MediaId",
                table: "ActorMedia",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_MediaId",
                table: "Ratings",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_Screening_MediaId",
                table: "Screening",
                column: "MediaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorMedia");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Screening");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Medias");
        }
    }
}
