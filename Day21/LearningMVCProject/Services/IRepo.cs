﻿using LearningMVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningMVCProject.Services
{
    public interface IRepo<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Add(T t);
        void Update(int id, T t);
        void Delete(T t);
    }
}
