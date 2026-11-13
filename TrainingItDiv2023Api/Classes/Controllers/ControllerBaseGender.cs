using Microsoft.AspNetCore.Mvc;
using TrainingItDiv2023Api.Classes.Helpers;
using TrainingItDiv2023Api.Classes.Outputs;

namespace TrainingItDiv2023Api.Classes.Controllers
{
    [ApiController, Route("api/[controller]")]

    public sealed class ControllerBaseGender(HelperGender helper) : ControllerBase
    {
        private readonly HelperGender helper = helper;

        [HttpGet, Produces(contentType: "application/json")]

        public IActionResult Get()
        {
            var value = new OutputGender();

            value.Set(listPayloads: helper.GetAll());

            return new OkObjectResult(value);
        }
    }
}