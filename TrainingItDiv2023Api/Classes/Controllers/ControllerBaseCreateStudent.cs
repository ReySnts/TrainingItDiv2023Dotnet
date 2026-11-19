using Microsoft.AspNetCore.Mvc;
using TrainingItDiv2023Api.Classes.Consts;
using TrainingItDiv2023Api.Classes.Helpers;
using TrainingItDiv2023Api.Classes.Inputs;

namespace TrainingItDiv2023Api.Classes.Controllers
{
    [ApiController, Route(template: ConstControllerBase.TEMPLATE)]

    public sealed class ControllerBaseCreateStudent(HelperCreateStudent helper) : ControllerBase
    {
        private readonly HelperCreateStudent helper = helper;

        [HttpPost, Produces(contentType: ConstControllerBase.CONTENT_TYPE)]

        public IActionResult Post(Student input) => new OkObjectResult(value: helper.Create(input));
    }
}