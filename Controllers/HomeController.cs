using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PersonalPortfolio.Models;

namespace PersonalPortfolio.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var viewModel = new HomeViewModel
        {
            Projects = GetProjects()
            .Where(project => project.IsFeatured)
            .ToList(),
            
            Skills = GetSkills()
        };

        return View(viewModel);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    private List<Project> GetProjects()
    {
        return new List<Project>{
            new()
            {
                Id = 1,
                Title = "Personal Portfolio",
                Description = "A personal portfolio website to showcase my projects, skills, and professional experience.",
                TechStack = "C#, ASP.NET Core, Razor, Bootstrap",
                GitHubUrl = "https://github.com/",
                LiveUrl = "https://example.com",
                ImageUrl = "https://placehold.co/600x400/212529/FFFFFF?text=Personal+Portfolio",
                CompletedDate = new DateTime(2026, 10, 1),
                IsFeatured = true
            },
            new()
            {
                Id = 2,
                Title = "Blog REST API",
                Description = "A RESTful API for managing blog posts, comments, and users, featuring authentication and authorization.",
                TechStack = "C#, ASP.NET Core, Entity Framework Core, SQLite",
                GitHubUrl = "https://github.com/",
                LiveUrl = "",
                ImageUrl = "https://placehold.co/600x400/0D6EFD/FFFFFF?text=Blog+REST+API",
                CompletedDate = new DateTime(2026, 9, 15),
                IsFeatured = true
            },
            new()
            {
                Id = 3,
                Title = "Task Management API",
                Description = "An API for organizing tasks, tracking progress, and managing task priorities with CRUD operations.",
                TechStack = "TypeScript, Deno, MongoDB, REST API",
                GitHubUrl = "https://github.com/",
                LiveUrl = "",
                ImageUrl = "https://placehold.co/600x400/198754/FFFFFF?text=Task+Management",
                CompletedDate = new DateTime(2026, 8, 20),
                IsFeatured = true
            },
            new()
            {
                Id = 4,
                Title = "Weather Dashboard",
                Description = "A responsive dashboard that displays weather conditions and forecasts using an external weather API.",
                TechStack = "C#, ASP.NET Core, JavaScript, REST API",
                GitHubUrl = "https://github.com/",
                LiveUrl = "https://example.com",
                ImageUrl = "https://placehold.co/600x400/0DCAF0/212529?text=Weather+Dashboard",
                CompletedDate = new DateTime(2026, 7, 10),
                IsFeatured = true
            },
            new()
            {
                Id = 5,
                Title = "E-Commerce Platform",
                Description = "An e-commerce application with product listings, shopping cart functionality, and order management.",
                TechStack = "C#, ASP.NET Core MVC, Entity Framework Core, SQL Server",
                GitHubUrl = "https://github.com/",
                LiveUrl = "",
                ImageUrl = "https://placehold.co/600x400/6F42C1/FFFFFF?text=E-Commerce",
                CompletedDate = new DateTime(2026, 6, 5),
                IsFeatured = true
            },
            new()
            {
                Id = 6,
                Title = "Developer Task Tracker",
                Description = "A productivity application for tracking development tasks, deadlines, and project progress.",
                TechStack = "C#, ASP.NET Core, Blazor, SQLite",
                GitHubUrl = "https://github.com/",
                LiveUrl = "",
                ImageUrl = "https://placehold.co/600x400/FD7E14/FFFFFF?text=Task+Tracker",
                CompletedDate = new DateTime(2026, 5, 12),
                IsFeatured = true
            }
};
    }

    private List<Skill> GetSkills()
    {
        return new List<Skill>
        {
            new()
            {
                Name = "Linux",
                Category =  "Operational System",
                ProficiencyLevel = 3
            },
            new()
            {
                Name = "C#",
                Category = "Web Development",
                ProficiencyLevel = 2
            },
            new()
            {
                Name = "Javascript",
                Category = "Web Development",
                ProficiencyLevel = 4
            },
            new()
            {
                Name = "SQL Server",
                Category = "Database",
                ProficiencyLevel = 5
            }
        };
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
