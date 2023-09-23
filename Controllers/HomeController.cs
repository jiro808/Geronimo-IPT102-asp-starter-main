using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Jonathan Geronimo", StudentId = "S001", StudentAge = "20" },
            new StudentInfoModel { Name = "Luzviminda Geronimo", StudentId = "S002", StudentAge = "22" },
            new StudentInfoModel { Name = "Jonathan Geronimo Sr.", StudentId = "S003", StudentAge = "31" }
        };

        return View(studentInfoArray);
    }
}
