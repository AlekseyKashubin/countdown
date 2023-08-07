using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


// Be sure to use your own project's namespace here! 
namespace countdown.Controllers;

public class CountdownController : Controller
{


    [HttpGet("")]
    public ViewResult Countdown()
    {

        return View("Countdown");
    }



}