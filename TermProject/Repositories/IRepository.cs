﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TermProject.Models;

namespace TermProject.Repositories
{
    public interface IRepository
    {
        List<Animal> AnimalList { get; }
        List<ForumPost> ForumList { get; }
        void AddAnimal(Animal a);
        void AddForumPost(ForumPost f);
        void AddForumPostResponse(string title, string response);
        Animal GenerateQuestion();
    }
}
