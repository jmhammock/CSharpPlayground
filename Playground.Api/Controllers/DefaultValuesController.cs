using Microsoft.AspNetCore.Mvc;
using Playground.Api.Models.PayloadModels;

namespace Playground.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class DefaultValuesController : ControllerBase
{
    [HttpPost]
    public string Post([FromBody] DefaultModelsPayload payload)
    {
        return $"Integer: {payload.Integer}, Float: {payload.Float}, Double: {payload.Double}, Decimal: {payload.Decimal}, Boolean: {payload.Boolean}, String: {payload.String}";
    }
}