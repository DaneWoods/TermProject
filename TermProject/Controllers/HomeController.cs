using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TermProject.Models;
using TermProject.Repositories;

namespace TermProject.Controllers
{
    public class HomeController : Controller
    {
        IRepository repo;

        public HomeController(IRepository r)
        {
            repo = r;
        }

        public IActionResult Index()
        {
            return View(repo.AnimalList);
        }

        [HttpGet]
        public IActionResult AnimalAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AnimalAdd(Animal a)
        {
            if (ModelState.IsValid)
            {
                repo.AddAnimal(a);
                return RedirectToAction("Index");
            }
            else
                return View("AnimalAdd");
        }

        public IActionResult Forum()
        {
            return View(repo.ForumList);
        }

        [HttpGet]
        public IActionResult ForumPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ForumPost(ForumPost f)
        {
            if (ModelState.IsValid)
            {
                repo.AddForumPost(f);
                return RedirectToAction("Forum");
            }
            else
                return View("ForumPost");
        }

        [HttpGet]
        public IActionResult Respond(string postTitle)
        {
            ViewBag.PostTitle = postTitle;
            return View("Respond", postTitle);
        }

        [HttpPost]
        public IActionResult Respond(string response, string postTitle)
        {
            ViewBag.PostTitle = postTitle;
            if (ModelState.IsValid)
            {
                repo.AddForumPostResponse(postTitle, response);
                return RedirectToAction("Forum");
            }
            else
                return View("Respond");
        }

        [HttpGet]
        public IActionResult Quiz()
        {
            Animal rndAnimal = repo.GenerateQuestion();
            ViewBag.AnimalName = rndAnimal.Name;
            ViewBag.RandomAnimalDesc = rndAnimal.Description;
            return View();
        }

        [HttpPost]
        public IActionResult Quiz(string playerAnswer, string quizAnswer)
        {
            ViewBag.TestResult = "";
            if(playerAnswer == quizAnswer)
                ViewBag.TestResult = "Correct!!";
            else
                ViewBag.TestResult = "Sorry, but that is incorrect.";
            return View("Quiz");
        }
    }
}
