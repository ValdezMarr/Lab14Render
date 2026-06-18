using LAB08_MARIELVALDEZ.Repository.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LAB08_MARIELVALDEZ.Controller;

[ApiController]
[Route("api/[controller]")]
public class ClientSearchController : ControllerBase
{
    private readonly IClientRepository _clientRepository;

    public ClientSearchController(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    /// <summary>
    /// Ejercicio 1: Obtener los Clientes que Tienen un Nombre Específico
    /// </summary>
    /// <param name="name">Nombre o parte del nombre a buscar</param>
    /// <returns>Lista de clientes que coinciden con el nombre</returns>
    [HttpGet]
    public async Task<IActionResult> GetClientsByName([FromQuery] string name)
    {
        var clients = await _clientRepository.GetClientsByNameAsync(name);
        return Ok(clients);
    }
}