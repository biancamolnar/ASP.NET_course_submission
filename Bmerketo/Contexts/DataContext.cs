using Bmerketo.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bmerketo.Contexts;

public class DataContext : IdentityDbContext<UserEntity>
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<CategoryEntity> Categories { get; set; }
    public DbSet<ProductCategoryEntity> ProductCategories { get; set; }
    public DbSet<ContactFormEntity> ContactForms { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        var adminRoleId = Guid.NewGuid().ToString();

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = adminRoleId,
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            },
            new IdentityRole
            {
                Id = Guid.NewGuid().ToString(),
                Name = "User",
                NormalizedName = "USER",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            });

        var passwordHasher = new PasswordHasher<UserEntity>();
        var userEntity = new UserEntity
        {
            Id = Guid.NewGuid().ToString(),
            UserName = "admin@domain.com",
            NormalizedUserName = "ADMIN@DOMAIN.COM",
            Email = "admin@domain.com",
            NormalizedEmail = "ADMIN@DOMAIN.COM",
            ConcurrencyStamp = Guid.NewGuid().ToString(),
        };

        userEntity.PasswordHash = passwordHasher.HashPassword(userEntity, "BytMig123!");
        builder.Entity<UserEntity>().HasData(userEntity);

        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        {
            UserId = userEntity.Id,
            RoleId = adminRoleId,
        });

        builder.Entity<CategoryEntity>().HasData(
            new CategoryEntity { Id = 1, CategoryName = "new" },
            new CategoryEntity { Id = 2, CategoryName = "featured" },
            new CategoryEntity { Id = 3, CategoryName = "popular" }
        );

        builder.Entity<ProductEntity>().HasData(
            new ProductEntity { ArticleNumber = "1", Title = "Verdant Haven", Price = 1999, ImageUrl = "1_tent.png", Ingress = "Experience nature in full bloom with the Verdant Haven tent.", Description = "Designed for hiking trips in the mountains, the Verdant Haven tent provides a spacious and well-ventilated retreat. Unwind amidst the lush greenery of the mountains with this tent from Bmerketo. Its generous interior space offers ample room for rest and storage, ensuring a comfortable and organized adventure. The tent's durable materials and sturdy construction withstand rugged terrains, while the vibrant green color blends harmoniously with the surrounding landscape, making it an eco-conscious choice for nature enthusiasts." },
            new ProductEntity { ArticleNumber = "2", Title = "Forest Oasis", Price = 1899, ImageUrl = "2_tent.png", Ingress = "Step into a tranquil forest oasis with this green hiking tent.", Description = "Immerse yourself in the serene beauty of the mountains with the Forest Oasis tent from Bmerketo. Crafted with high-quality materials, this tent offers a perfect balance of durability and comfort. Its green color palette blends seamlessly with the natural surroundings, providing a peaceful and harmonious retreat. With ample space and thoughtful design, the Forest Oasis ensures a rejuvenating experience for hikers venturing into the mountains." },
            new ProductEntity { ArticleNumber = "3", Title = "Evergreen Summit", Price = 1799, ImageUrl = "3_tent.png", Ingress = "Conquer new heights while embracing the everlasting beauty of nature with the Evergreen Summit tent.", Description = "The Evergreen Summit tent is tailored for adventurers seeking a seamless connection with the mountains. Its green exterior echoes the perpetual vibrancy of nature, reflecting your passion for exploration. This tent combines functionality and style, providing a comfortable shelter that withstands the challenges of the wilderness. With spacious interiors and reliable weather resistance, the Evergreen Summit becomes your trusted companion on every hiking expedition." },
            new ProductEntity { ArticleNumber = "4", Title = "Mountain Moss", Price = 1699, ImageUrl = "4_tent.png", Ingress = "Blend into the mountain landscape with the natural hues of the Mountain Moss tent.", Description = "Embrace the serenity of the mountains with the Mountain Moss tent by Bmerketo. Its green color scheme and earthy tones create a seamless fusion with the surrounding environment. Designed for hikers who value a lightweight and compact shelter, this tent offers exceptional portability without compromising on comfort and protection. Let the Mountain Moss be your hidden sanctuary amidst the grandeur of nature." },
            new ProductEntity { ArticleNumber = "5", Title = "Emerald Explorer", Price = 1599, ImageUrl = "5_tent.png", Ingress = "Embark on an expedition of discovery with the Emerald Explorer tent.", Description = "The Emerald Explorer tent is tailor-made for intrepid adventurers who seek to uncover the secrets of the mountains. Its vibrant green shade symbolizes vitality and curiosity. Crafted with rugged materials and reinforced seams, this tent ensures durability and resilience against the elements. The thoughtfully designed interior provides ample space for comfortable rest and gear storage, making it an essential companion for every hiking journey." },
            new ProductEntity { ArticleNumber = "6", Title = "Wildwood Retreat", Price = 1499, ImageUrl = "6_tent.png", Ingress = "Find solace in the heart of the wilderness with the Wildwood Retreat tent.", Description = "Escape the hustle and bustle of everyday life and find your sanctuary in the mountains with the Wildwood Retreat tent. Its green exterior blends seamlessly with the forested landscapes, creating an immersive experience in nature. This tent combines practicality and comfort, featuring easy setup, sturdy construction, and optimal ventilation. Whether you're embarking on a solo adventure or camping with friends, the Wildwood Retreat offers a tranquil haven for your outdoor pursuits." },
            new ProductEntity { ArticleNumber = "7", Title = "Sunny Ascent", Price = 1899, ImageUrl = "7_tent.png", Ingress = "Embrace sunny days on your mountain expeditions with the Sunny Ascent tent.", Description = "Let the Sunny Ascent tent be your beacon of warmth and positivity during mountain hikes. Crafted with durability in mind, this tent offers reliable protection against the elements. Its user-friendly setup ensures hassle-free assembly, while the ample space inside allows for comfortable rest and gear storage. The bright yellow color not only lifts your spirits but also ensures high visibility, making it an ideal choice for safety-conscious adventurers." },
            new ProductEntity { ArticleNumber = "8", Title = "Crimson Summit", Price = 1799, ImageUrl = "8_tent.png", Ingress = "Conquer new heights with the confidence and adventure of the Crimson Summit tent.", Description = "The Crimson Summit tent is your reliable companion for thrilling mountain expeditions. Its vibrant red exterior reflects your passion for adventure and determination to reach new summits. Built with rugged materials and reinforced seams, this tent offers exceptional durability and weather resistance. Inside, you'll find a comfortable sanctuary to rest and rejuvenate, ensuring you're ready to face the challenges of the mountains with renewed vigor." },
            new ProductEntity { ArticleNumber = "9", Title = "Fiery Ascent", Price = 1699, ImageUrl = "9_tent.png", Ingress = "Embark on a fiery ascent into the mountains with this red hiking tent.", Description = "Fuel your adventurous spirit with the Fiery Ascent tent from Bmerketo. Its bold red color ignites your passion for exploration, while its robust construction guarantees reliability and protection. This tent is designed to withstand various weather conditions, offering you a safe and comfortable retreat amidst the grandeur of the mountains. Unleash your inner adventurer and conquer new heights with the Fiery Ascent as your trusty companion." },
            new ProductEntity { ArticleNumber = "10", Title = "Blaze Trailblazer", Price = 1799, ImageUrl = "10_tent.png", Ingress = "Ignite your path with the Blaze Trailblazer tent, designed for intrepid explorers.", Description = "Prepare to blaze new trails with the Trailblazer tent from Bmerketo. This lightweight and compact tent is crafted for hikers who seek agility without compromising on durability. Its orange hue symbolizes the spirit of exploration, and its waterproof construction ensures you stay protected in changing weather conditions. With easy setup and ample interior space, the Trailblazer is your reliable shelter on the mountains, allowing you to focus on the thrill of the journey." },
            new ProductEntity { ArticleNumber = "11", Title = "Citrus Blaze", Price = 1699, ImageUrl = "11_tent.png", Ingress = "Immerse yourself in the invigorating aura of the Citrus Blaze tent.", Description = "The Citrus Blaze tent infuses your outdoor adventures with a burst of vibrant energy. Its vivid orange color radiates enthusiasm and adds a touch of excitement to your mountain escapades. Crafted with durability and functionality in mind, this tent provides reliable protection and comfort. Whether you're embarking on a solo expedition or camping with friends, the Citrus Blaze ensures a cozy and secure shelter, allowing you to fully embrace the wonders of nature." },
            new ProductEntity { ArticleNumber = "12", Title = "Azure Crest", Price = 1699, ImageUrl = "12_tent.png", Ingress = "Discover tranquility amidst the mountains with the Azure Crest tent.", Description = "Immerse yourself in the soothing serenity of the Azure Crest tent. Designed for hikers seeking peace and relaxation, its elegant blue color evokes the beauty of clear skies and pristine waters. Crafted with meticulous attention to detail, this tent offers excellent ventilation, ensuring a comfortable and refreshing sleep after a day of mountain exploration. Its durable materials and sturdy structure provide reliable protection, allowing you to experience the true essence of nature without compromising on comfort." },
            new ProductEntity { ArticleNumber = "13", Title = "Sapphire Summit", Price = 1599, ImageUrl = "13_tent.png", Ingress = "Reach new heights with the Sapphire Summit tent, your gateway to alpine wonders.", Description = "The Sapphire Summit tent is designed to accompany you on your mountain journeys with style and reliability. Its captivating blue color reflects the majesty of glacial lakes and towering peaks. Crafted with high-quality materials, this tent offers optimal weather protection and durability. Its spacious interior provides ample room for rest and gear storage, while the thoughtfully designed ventilation system ensures a comfortable and refreshing experience amidst the breathtaking beauty of the mountains." },
            new ProductEntity { ArticleNumber = "14", Title = "Alpine Mist", Price = 1799, ImageUrl = "14_tent.png", Ingress = "Experience the enchantment of alpine landscapes with the Alpine Mist tent.", Description = "Step into the ethereal world of mountain peaks with the Alpine Mist tent. Inspired by the breathtaking beauty of alpine landscapes, its blue and white color scheme captures the essence of majestic snow-capped summits. Crafted with premium materials, this tent ensures durability and protection during your hiking adventures. Its spacious interior and efficient ventilation create a cozy haven where you can recharge and reflect on the awe-inspiring sights surrounding you." },
            new ProductEntity { ArticleNumber = "15", Title = "Shadow Seeker", Price = 1899, ImageUrl = "15_tent.png", Ingress = "Embrace the mystery and allure of the mountains with the Shadow Seeker tent.", Description = "Venture into the unknown with the Shadow Seeker tent from Bmerketo. Its sleek black exterior symbolizes the enigmatic beauty of the mountains, while its robust construction provides reliable shelter against harsh elements. Designed for intrepid explorers, this tent offers ample space to rest and store your gear, ensuring a comfortable and organized journey. Let the Shadow Seeker be your steadfast companion as you navigate the mysteries of the wilderness." },
            new ProductEntity { ArticleNumber = "16", Title = "Frost Peak", Price = 1699, ImageUrl = "16_tent.png", Ingress = "Ascend to the heights with the Frost Peak tent.", Description = "Reach the pinnacle of mountaineering experiences with the Frost Peak tent. Crafted to withstand challenging terrains and varying weather conditions, this tent is a reliable shelter for adventurers seeking both comfort and durability. Its white exterior mirrors the beauty of snow-covered peaks, while the spacious interior offers a peaceful sanctuary for rest and rejuvenation. Embark on your mountain expeditions with the confidence that the Frost Peak will be your steadfast companion." },
            new ProductEntity { ArticleNumber = "17", Title = "Earthy Explorer", Price = 1599, ImageUrl = "17_tent.png", Ingress = "Connect with the natural world on your mountain journeys with the Earthy Explorer tent.", Description = "Immerse yourself in the untamed beauty of nature with the Earthy Explorer tent. Crafted with outdoor enthusiasts in mind, its earthy brown color represents a strong connection to the wilderness. This tent embraces the rugged aesthetics of the mountains while providing a sturdy and reliable shelter. With its spacious interior and thoughtful design, the Earthy Explorer invites you to embark on unforgettable hiking trips, forging a deeper bond with the natural world around you." },
            new ProductEntity { ArticleNumber = "18", Title = "Coastal Breeze", Price = 1699, ImageUrl = "18_tent.png", Ingress = "Immerse yourself in the calming embrace of nature with the Coastal Breeze tent.", Description = "The Coastal Breeze tent in soothing blue hue invites you to experience the tranquility of the great outdoors. Crafted for adventurers who seek solace near water bodies, this tent combines functionality and style. Its lightweight design ensures easy transportation, while the robust materials and reliable construction offer protection against the elements. With ample space to rest and rejuvenate, the Coastal Breeze tent becomes your serene sanctuary as you embark on coastal hikes and lakeside explorations." },
            new ProductEntity { ArticleNumber = "19", Title = "Snowy Summit", Price = 1599, ImageUrl = "19_tent.png", Ingress = "Reach the pinnacle of alpine adventures with the Snowy Summit tent.", Description = "The Snowy Summit tent in pure white stands as a testament to your quest for high-altitude escapades. Designed for mountaineers and alpine enthusiasts, this tent is built to withstand extreme conditions while providing a comfortable and secure shelter. Its durable materials and sturdy structure ensure reliable protection, while the efficient ventilation system keeps you fresh and invigorated amidst the breathtaking beauty of snow-covered peaks. Conquer the highest summits with the Snowy Summit as your trusted companion." },
            new ProductEntity { ArticleNumber = "20", Title = "Terra Trailblazer", Price = 1799, ImageUrl = "20_tent.png", Ingress = "Blaze your own trail through the rugged wilderness with the Terra Trailblazer tent.", Description = "The Terra Trailblazer tent in earthy brown color is your ultimate companion for off-the-beaten-path adventures. Crafted with durability and versatility in mind, this tent is designed to withstand the toughest terrains and harshest weather conditions. Its sturdy construction ensures reliable protection, while the spacious interior offers a comfortable retreat after a day of exploring the untamed wilderness. Experience the thrill of venturing into uncharted territories with the Terra Trailblazer as your reliable shelter." }
            );

        builder.Entity<ProductCategoryEntity>().HasData(
            new ProductCategoryEntity { ArticleNumber = "1", CategoryId = 2 },
            new ProductCategoryEntity { ArticleNumber = "2", CategoryId = 1 },
            new ProductCategoryEntity { ArticleNumber = "3", CategoryId = 2 },
            new ProductCategoryEntity { ArticleNumber = "4", CategoryId = 2 },
            new ProductCategoryEntity { ArticleNumber = "5", CategoryId = 1 },
            new ProductCategoryEntity { ArticleNumber = "5", CategoryId = 3 },
            new ProductCategoryEntity { ArticleNumber = "6", CategoryId = 2 },
            new ProductCategoryEntity { ArticleNumber = "6", CategoryId = 3 },
            new ProductCategoryEntity { ArticleNumber = "7", CategoryId = 2 },
            new ProductCategoryEntity { ArticleNumber = "7", CategoryId = 3 },
            new ProductCategoryEntity { ArticleNumber = "8", CategoryId = 1 },
            new ProductCategoryEntity { ArticleNumber = "8", CategoryId = 3 },
            new ProductCategoryEntity { ArticleNumber = "9", CategoryId = 2 },
            new ProductCategoryEntity { ArticleNumber = "9", CategoryId = 3 },
            new ProductCategoryEntity { ArticleNumber = "10", CategoryId = 1 },
            new ProductCategoryEntity { ArticleNumber = "10", CategoryId = 2 },
            new ProductCategoryEntity { ArticleNumber = "10", CategoryId = 3 },
            new ProductCategoryEntity { ArticleNumber = "11", CategoryId = 1 },
            new ProductCategoryEntity { ArticleNumber = "11", CategoryId = 3 },
            new ProductCategoryEntity { ArticleNumber = "12", CategoryId = 1 },
            new ProductCategoryEntity { ArticleNumber = "12", CategoryId = 3 },
            new ProductCategoryEntity { ArticleNumber = "13", CategoryId = 1 },
            new ProductCategoryEntity { ArticleNumber = "13", CategoryId = 3 },
            new ProductCategoryEntity { ArticleNumber = "14", CategoryId = 2 },
            new ProductCategoryEntity { ArticleNumber = "14", CategoryId = 3 },
            new ProductCategoryEntity { ArticleNumber = "14", CategoryId = 1 },
            new ProductCategoryEntity { ArticleNumber = "15", CategoryId = 3 },
            new ProductCategoryEntity { ArticleNumber = "16", CategoryId = 1 },
            new ProductCategoryEntity { ArticleNumber = "17", CategoryId = 1 },
            new ProductCategoryEntity { ArticleNumber = "18", CategoryId = 2 },
            new ProductCategoryEntity { ArticleNumber = "19", CategoryId = 1 },
            new ProductCategoryEntity { ArticleNumber = "20", CategoryId = 2 }
        );
    }
}
