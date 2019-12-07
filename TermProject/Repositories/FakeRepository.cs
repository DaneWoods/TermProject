using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TermProject.Models;

namespace TermProject.Repositories
{
    public class FakeRepository : IRepository
    {
        public static List<ForumPost> ForumPosts = new List<ForumPost>();
        public static List<Animal> Animals = new List<Animal>();

        public List<Animal> AnimalList { get { return Animals; } }

        public List<ForumPost> ForumList { get { return ForumPosts; } }

        public void AddAnimal(Animal a)
        {
            Animals.Add(a);
        }

        public void AddForumPost(ForumPost f)
        {
            ForumPosts.Add(f);
        }

        public void AddForumPostResponse(string title, string response)
        {
            Response r = new Response();
            r.Comment = response;
            ForumPosts.Find(x => x.Title == title).resp.Add(r);
        }

        public Animal GenerateQuestion()
        {
            Random rnd = new Random();
            int rndAnimal = rnd.Next(0, Animals.Count);
            return Animals[rndAnimal];
        }

        public void AddInitialData()
        {
            Animal a1 = new Animal { Class = "Mammal", Name = "Chimpanzee", Description = "Very human like", Diet = "Omnivore" };
            Animal a2 = new Animal { Class = "Bird", Name = "Blue Jay", Description = "Hop around", Diet = "Omnivore" };
            Animal a3 = new Animal { Class = "Fish", Name = "Gold Fish", Description = "Small household fish", Diet = "Omnivore" };
            Animal a4 = new Animal { Class = "Reptile", Name = "Bearded Dragon", Description = "Dessert Lizards", Diet = "Omnivore" };
            Animal a5 = new Animal { Class = "Amphibian", Name = "Toad", Description = "Very Chubby", Diet = "Omnivore" };
            Animal a6 = new Animal { Class = "Arthropod", Name = "Trapdoor spider", Description = "Very sneaky", Diet = "Carnivore" };
            Animals.Add(a6);
            Animals.Add(a6);
            Animals.Add(a6);
            Animals.Add(a6);
            Animals.Add(a6);
            Animals.Add(a6);
            ForumPost f1 = new ForumPost { Title = "Spiders scare me", Text = "They are all around my house." };
            ForumPost f2 = new ForumPost { Title = "I love dogs", Text = "I've grown up around dogs." };
            ForumPosts.Add(f1);
            ForumPosts.Add(f2);
        }
    }
}
