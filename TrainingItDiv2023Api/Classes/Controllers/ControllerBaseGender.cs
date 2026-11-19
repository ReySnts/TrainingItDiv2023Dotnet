using Microsoft.AspNetCore.Mvc;
using TrainingItDiv2023Api.Classes.Consts;
using TrainingItDiv2023Api.Classes.Helpers;

namespace TrainingItDiv2023Api.Classes.Controllers
{
    [ApiController, Route(template: ConstControllerBase.TEMPLATE)]

    public sealed class ControllerBaseGender(HelperGender helper) : ControllerBase
    {
        private readonly HelperGender helper = helper;

        [HttpGet, Produces(contentType: ConstControllerBase.CONTENT_TYPE)]

        public IActionResult Get() => new OkObjectResult(value: helper.GetAll());
    }
}