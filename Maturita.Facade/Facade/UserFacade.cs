using EFCore;
using EFCore.Models;
using Maturita.Facade.Facade.Interface;
using Microsoft.EntityFrameworkCore;

namespace Maturita.Facade.Facade;

public class UserFacade : IFacade<UserEntity>
{

    private DatabaseContext _context;
    
    public UserFacade(DatabaseContext databaseContext)
    {
        _context = databaseContext;
    }
    
    public Task<List<UserEntity>> GetAll()
    {
        Task<List<UserEntity>> users = _context.Users.ToListAsync();
        return users;
    }

    public Task<UserEntity> GetById(Guid id)
    {
        Task<UserEntity> user = _context.Users.FindAsync(id).AsTask();
        return user;
    }

    public Task Add(UserEntity entity)
    {
        _context.Users.AddAsync(entity);
        return _context.SaveChangesAsync();
    }

    public Task Update(UserEntity entity)
    {
        _context.Users.Update(entity);
        return _context.SaveChangesAsync();
    }

    public Task Delete(UserEntity entity)
    {
        _context.Users.Remove(entity);
        return _context.SaveChangesAsync();
    }
}