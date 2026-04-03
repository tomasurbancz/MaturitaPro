
using EFCore;
using EFCore.Models;
using Maturita.Facade.Facade;
using Microsoft.EntityFrameworkCore;

DatabaseContext databaseContext = new DatabaseContext();
databaseContext.Database.Migrate();
UserRepository userRepository = new UserRepository(databaseContext);

UserEntity userEntity = new UserEntity() { Email = "email@email.email", FirstName = "Test", LastName = "Uzivatel", Nickname = "TestovaciUzivatel"};
await userRepository.Add(userEntity);
List<UserEntity> entities = await userRepository.GetAll();
entities.ForEach(entity =>
{
    Console.WriteLine(entity);
});