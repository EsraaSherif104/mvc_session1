using Microsoft.AspNetCore.Mvc;

namespace mvc_session1.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult GetMovie(int[] arr)
        {
            //ContentResult result = new ContentResult();
            //result.Content = $"movie with id:{id}";
            //return result;

            return Content($"Movie with id:");

        }

        //Action parameter binding
        //1.form
        //2.segment  https://localhost:44331/Movies/GetMovie/1  id=1 
        //3.Query string https://localhost:44331/Movies/GetMovie?id=10
        //4.file

        //https://localhost:44331/Movies/GetMovie?id=10&employee.id=10
        //https://localhost:44331/Movies/GetMovie?id=1&arr[0]=10



        public IActionResult Index()
        {
            //ContentResult result = new ContentResult();
           // result.Content = "Hello from index";
            // result.ContentType = "text/html";//default
           // result.ContentType = "object/pdf";

            return Content("hello from index","text/html");


        }

        public IActionResult Test()
        {
            //  RedirectResult result = new RedirectResult("https://localhost:44331/Movies/Index");
            // return Redirect("https://localhost:44331/Movies/Index");
            //   return RedirectToAction("Index");
            //   return RedirectToAction(nameof(Index));
            return RedirectToRoute(new  { controller = "Movies" , action = "Index"});
        }


      //  public IActionResult 

    }
}
