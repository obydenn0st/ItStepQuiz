using Microsoft.AspNetCore.Mvc;

namespace ItStepQuiz.Controllers.Room;

public class RoomController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> FindRoom()
    {
        return View();
    }
}
