using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DeckOfCardsAPI.Models;

namespace DeckOfCardsAPI.Controllers;

public class HomeController : Controller
{
    DeckDAL dal = new DeckDAL();
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Deck d = dal.NewDeck();
        PlayerHand c = dal.DrawACard(d.deck_id);
        
        return View(c);
    }

    public IActionResult DrawAgain()
    {
        Deck d = dal.NewDeck();
        PlayerHand c = dal.DrawACard(d.deck_id);

        return View(c);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

