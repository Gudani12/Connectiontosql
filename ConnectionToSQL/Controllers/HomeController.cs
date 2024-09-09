using ConnectionToSQL.Models;
using database.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // Home Page
    public IActionResult Index()
    {
        return View();
    }

    // Privacy Page
    public IActionResult Privacy()
    {
        return View();
    }

    // Register Page
    public IActionResult Register()
    {
        return View();
    }

    // Login Page
    public IActionResult Login()
    {
        return View();
    }

    // Edit Personal Details Page
    public IActionResult EditPersonalDetails()
    {
        return View();
    }

    // Submit Claim (GET)
    public IActionResult SubmitClaim()
    {
        var claim = new Claim();  // Create a new claim object
        return View(claim);       // Pass the claim object to the view
    }

    // Submit Claim (POST)
    [HttpPost]
    public IActionResult SubmitClaim(Claim claim, IFormFile SupportingDocument)
    {
        if (ModelState.IsValid)
        {
            // Logic for handling claim, including saving the supporting document
            // (You could save to the database here)

            // Redirect to Success Page or Index after submission
            return RedirectToAction("ClaimSuccess");
        }
        return View(claim);
    }

    // Claim Success Page
    public IActionResult ClaimSuccess()
    {
        return View();
    }

    // Submitted Claims Page
    public IActionResult SubmittedClaims()
    {
        // Logic to get submitted claims from the database
        return View();
    }

    // Verify Claims Page
    public IActionResult VerifyClaims()
    {
        // Logic to verify claims
        return View();
    }

    // Approve Claims Page
    public IActionResult ApproveClaims()
    {
        // Logic to approve claims
        return View();
    }

    // Error Page
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
