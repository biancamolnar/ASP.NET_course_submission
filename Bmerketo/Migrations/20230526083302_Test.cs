using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bmerketo.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactForms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ArticleNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ingress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ArticleNumber);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ArticleNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.ArticleNumber, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ArticleNumber",
                        column: x => x.ArticleNumber,
                        principalTable: "Products",
                        principalColumn: "ArticleNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "15da8f3e-82c6-41ee-833d-f9c3c16fee39", "0f9dd02a-05b9-4c9e-8fbc-b80131d0dd3b", "Admin", "ADMIN" },
                    { "eb0a9351-9c59-4a52-a03a-5e7001af25fb", "1de4738d-a4b0-4bee-a90f-06104787ca20", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3b619961-682f-4f3b-93c5-564f15c543aa", 0, "3237f63a-a6af-4db3-ad06-205c70217f88", "admin@domain.com", false, null, null, false, null, "ADMIN@DOMAIN.COM", "ADMIN@DOMAIN.COM", "AQAAAAIAAYagAAAAEDHab4A+XHxYJsp2Zf6rKiOm0qcAwK8XLGl/Ibc/ap+7F7S9W/Y8xZjhtZUECvH1ug==", null, false, "b33ffb32-0c42-4473-b968-ece4b93f22d9", false, "admin@domain.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1, "new" },
                    { 2, "featured" },
                    { 3, "popular" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ArticleNumber", "Description", "ImageUrl", "Ingress", "Price", "Title" },
                values: new object[,]
                {
                    { "1", "Designed for hiking trips in the mountains, the Verdant Haven tent provides a spacious and well-ventilated retreat. Unwind amidst the lush greenery of the mountains with this tent from Bmerketo. Its generous interior space offers ample room for rest and storage, ensuring a comfortable and organized adventure. The tent's durable materials and sturdy construction withstand rugged terrains, while the vibrant green color blends harmoniously with the surrounding landscape, making it an eco-conscious choice for nature enthusiasts.", "1_tent.png", "Experience nature in full bloom with the Verdant Haven tent.", 1999m, "Verdant Haven" },
                    { "10", "Prepare to blaze new trails with the Trailblazer tent from Bmerketo. This lightweight and compact tent is crafted for hikers who seek agility without compromising on durability. Its orange hue symbolizes the spirit of exploration, and its waterproof construction ensures you stay protected in changing weather conditions. With easy setup and ample interior space, the Trailblazer is your reliable shelter on the mountains, allowing you to focus on the thrill of the journey.", "10_tent.png", "Ignite your path with the Blaze Trailblazer tent, designed for intrepid explorers.", 1799m, "Blaze Trailblazer" },
                    { "11", "The Citrus Blaze tent infuses your outdoor adventures with a burst of vibrant energy. Its vivid orange color radiates enthusiasm and adds a touch of excitement to your mountain escapades. Crafted with durability and functionality in mind, this tent provides reliable protection and comfort. Whether you're embarking on a solo expedition or camping with friends, the Citrus Blaze ensures a cozy and secure shelter, allowing you to fully embrace the wonders of nature.", "11_tent.png", "Immerse yourself in the invigorating aura of the Citrus Blaze tent.", 1699m, "Citrus Blaze" },
                    { "12", "Immerse yourself in the soothing serenity of the Azure Crest tent. Designed for hikers seeking peace and relaxation, its elegant blue color evokes the beauty of clear skies and pristine waters. Crafted with meticulous attention to detail, this tent offers excellent ventilation, ensuring a comfortable and refreshing sleep after a day of mountain exploration. Its durable materials and sturdy structure provide reliable protection, allowing you to experience the true essence of nature without compromising on comfort.", "12_tent.png", "Discover tranquility amidst the mountains with the Azure Crest tent.", 1699m, "Azure Crest" },
                    { "13", "The Sapphire Summit tent is designed to accompany you on your mountain journeys with style and reliability. Its captivating blue color reflects the majesty of glacial lakes and towering peaks. Crafted with high-quality materials, this tent offers optimal weather protection and durability. Its spacious interior provides ample room for rest and gear storage, while the thoughtfully designed ventilation system ensures a comfortable and refreshing experience amidst the breathtaking beauty of the mountains.", "13_tent.png", "Reach new heights with the Sapphire Summit tent, your gateway to alpine wonders.", 1599m, "Sapphire Summit" },
                    { "14", "Step into the ethereal world of mountain peaks with the Alpine Mist tent. Inspired by the breathtaking beauty of alpine landscapes, its blue and white color scheme captures the essence of majestic snow-capped summits. Crafted with premium materials, this tent ensures durability and protection during your hiking adventures. Its spacious interior and efficient ventilation create a cozy haven where you can recharge and reflect on the awe-inspiring sights surrounding you.", "14_tent.png", "Experience the enchantment of alpine landscapes with the Alpine Mist tent.", 1799m, "Alpine Mist" },
                    { "15", "Venture into the unknown with the Shadow Seeker tent from Bmerketo. Its sleek black exterior symbolizes the enigmatic beauty of the mountains, while its robust construction provides reliable shelter against harsh elements. Designed for intrepid explorers, this tent offers ample space to rest and store your gear, ensuring a comfortable and organized journey. Let the Shadow Seeker be your steadfast companion as you navigate the mysteries of the wilderness.", "15_tent.png", "Embrace the mystery and allure of the mountains with the Shadow Seeker tent.", 1899m, "Shadow Seeker" },
                    { "16", "Reach the pinnacle of mountaineering experiences with the Frost Peak tent. Crafted to withstand challenging terrains and varying weather conditions, this tent is a reliable shelter for adventurers seeking both comfort and durability. Its white exterior mirrors the beauty of snow-covered peaks, while the spacious interior offers a peaceful sanctuary for rest and rejuvenation. Embark on your mountain expeditions with the confidence that the Frost Peak will be your steadfast companion.", "16_tent.png", "Ascend to the heights with the Frost Peak tent.", 1699m, "Frost Peak" },
                    { "17", "Immerse yourself in the untamed beauty of nature with the Earthy Explorer tent. Crafted with outdoor enthusiasts in mind, its earthy brown color represents a strong connection to the wilderness. This tent embraces the rugged aesthetics of the mountains while providing a sturdy and reliable shelter. With its spacious interior and thoughtful design, the Earthy Explorer invites you to embark on unforgettable hiking trips, forging a deeper bond with the natural world around you.", "17_tent.png", "Connect with the natural world on your mountain journeys with the Earthy Explorer tent.", 1599m, "Earthy Explorer" },
                    { "18", "The Coastal Breeze tent in soothing blue hue invites you to experience the tranquility of the great outdoors. Crafted for adventurers who seek solace near water bodies, this tent combines functionality and style. Its lightweight design ensures easy transportation, while the robust materials and reliable construction offer protection against the elements. With ample space to rest and rejuvenate, the Coastal Breeze tent becomes your serene sanctuary as you embark on coastal hikes and lakeside explorations.", "18_tent.png", "Immerse yourself in the calming embrace of nature with the Coastal Breeze tent.", 1699m, "Coastal Breeze" },
                    { "19", "The Snowy Summit tent in pure white stands as a testament to your quest for high-altitude escapades. Designed for mountaineers and alpine enthusiasts, this tent is built to withstand extreme conditions while providing a comfortable and secure shelter. Its durable materials and sturdy structure ensure reliable protection, while the efficient ventilation system keeps you fresh and invigorated amidst the breathtaking beauty of snow-covered peaks. Conquer the highest summits with the Snowy Summit as your trusted companion.", "19_tent.png", "Reach the pinnacle of alpine adventures with the Snowy Summit tent.", 1599m, "Snowy Summit" },
                    { "2", "Immerse yourself in the serene beauty of the mountains with the Forest Oasis tent from Bmerketo. Crafted with high-quality materials, this tent offers a perfect balance of durability and comfort. Its green color palette blends seamlessly with the natural surroundings, providing a peaceful and harmonious retreat. With ample space and thoughtful design, the Forest Oasis ensures a rejuvenating experience for hikers venturing into the mountains.", "2_tent.png", "Step into a tranquil forest oasis with this green hiking tent.", 1899m, "Forest Oasis" },
                    { "20", "The Terra Trailblazer tent in earthy brown color is your ultimate companion for off-the-beaten-path adventures. Crafted with durability and versatility in mind, this tent is designed to withstand the toughest terrains and harshest weather conditions. Its sturdy construction ensures reliable protection, while the spacious interior offers a comfortable retreat after a day of exploring the untamed wilderness. Experience the thrill of venturing into uncharted territories with the Terra Trailblazer as your reliable shelter.", "20_tent.png", "Blaze your own trail through the rugged wilderness with the Terra Trailblazer tent.", 1799m, "Terra Trailblazer" },
                    { "3", "The Evergreen Summit tent is tailored for adventurers seeking a seamless connection with the mountains. Its green exterior echoes the perpetual vibrancy of nature, reflecting your passion for exploration. This tent combines functionality and style, providing a comfortable shelter that withstands the challenges of the wilderness. With spacious interiors and reliable weather resistance, the Evergreen Summit becomes your trusted companion on every hiking expedition.", "3_tent.png", "Conquer new heights while embracing the everlasting beauty of nature with the Evergreen Summit tent.", 1799m, "Evergreen Summit" },
                    { "4", "Embrace the serenity of the mountains with the Mountain Moss tent by Bmerketo. Its green color scheme and earthy tones create a seamless fusion with the surrounding environment. Designed for hikers who value a lightweight and compact shelter, this tent offers exceptional portability without compromising on comfort and protection. Let the Mountain Moss be your hidden sanctuary amidst the grandeur of nature.", "4_tent.png", "Blend into the mountain landscape with the natural hues of the Mountain Moss tent.", 1699m, "Mountain Moss" },
                    { "5", "The Emerald Explorer tent is tailor-made for intrepid adventurers who seek to uncover the secrets of the mountains. Its vibrant green shade symbolizes vitality and curiosity. Crafted with rugged materials and reinforced seams, this tent ensures durability and resilience against the elements. The thoughtfully designed interior provides ample space for comfortable rest and gear storage, making it an essential companion for every hiking journey.", "5_tent.png", "Embark on an expedition of discovery with the Emerald Explorer tent.", 1599m, "Emerald Explorer" },
                    { "6", "Escape the hustle and bustle of everyday life and find your sanctuary in the mountains with the Wildwood Retreat tent. Its green exterior blends seamlessly with the forested landscapes, creating an immersive experience in nature. This tent combines practicality and comfort, featuring easy setup, sturdy construction, and optimal ventilation. Whether you're embarking on a solo adventure or camping with friends, the Wildwood Retreat offers a tranquil haven for your outdoor pursuits.", "6_tent.png", "Find solace in the heart of the wilderness with the Wildwood Retreat tent.", 1499m, "Wildwood Retreat" },
                    { "7", "Let the Sunny Ascent tent be your beacon of warmth and positivity during mountain hikes. Crafted with durability in mind, this tent offers reliable protection against the elements. Its user-friendly setup ensures hassle-free assembly, while the ample space inside allows for comfortable rest and gear storage. The bright yellow color not only lifts your spirits but also ensures high visibility, making it an ideal choice for safety-conscious adventurers.", "7_tent.png", "Embrace sunny days on your mountain expeditions with the Sunny Ascent tent.", 1899m, "Sunny Ascent" },
                    { "8", "The Crimson Summit tent is your reliable companion for thrilling mountain expeditions. Its vibrant red exterior reflects your passion for adventure and determination to reach new summits. Built with rugged materials and reinforced seams, this tent offers exceptional durability and weather resistance. Inside, you'll find a comfortable sanctuary to rest and rejuvenate, ensuring you're ready to face the challenges of the mountains with renewed vigor.", "8_tent.png", "Conquer new heights with the confidence and adventure of the Crimson Summit tent.", 1799m, "Crimson Summit" },
                    { "9", "Fuel your adventurous spirit with the Fiery Ascent tent from Bmerketo. Its bold red color ignites your passion for exploration, while its robust construction guarantees reliability and protection. This tent is designed to withstand various weather conditions, offering you a safe and comfortable retreat amidst the grandeur of the mountains. Unleash your inner adventurer and conquer new heights with the Fiery Ascent as your trusty companion.", "9_tent.png", "Embark on a fiery ascent into the mountains with this red hiking tent.", 1699m, "Fiery Ascent" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "15da8f3e-82c6-41ee-833d-f9c3c16fee39", "3b619961-682f-4f3b-93c5-564f15c543aa" });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ArticleNumber", "CategoryId" },
                values: new object[,]
                {
                    { "1", 2 },
                    { "10", 1 },
                    { "10", 2 },
                    { "10", 3 },
                    { "11", 1 },
                    { "11", 3 },
                    { "12", 1 },
                    { "12", 3 },
                    { "13", 1 },
                    { "13", 3 },
                    { "14", 1 },
                    { "14", 2 },
                    { "14", 3 },
                    { "15", 3 },
                    { "16", 1 },
                    { "17", 1 },
                    { "18", 2 },
                    { "19", 1 },
                    { "2", 1 },
                    { "20", 2 },
                    { "3", 2 },
                    { "4", 2 },
                    { "5", 1 },
                    { "5", 3 },
                    { "6", 2 },
                    { "6", 3 },
                    { "7", 2 },
                    { "7", 3 },
                    { "8", 1 },
                    { "8", 3 },
                    { "9", 2 },
                    { "9", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ContactForms");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
