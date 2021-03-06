﻿using AdBoardAPI.Models;
using System.Linq;

namespace AdBoardAPI.Pagination.Sorter
{
    public interface ISorter<T> where T : class, IModel
    {
        public IQueryable<T> Sort();
    }
}
