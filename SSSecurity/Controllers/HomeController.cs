using Microsoft.AspNetCore.Mvc;
using SSSecurity.Models;
using System.Text.Json;

namespace SSSecurity.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _environment;

        public HomeController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult Payment()
        {
            return View();
        }
        
        public IActionResult Success()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registration(User user)
        {
            if (ModelState.IsValid)
            {
                string _filePath = "records.json";

                List<User> users;

                if (System.IO.File.Exists(_filePath))
                {
                    string jsonData = System.IO.File.ReadAllText(_filePath);
                    if (!string.IsNullOrWhiteSpace(jsonData))
                    {
                        users = JsonSerializer.Deserialize<List<User>>(jsonData);
                    }
                    else
                    {
                        users = new List<User>();
                    }
                }
                else
                {
                    users = new List<User>();
                }

                user.Id = users.Any() ? users.Max(u => u.Id) + 1 : 1;
                users.Add(user);

                string serializedData = JsonSerializer.Serialize(users);

                // Write the serialized data back to the file
                System.IO.File.WriteAllText(_filePath, serializedData);
                ViewBag["email"] = user.Email;
                return RedirectToAction(nameof(Privacy));
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Upload(ContentViewModel model)
        {
            if (ModelState.IsValid)
            {
                //string uploadsFolder = Path.Combine(_environment.WebRootPath, "uploads");

                //SaveImage(model.AadharCard, uploadsFolder);
                //SaveImage(model.PanCard, uploadsFolder);
                //SaveImage(model.Doc1, uploadsFolder);
                //SaveImage(model.Doc2, uploadsFolder);

                return RedirectToAction(nameof(Payment));
            }

            return BadRequest();
        }

        private void SaveImage(IFormFile imageFile, string uploadsFolder)
        {
            if (imageFile != null && imageFile.Length > 0)
            {
                string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    imageFile.CopyTo(fileStream);
                }
            }
        }

        public IActionResult UploadSuccess()
        {
            return View();
        }
    }
}
