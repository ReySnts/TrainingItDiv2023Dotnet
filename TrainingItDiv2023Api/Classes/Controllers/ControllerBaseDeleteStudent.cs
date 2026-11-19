using Microsoft.AspNetCore.Mvc;
using TrainingItDiv2023Api.Classes.Helpers;

namespace TrainingItDiv2023Api.Classes.Controllers
{
    [ApiController, Route("api/[controller]")]

    public sealed class ControllerBaseDeleteStudent(HelperDeleteStudent helper) : ControllerBase
    {
        private readonly HelperDeleteStudent helper = helper;

        [HttpDelete(template: "{id}"), Produces(contentType: "application/json")]

        public IActionResult Delete(int id) => new OkObjectResult(value: helper.Delete(id));
    }
}