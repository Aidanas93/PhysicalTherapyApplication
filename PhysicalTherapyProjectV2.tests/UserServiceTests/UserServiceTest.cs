using Microsoft.EntityFrameworkCore;
using Moq;
using PhysicalTherapyProjectV2.Data;
using PhysicalTherapyProjectV2.Models;
using PhysicalTherapyProjectV2.Services;
using PhysicalTherapyProjectV2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PhysicalTherapyProjectV2.tests.UserServiceTests
{
    public class UserServiceTest
    {


        [Fact]
        public async Task GetAllAsync_GetUsersListAsync()
        {
            var data = new List<ApplicationUser>
            {
                new ApplicationUser {  Id = 1, Email="user1@gmail.com", PasswordHash="asdf15ds6af16asf" },
                new ApplicationUser {  Id = 2, Email="user2@gmail.com", PasswordHash="agdfsg54qer`221" },
                new ApplicationUser {  Id = 3, Email="user3@gmail.com", PasswordHash="qwfef43546154y615grewdfsga" }
            }.ToList();
            var userServiceMock = new Mock<IGenericService<ApplicationUser>>();
            userServiceMock.Setup(x => x.GetAllAsync()).ReturnsAsync(data);


            var actualList = await userServiceMock.Object.GetAllAsync();


            Assert.Equal(3, actualList.Count);
            Assert.Equal("user1@gmail.com", data[0].Email);
            Assert.Equal("user2@gmail.com", data[1].Email);
            Assert.Equal("user3@gmail.com", data[2].Email);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public async Task GetByIdAsync_ValidId_GetCorrectUser(int id)
        {
            
            IQueryable<ApplicationUser> data = getUsersQueryable();
            var userServiceMock = new Mock<IGenericService<ApplicationUser>>();
            userServiceMock.Setup(x => x.GetByIdAsync(id)).ReturnsAsync(data.Where(u => u.Id == id).FirstOrDefault());

            var user = await userServiceMock.Object.GetByIdAsync(id);

            Assert.Equal(id, user.Id);
            Assert.Equal(data.ToList()[id - 1].Email, user.Email);
            Assert.Equal(data.ToList()[id - 1].PasswordHash, user.PasswordHash);
            Assert.NotNull(user);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        public async Task GetByIdAsync_InvalidId_UserObjectIsNull(int id)
        {
            
            IQueryable<ApplicationUser> data = getUsersQueryable();
            var userServiceMock = new Mock<IGenericService<ApplicationUser>>();
            userServiceMock.Setup(x => x.GetByIdAsync(id)).ReturnsAsync(data.Where(u => u.Id == id).FirstOrDefault());

            var user = await userServiceMock.Object.GetByIdAsync(id);

            Assert.Null(user);
        }

        private static IQueryable<ApplicationUser> getUsersQueryable()
        {
            return new List<ApplicationUser>
            {
                new ApplicationUser {  Id = 1, Email="user1@gmail.com", PasswordHash="asdf15ds6af16asf" },
                new ApplicationUser {  Id = 2, Email="user2@gmail.com", PasswordHash="agdfsg54qer`221" },
                new ApplicationUser {  Id = 3, Email="user3@gmail.com", PasswordHash="qwfef43546154y615grewdfsga" },
            }.AsQueryable();
        }

        [Fact]
        public async Task InsertAsync_ValidUserObject_InsertsOneUserObjectIntoDatabaseAsync()
        {
            var user = new ApplicationUser
            {
                Id = 1,
                Email = "valala@gm.com",
                PasswordHash = "54adsfasdf64d5s6a41v6a"
            };

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
              .UseInMemoryDatabase(databaseName: "addUserToInMemoryDB")
              .Options;

            using (var context = new ApplicationDbContext(options))
            {
                var userService = new UserService(context);
                await userService.InsertAsync(user);
                context.SaveChanges();
            }

            using (var context = new ApplicationDbContext(options))
            {
                Assert.Equal(1, context.Users.Count());
                Assert.Equal(1, context.Users.First().Id);
                Assert.Equal("valala@gm.com", context.Users.First().Email);
                Assert.Equal("54adsfasdf64d5s6a41v6a", context.Users.First().PasswordHash);
            }
        }

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(10)]
        public async Task InsertAsync_ValidUserObject_InsertsEachUserFromListIntoDatabaseAsync(int count)
        {
            var users = getCreatedUsersList(count);
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
              .UseInMemoryDatabase(databaseName: "addSeveralUsersToInMemoryDB")
              .Options;

            using (var context = new ApplicationDbContext(options))
            {
                var userService = new UserService(context);

                foreach (var user in users)
                {
                    await userService.InsertAsync(user);
                }

                context.SaveChanges();
            }

            using (var context = new ApplicationDbContext(options))
            {
                Assert.Equal(users.Count, context.Users.Count());
                for (int i = 0; i < users.Count; i++)
                {
                    Assert.Equal(users[i].Id, context.Users.Find((i + 1)).Id);
                    Assert.Equal(users[i].Email, context.Users.Find((i + 1)).Email);
                    Assert.Equal(users[i].PasswordHash, context.Users.Find((i + 1)).PasswordHash);
                }
                context.Database.EnsureDeleted();
            }
        }



        
        private static List<ApplicationUser> getCreatedUsersList(int count)
        {
            if (count <= 10)
            {
                var usersList = new List<ApplicationUser> {
                    new ApplicationUser {  Id = 1, Email="user1@gmail.com", PasswordHash="asdf15ds6af16asf" },
                    new ApplicationUser {  Id = 2, Email="user2@gmail.com", PasswordHash="agdfsg54qer`221" },
                    new ApplicationUser {  Id = 3, Email="user3@gmail.com", PasswordHash="qwfef43546154y615grewdfsga" },
                    new ApplicationUser {  Id = 4, Email="user4@gmail.com", PasswordHash="avdfswyh6543143143qfa" },
                    new ApplicationUser {  Id = 5, Email="user5@gmail.com", PasswordHash="1rg546yh6aeag" },
                    new ApplicationUser {  Id = 6, Email="user6@gmail.com", PasswordHash="a4arg54qgfvgfvas    43143" },
                    new ApplicationUser {  Id = 7, Email="user7@gmail.com", PasswordHash="1t43t13514g5g514gg15" },
                    new ApplicationUser {  Id = 8, Email="user8@gmail.com", PasswordHash="15g1351g31g351g51313g5" },
                    new ApplicationUser {  Id = 9, Email="user9@gmail.com", PasswordHash="15g3153g135g1g351g35g3" },
                    new ApplicationUser {  Id = 10, Email="user10@gmail.com", PasswordHash="135g1314g31g3414g314g3" },
                    new ApplicationUser {  Id = 11, Email="user11@gmail.com", PasswordHash="143g143g14g314g314g314g3" }
                };

                var returnableList = new List<ApplicationUser>();

                for (int i = 0; i < count; i++)
                {
                    returnableList.Add(usersList[i]);
                }

                return returnableList;
            }
            return null;
        }
/*
        [Fact]
        public async Task UpdateAsync_ValidUserModel_UpdatesUserAsync()
        {
            throw new NotImplementedException();
            #region TestInFuture
            //arrange
            var user = new ApplicationUser
            {
                Id = 1,
                Email = "valala@gm.com",
                PasswordHash = "54adsfasdf64d5s6a41v6a"
            };
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
              .UseInMemoryDatabase(databaseName: "updateUserInMemoryDB")
              .Options;
            using (var context = new ApplicationDbContext(options))
            {
                var userService = new UserService(context);
                await userService.InsertAsync(user);
                context.SaveChanges();
            }
            user.Email = "user1@gm.com";
            user.PasswordHash = "123";

            //act
            using (var context = new ApplicationDbContext(options))
            {
                var userService = new UserService(context);
                await userService.UpdateAsync(user);
                context.SaveChanges();
            }

            //assert
            using (var context = new ApplicationDbContext(options))
            {
                Assert.Equal(1, context.Users.Count());
                Assert.Equal(1, context.Users.First().Id);
                Assert.Equal("user1@gm.com", context.Users.First().Email);
                Assert.Equal("123", context.Users.First().PasswordHash);
            }
            #endregion
        }

        [Fact]
        public void UpdateAsync_InvalidUserModel_ReturnsNull()
        {
            throw new NotImplementedException();
        }
*/
        [Fact]
        public async Task DeleteAsync_ValidUserId_DeletesUserFromDBAsync()
        {
            var user = new ApplicationUser
            {
                Id = 1,
                Email = "valala@gm.com",
                PasswordHash = "54adsfasdf64d5s6a41v6a"
            };
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
              .UseInMemoryDatabase(databaseName: "deleteUserInMemoryDB")
              .Options;
            using (var context = new ApplicationDbContext(options))
            {
                var userService = new UserService(context);
                await userService.InsertAsync(user);
                context.SaveChanges();
            }

            //act
            using (var context = new ApplicationDbContext(options))
            {
                var userService = new UserService(context);
                await userService.DeleteAsync(1);
                context.SaveChanges();
            }

            //assert
            using (var context = new ApplicationDbContext(options))
            {
                Assert.Equal(0, context.Users.Count());
            }
        }

        [Fact]
        public async Task DeleteAsync_InvalidUserId_ReturnsNull()
        {
            //arrange
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
              .UseInMemoryDatabase(databaseName: "deleteNonExistantUserInMemoryDB")
              .Options;

            ApplicationUser actualUser;
            //act
            using (var context = new ApplicationDbContext(options))
            {
                var userService = new UserService(context);
                actualUser = await userService.DeleteAsync(0);
                context.SaveChanges();
            }

            //assert
            using (var context = new ApplicationDbContext(options))
            {
                Assert.Equal(0, context.Users.Count());
                Assert.True(actualUser == null);
            }
        }
    }
}
