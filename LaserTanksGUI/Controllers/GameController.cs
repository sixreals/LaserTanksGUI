using System;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace LaserTanksGUI.Controllers
{
    public class GameController : Controller
    {
        /// <summary>
        /// Sets p the configure new game menu
        /// </summary>
        /// <param name="numPlayers"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult NewGame(string numPlayers)
        {
            ViewData["numPlayers"] = numPlayers;
            return View("GameSetup", Convert.ToInt32(numPlayers));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="playerNames"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult CreateGame(params string[] playerNames)
        {
            ViewData["NumPlayers"] = playerNames.Length;
            ViewData["PlayerNames"] = playerNames;
            return View("RunGame");
        }
    }
}