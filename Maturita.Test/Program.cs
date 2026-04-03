
using EFCore;
using EFCore.Models;
using Maturita.Facade.Facade;
using Microsoft.EntityFrameworkCore;

DatabaseContext databaseContext = new DatabaseContext();
databaseContext.Database.Migrate();
UserFacade userFacade = new UserFacade(databaseContext);

UserEntity userEntity = new UserEntity() { Email = "email@email.email", FirstName = "Test", LastName = "Uzivatel", Nickname = "TestovaciUzivatel"};
await userFacade.Add(userEntity);
List<UserEntity> entities = await userFacade.GetAll();
entities.ForEach(entity =>
{
    Console.WriteLine(entity);
});