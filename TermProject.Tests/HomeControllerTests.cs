using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TermProject.Models;
using TermProject.Controllers;
using TermProject.Repositories;

namespace TermProject.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void AddAnimalTest()
        {
            // Arange
            var repo = new FakeRepository();
            var homeController = new HomeController(repo);
            // Act
            Animal a = new Animal();
            a.Class = "Bird";
            a.Name = "Hawk";
            a.Description = "Fast";
            a.Diet = "Carnivore";
            homeController.AnimalAdd(a);
            // Assert
            Assert.Equal(a, repo.AnimalList[0]);
        }

        [Fact]
        public void ForumPostTest()
        {
            // Arange
            var repo = new FakeRepository();
            var homeController = new HomeController(repo);
            // Act
            ForumPost f = new ForumPost { Title = "Wowie", Text = "Wowzers" };
            homeController.ForumPost(f);
            // Assert
            Assert.Equal(f.Title, repo.ForumList[0].Title);
            Assert.Equal(f.Text, repo.ForumList[0].Text);
        }

        [Fact]
        public void RespondTest()
        {
            // Arange
            var repo = new FakeRepository();
            var homeController = new HomeController(repo);
            // Act
            ForumPost f = new ForumPost { Title = "Wowie", Text = "Wowzers" };
            string com = "I dont like this post";
            homeController.ForumPost(f);
            homeController.Respond(com, f.Title);
            // Assert
            Assert.Equal(com, repo.ForumList[0].Responses[0].Comment);
        }
    }
}
