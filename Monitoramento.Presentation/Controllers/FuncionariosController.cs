using Microsoft.AspNetCore.Mvc;
using MonitoramentoAPI.Application.Contracts;
using MonitoramentoAPI.Application.ViewModels;
using MonitoramentoAPI.Domain.Exceptions.Funcionario;

namespace MonitoramentoAPI.Presentation.Controllers
{
    [Route("api/[controller]")]
    public class FuncionariosController : ControllerBase
    {
        private readonly IFuncionarioApplicationService funcionarioApplicationService;


        public FuncionariosController(IFuncionarioApplicationService funcionarioApplicationService)
        {
            this.funcionarioApplicationService = funcionarioApplicationService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] FuncionarioAddViewModels model)
        {
            try
            {
                funcionarioApplicationService.Add(model);

                return Ok(
                    new
                    {
                        Mensagem = "Funcionario cadastrado com sucesso. ",
                        Cliente = model
                    });
            }
            catch (EmailDeveSerUnicoException e)
            {
                return StatusCode(403, e.Message);
            }
            
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
