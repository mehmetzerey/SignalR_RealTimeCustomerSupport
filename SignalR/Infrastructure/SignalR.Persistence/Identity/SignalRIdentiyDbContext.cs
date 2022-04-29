using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SignalR.Domain.Entities;

namespace SignalR.Persistence.Identity;

public class SignalRIdentiyDbContext : IdentityDbContext<ApplicationUser>
{
    public SignalRIdentiyDbContext(DbContextOptions<SignalRIdentiyDbContext> options) : base(options)
    {   }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}

