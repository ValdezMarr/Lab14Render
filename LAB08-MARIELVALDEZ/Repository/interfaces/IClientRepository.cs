using LAB08_MARIELVALDEZ.Models;

namespace LAB08_MARIELVALDEZ.Repository.interfaces;

public interface IClientRepository {
    Task<IEnumerable<Cliente>> GetClientsByNameAsync(string name);
}