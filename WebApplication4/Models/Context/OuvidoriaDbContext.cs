using System.Data.Entity;

public class OuvidoriaDbContext : DbContext
{
    public DbSet<Denuncia> Denuncia { get; set; }
    public DbSet<Usuario> Usuario { get; set; }
    public DbSet<Envolvido> Envolvido { get; set; }
}
