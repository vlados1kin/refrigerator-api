using Microsoft.AspNetCore.Mvc;
using Refrigerator.Contracts.Service;

namespace Refrigerator.Presentation.Controllers;

[ApiController]
[Route("api/fridges")]
public class FridgeController : ControllerBase
{
    private readonly IServiceManager _service;

    public FridgeController(IServiceManager service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetFridges()
    {
        var fridges = await _service.FridgeService.GetFridgesAsync(trackChanges: false);
        return Ok(fridges);
    }
}