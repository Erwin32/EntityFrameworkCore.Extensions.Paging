using System;
using System.Linq;

namespace EntityFrameworkCore.Extensions.Paging
{
    public static class IQueryableExtensions
    {
        /// <summary>
        /// Gets a PagedResult<T> from IQueryable<T>. Has to used last similar to Single() or ToList()
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static PagedResult<T> GetPaged<T>(this IQueryable<T> query,
            int pageIndex, int pageSize = 50) where T : class
        {
            var result = new PagedResult<T>
            {
                CurrentPage = pageIndex,
                PageSize = pageSize,
                RowCount = query.Count()
            };


            var pageCount = (double)result.RowCount / pageSize;
            result.PageCount = (int)Math.Ceiling(pageCount);

            var skip = (pageIndex - 1) * pageSize;
            result.Results = query.Skip(skip).Take(pageSize).ToList();

            return result;
        }

    }
}