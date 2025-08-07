using B2BOrderManagement.Models.User;
using B2BOrderManagement.Data;
using Microsoft.EntityFrameworkCore;

namespace B2BOrderManagement.Repositories
{
    public class UserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<User>> GetAllUsersAsync()
        {
            // Simulate asynchronous database operation
            return await _context.Users.AsNoTracking() // Use AsNoTracking for read-only operations
                .ToListAsync(); // Returns a list of users without tracking changes
        }
        public async Task<bool> AddUser(User user)
        {
            // Simulate asynchronous database operation
            await _context.Users.AddAsync(user); // Add user to the context
            return await _context.SaveChangesAsync() > 0; // Returns true if changes were saved
        }
        public async Task<User?> GetUserByIdAsync(int id)
        {
            // Simulate asynchronous database operation
            return await _context.Users
                .AsNoTracking() // Use AsNoTracking for read-only operations
                .FirstOrDefaultAsync(u => u.Id == id);
        }
        public async Task<bool> UpdateUserAsync(User user)
        {
            // Simulate asynchronous database operation
            _context.Users.Update(user);
            return await _context.SaveChangesAsync() > 0; // Returns true if changes were saved
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            // Simulate asynchronous database operation
            var user = await GetUserByIdAsync(id);
            if (user == null) return false; // User not found

            _context.Users.Remove(user);
            return await _context.SaveChangesAsync() > 0; // Returns true if changes were saved
        }
    }
}

