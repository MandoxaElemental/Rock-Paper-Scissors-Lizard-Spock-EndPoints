using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rock_Paper_Scissors_Lizard_Spock.Services;

namespace Rock_Paper_Scissors_Lizard_Spock.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameplayController : ControllerBase
    {
        private readonly GameplayServices _gameplayServices;
        public GameplayController(GameplayServices gameplayServices){
            _gameplayServices = gameplayServices;
        }
        [HttpGet]
        [Route("RPSLS")]
        public List<string>YourChoice(){
            return _gameplayServices.ComputerMove();
        }
    }
}