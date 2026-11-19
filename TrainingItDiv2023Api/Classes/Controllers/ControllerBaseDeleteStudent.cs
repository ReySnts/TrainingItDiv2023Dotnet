using Microsoft.AspNetCore.Mvc;
using TrainingItDiv2023Api.Classes.Consts;
using TrainingItDiv2023Api.Classes.Helpers;

namespace TrainingItDiv2023Api.Classes.Controllers
{
    [ApiController, Route(template: ConstControllerBase.TEMPLATE)]

    public sealed class ControllerBaseDeleteStudent(HelperDeleteStudent helper) : ControllerBase
    {
        private readonly HelperDeleteStudent helper = helper;

        [HttpDelete, Produces(contentType: ConstControllerBase.CONTENT_TYPE)]

        public IActionResult Delete(int id) => new OkObjectResult(value: helper.Delete(id));
    }
}