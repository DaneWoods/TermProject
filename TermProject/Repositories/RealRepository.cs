using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TermProject.Models;

namespace TermProject.Repositories 
{
    public class RealRepository : IRepository
    {
        public AppDbContext context;

        public List<Animal> AnimalList { get { return context.Animals.ToList(); } }
        public List<ForumPost> ForumList { get { return context.ForumPosts.Include(x => x.Responses).ToList(); } }

        public RealRepository(AppDbContext dbContext)
        {
            context = dbContext;
        }

        public void AddAnimal(Animal a)
        {
            context.Animals.Add(a);
            context.SaveChanges();
        }

        public void AddForumPost(ForumPost f)
        {
            context.ForumPosts.Add(f);
            context.SaveChanges();
        }

        public void AddForumPostResponse(string title, string response)
        {
            Response r = new Response();
            r.Comment = response;
            context.ForumPosts.First(x => x.Title == title).Responses.Add(r);
            context.SaveChanges();
        }

        public Animal GenerateQuestion()
        {
            Random rnd = new Random();
            int rndAnimal = rnd.Next(0, AnimalList.Count);
            return AnimalList[rndAnimal];
        }
    }
}
