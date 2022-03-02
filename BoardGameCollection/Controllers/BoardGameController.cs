using Microsoft.AspNetCore.Mvc;
using BoardGameCollection.Models;
using System.Linq;
using System.Collections.Generic;

namespace BoardGameCollection.Controllers

{
  public class BoardGamesController : Controller
  {
    private readonly BoardGameCollectionContext _db;
    public BoardGamesController(BoardGameCollectionContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<BoardGame> model = _db.BoardGames.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create (BoardGame boardGame)
    {
      _db.BoardGames.Add(boardGame);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      BoardGame thisBoardGame = _db.BoardGames.FirstOrDefault(boardGame => boardGame.BoardGameId == id);
      return View(thisBoardGame);
    }
  }
}