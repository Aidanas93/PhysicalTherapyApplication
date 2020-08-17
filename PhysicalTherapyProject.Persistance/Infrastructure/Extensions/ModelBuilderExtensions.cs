using Microsoft.EntityFrameworkCore;
using PhysicalTherapyProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhysicalTherapyProject.Persistance.Infrastructure.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void SeedDatabase(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.UserPosts)
                .WithOne(p => p.PostUser);

            modelBuilder.Entity<PostType>().HasData(
                new PostType()
                {
                    Id = 1,
                    Name = "Article"
                },
                new PostType()
                {
                    Id = 2,
                    Name = "Advertisment"
                });

            modelBuilder.Entity<Post>().HasData(
                new Post()
                {
                    Id = 1,
                    isForAuthenticatedUser = false,
                    Title = "What is Lorem Ipsum?",
                    Body = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    PostTypeId = 1
                },
                new Post()
                {
                    Id = 2,
                    isForAuthenticatedUser = false,
                    Title = "1914 translation by H. Rackham",
                    Body = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    PostTypeId = 1
                },
                new Post()
                {
                    Id = 3,
                    isForAuthenticatedUser = false,
                    Title = "The standard Lorem Ipsum passage, used since the 1500s",
                    Body = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    PostTypeId = 1
                },
                new Post()
                {
                    Id = 4,
                    isForAuthenticatedUser = false,
                    Title = "Where does it come from?",
                    Body = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    PostTypeId = 1
                },
                new Post()
                {
                    Id = 5,
                    isForAuthenticatedUser = false,
                    Title = "Where can I get some?",
                    Body = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    PostTypeId = 1
                });

            modelBuilder.Entity<Occupation>().HasData(
                new Occupation()
                {
                    Id = 1,
                    Name = "Studentas"
                },
                new Occupation()
                {
                    Id = 2,
                    Name = "Dėstytojas"
                },
                new Occupation()
                {
                    Id = 3,
                    Name = "Kineziterapeutas"
                });
        }
    }
}
