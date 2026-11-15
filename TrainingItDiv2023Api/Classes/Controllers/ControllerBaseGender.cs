using Microsoft.AspNetCore.Mvc;
using TrainingItDiv2023Api.Classes.Helpers;

namespace TrainingItDiv2023Api.Classes.Controllers
{
    [ApiController, Route("api/[controller]")]

    public sealed class ControllerBaseGender(HelperGender helper) : ControllerBase
    {
        private readonly HelperGender helper = helper;

        [HttpGet, Produces(contentType: "application/json")]

        public IActionResult Get() => new OkObjectResult(value: helper.GetAll());
    }
}