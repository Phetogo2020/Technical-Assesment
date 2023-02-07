﻿using System;
using System.Linq;

namespace SimpleApp.Service.Interface
{
    public interface IRepository
    {
        IQueryable<T> All<T>() where T : class;

        IQueryable<T> All<T>(params System.Linq.Expressions.Expression<Func<T, object>>[] includeProperties) where T : class;

        T Find<T>(int id) where T : class;

        IQueryable<T> Search<T>(System.Linq.Expressions.Expression<Func<T, bool>> predicate, params System.Linq.Expressions.Expression<Func<T, object>>[] includeProperties) where T : class;

        int Count<T>(System.Linq.Expressions.Expression<Func<T, bool>> predicate) where T : class;

        T AddEntity<T>(T entity) where T : class;

        T UpdateEntity<T>(T entity) where T : class;

        void DeleteEntity<T>(T entity) where T : class;

        void Save();

        void Detach<T>(T source) where T : class;

        void Dispose();

        IQueryable<T> CloneEntity<T>(System.Linq.Expressions.Expression<Func<T, bool>> predicate, params System.Linq.Expressions.Expression<Func<T, object>>[] includeProperties) where T : class;

    }
}
