﻿using Microsoft.EntityFrameworkCore;
using HistoricalNewsUpdate.Common.SeedWork.ExtendEntities;

namespace HistoricalNewsUpdate.Common.SeedWork
{
    public class PagingResultSP<T> : List<T>
    {
        public PagingSP Paging { get; set; }
        public IList<T> Data { get; set; }

        public PagingResultSP()
        {
        }

        public PagingResultSP(IList<T> data, int totalCount, int pageIndex, int pageSize)
        {
            Paging = new PagingSP(totalCount, pageIndex, pageSize);
            Data = data;
        }

        public static async Task<PagingResultSP<T>> CreateAsyncLinq(IQueryable<T> query, int totalRow, int pageIndex, int pageSize)
        {
            var items = await query.ToListAsync();

            return new PagingResultSP<T>(items, totalRow, pageIndex, pageSize);
        }
    }
}
