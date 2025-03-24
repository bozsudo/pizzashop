using Microsoft.AspNetCore.Mvc;

namespace api;

[ApiController]
[Route("api/[controller]")]
public class PizzasController: ControllerBase
{
    private readonly PizzaService _pizzaService;

    public PizzasController(PizzaService pizzaService) =>
        _pizzaService = pizzaService;

    [HttpGet]
    public async Task<List<Pizza>> Get() =>
        await _pizzaService.GetAllAsync();
}
