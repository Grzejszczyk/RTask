using Microsoft.AspNetCore.Mvc;
using RTask.Application.Interfaces;
using RTask.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RTask.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly IExerciseService _exerciseService;
        public ExerciseController(IExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
        }

        [HttpGet("{id}")]
        public ActionResult<ExerciseVM> Get(int id)
        {
            var result = _exerciseService.GetExerciceById(id);
            if (result == null)
            {
                return NotFound("Exercise not found.");
            }
            return Ok(result);
        }
    }
}
