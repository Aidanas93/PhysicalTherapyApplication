using Microsoft.EntityFrameworkCore;
using Moq;
using PhysicalTherapyProject.Domain.Models;
using PhysicalTherapyProject.Persistance.Data;
using PhysicalTherapyProject.Persistance.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace PhysicalTherapyProjectV2.Tests.PhysicalTherapyProject.Persistance.Tests
{
    public class GenericRepositoryTests
    {
        [Fact]
        public async Task Add_PostObjectPassed_ProperMethodCalledAsync()
        {
            // Arrange
            var testObject = new Post();


            var context = new Mock<ApplicationDbContext>();
            var dbSetMock = new Mock<DbSet<Post>>();

            context.Setup(x => x.Set<Post>()).Returns(dbSetMock.Object);
            dbSetMock.Setup(x => x.Add(It.IsAny<Post>()));

            // Act
            var repository = new GenericRepository<Post>(context.Object);
            await repository.AddAsync(testObject);

            //Assert
            context.Verify(x => x.Set<Post>());
            dbSetMock.Verify(x => x.Add(It.Is<Post>(y => y == testObject)));
        }

        [Fact]
        public async Task Add_TagObjectPassed_ProperMethodCalledAsync()
        {
            // Arrange
            var testObject = new Tag();


            var context = new Mock<ApplicationDbContext>();
            var dbSetMock = new Mock<DbSet<Tag>>();

            context.Setup(x => x.Set<Tag>()).Returns(dbSetMock.Object);
            dbSetMock.Setup(x => x.Add(It.IsAny<Tag>()));

            // Act
            var repository = new GenericRepository<Tag>(context.Object);
            await repository.AddAsync(testObject);

            //Assert
            context.Verify(x => x.Set<Tag>());
            dbSetMock.Verify(x => x.Add(It.Is<Tag>(y => y == testObject)));
        }


    }
}
