using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Integro.App.ViewModels;

namespace Integro.App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Integro.App.ViewModels.FornecedorViewModel> FornecedorViewModel { get; set; }
        public DbSet<Integro.App.ViewModels.ProdutoViewModel> ProdutoViewModel { get; set; }
        public DbSet<Integro.App.ViewModels.EnderecoViewModel> EnderecoViewModel { get; set; }
    }
}
