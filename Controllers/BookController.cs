using LibraryManagementSystem.Models;
using LibraryManagementSystem.Models.CrudModels;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace LibraryManagementSystem.Controllers
{
    public class BookController : Controller
    {
        private readonly HttpClient _httpClient;

        public BookController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
           // var client = httpClient.CreateClient();
            var book = await _httpClient.GetFromJsonAsync<List<Book>>("http://localhost:5111/api/Publisher");
            return View(book);
        }
        [HttpPost]
        public async Task<IActionResult> Create(AddBooks book)
        {
            if (ModelState.IsValid)
            {
                var response = await _httpClient.PostAsJsonAsync("http://localhost:5111/api/Publisher", book);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError(string.Empty, "An error occurred while creating the Book");
            }
            return View(book);
        }
    }
}
