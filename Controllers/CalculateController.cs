using CalcurateApi.Models;
using CalcurateApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CalcurateApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculateController : ControllerBase
{
    private readonly ICalculateService _calculateService;

    public CalculateController(
        ICalculateService calculateService)
    {
        _calculateService = calculateService;
    }

    [HttpPost("prime")]
    public IActionResult CheckPrime(
        [FromBody] PrimeNumberRequest request)
    {
        var result = _calculateService.CheckPrime(
            request.Number);

        return Ok(result);
    }
}