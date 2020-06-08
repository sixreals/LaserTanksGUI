using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using LaserTanksGUI.Models;

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
            return View("GameSetup");
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
            List<Player> players = new List<Player>();

            //create each player class
            foreach(var name in playerNames)
            {
                players.Add(new Player(name));
            }

            Game game = new Game(players);

            ViewData["PlayerNames"] = playerNames;
            return View("RunGame", game);
        }
    }
}