using LIS.API.Contracts.Requests;
using LIS.API.Contracts.Responses;
using LIS.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LIS.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LISController : ControllerBase
{
    private readonly ILongestIncreasingSubsequenceService _service;


    public LISController(ILongestIncreasingSubsequenceService service)
    {
        _service = service;
    }


    [HttpPost("find")]
    public ActionResult<LongestIncreasingSubsequenceResponse> Find(LongestIncreasingSubsequenceRequest request)
    {
        var result = _service.Find(request.Input);
        return Ok(new LongestIncreasingSubsequenceResponse
        {
            Sequence = result
        });
    }
}