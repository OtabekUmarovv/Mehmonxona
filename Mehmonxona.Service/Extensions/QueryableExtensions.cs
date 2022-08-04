using System;
using System.Collections.Generic;
using System.Linq;

namespace Mehmonxona.Service.Extensions
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> GetWithPagination<T>
            (this IQueryable<T> source, Tuple<int, int>? pagination)
        {
            if (pagination is null)
                return source;

            return source.Skip((pagination.Item1 - 1) * pagination.Item2).Take(pagination.Item2);
        }
    }
}
