using AutoMapper;
using Microsoft.AspNetCore.Mvc;
namespace WebStore.Web.Controllers;
[ApiController] //
[Produces("application/json")] //wymusza zwrócenie jsodpowiedzi w formacie ON 
[Route("api/[controller]")] //wymusza routing
public abstract class BaseApiController : Controller
{
    protected readonly ILogger Logger;
    protected readonly IMapper Mapper;
    protected BaseApiController(ILogger logger, IMapper mapper)
    {
        Logger = logger;
        Mapper = mapper;
    }
}