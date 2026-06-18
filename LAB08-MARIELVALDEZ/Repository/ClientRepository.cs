using LAB08_MARIELVALDEZ.Models;
using LAB08_MARIELVALDEZ.Repository.interfaces;
using Microsoft.EntityFrameworkCore;

namespace LAB08_MARIELVALDEZ.Repository;


public class ClientRepository : IClientRepository {
    private readonly Practica08Context _context; 
    public ClientRepository(Practica08Context context) { _context = context; } 

    public async Task<IEnumerable<Cliente>> GetClientsByNameAsync(string name) {
        return await _context.Clientes
            .Where(c => c.Name.Contains(name))  
            .ToListAsync();
    }
}