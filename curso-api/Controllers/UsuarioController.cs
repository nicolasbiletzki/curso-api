using curso_api.Models.Usuarios;
using Microsoft.AspNetCore.Mvc;

namespace curso_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        public IActionResult Logar(LoginViewModelInput loginViewModelInput)
        {
            return Created("", loginViewModelInput);
        }
    }
}
