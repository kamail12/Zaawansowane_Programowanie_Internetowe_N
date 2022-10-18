using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace WebStore.DAL.EF
{
    public class ApplicationDbContext : IdentitiyDbContext<User, Role, int>
    {

    }
}