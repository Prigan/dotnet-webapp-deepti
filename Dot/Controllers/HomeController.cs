using Dot.Services;
using Dot.Services.Models;
using Dot.Models;
using Dot.Data;
using Dot.Data.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Dot.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDotService _dotService;
        private readonly IConfiguration _configuration;

        public HomeController(IDotService dotService, IConfiguration configuration)
        {
            _dotService = dotService;
            _configuration = configuration;
        }

        /// <summary>
        /// Shows list of users
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(_dotService.GetAllUsers());
        }

        /// <summary>
        /// Uses the GitHub search user api to fetch users with a mathcing username
        /// </summary>
        /// <param name="query"></param>
        /// <returns>A list of searched results</returns>
        public async Task<IActionResult> SearchAsync(string query)
        {
            query = $"{_configuration.GetSection("GitHubSearchUserApiBase").Value}{query}";
            string searchResults = await DOt.Helpers.Utilities.MakeGitHubApiRequestAsync(query);
            var searchedProfiles = _dotService.GetParsedUsersList(searchResults);
            return View("Index", searchedProfiles);
        }

        /// <summary>
        /// Adds a user if user does not exist, else updates the user
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Http 200 with message if successful, Http 400 if there was an error</returns>
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AddUser(UserVm user)
        {
            if (user == null && user.Id <= 0)
            {
                return BadRequest();
            }

            _dotService.AddUser(user);
            return Ok("Added");
        }

        /// <summary>
        /// Allows the user to toggle favorite flag for each user
        /// </summary>
        /// <param name="id"></param>
        public void ToggleFavorite(int id)
        {
            var user = _dotService.FindUserById(id);
            if (user == null)
            {
                RedirectToAction("Error", "Index");
            }
            else
            {
                user.IsFavorite = !user.IsFavorite;
                _dotService.EditUser(user);
            }
        }

        /// <summary>
        /// Removed a user from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Redirection to appropriate page</returns>
        public IActionResult Delete(int id)
        {
            if (!_dotService.DeleteUserById(id))
            {
                RedirectToAction("Error", "Home");
            }

            return RedirectToAction("Index");
        }

        /// <summary>
        /// Generic error page
        /// </summary>
        /// <returns>View with error message</returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(string message)
        {
            return View(new ErrorViewModel { Message = message, RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
