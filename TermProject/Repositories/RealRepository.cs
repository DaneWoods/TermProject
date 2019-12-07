using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TermProject.Models;

namespace TermProject.Repositories
{
    public class RealRepository
    {
        public static List<ForumPost> ForumPosts = new List<ForumPost>();
        public static List<Animal> Animals = new List<Animal>();

        public static List<Animal> AnimalList
        {
            get
            {
                return Animals;
            }
        }

        public static List<ForumPost> ForumList
        {
            get
            {
                return ForumPosts;
            }
        }

        public static void AddAnimal(Animal a)
        {
            Animals.Add(a);
        }

        public static void AddForumPost(ForumPost f)
        {
            ForumPosts.Add(f);
        }

        public static void AddForumPostResponse(string title, string response)
        {
            Response r = new Response();
            r.Comment = response;
            ForumPosts.Find(x => x.Title == title).resp.Add(r);
        }

        public static Animal GenerateQuestion()
        {
            Random rnd = new Random();
            int rndAnimal = rnd.Next(0, Animals.Count);
            return Animals[rndAnimal];
        }
    }
}
