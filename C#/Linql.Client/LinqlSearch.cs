﻿using Linql.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Linql.Client
{
    public class LinqlSearch<T> : LinqlSearch, IQueryable<T>
    {
        public LinqlSearch() : base(typeof(T))
        {
            this.Provider = new LinqlContext();
            Expression = Expression.Constant(this);
        }

        public LinqlSearch(ALinqlContext Provider) : base(typeof(T))
        {
            if (Provider == null)
            {
                throw new Exception("Provider cannot be null");
            }
            this.Provider = Provider;
            Expression = Expression.Constant(this);
        }


        public LinqlSearch(ALinqlContext Provider, Expression Expression) : this(Provider)
        {
            if (Expression == null)
            {
                throw new Exception("Expression cannot be null");
            }
            this.Expression = Expression;
        }

        public Type ElementType
        {
            get { return typeof(T); }
        }

        public Expression Expression { get; private set; }

        public IQueryProvider Provider { get; private set; }

        public IEnumerator<T> GetEnumerator()
        {
            ALinqlContext provider = this.Provider as ALinqlContext;
            IEnumerable<T> result = provider.SendRequest<IEnumerable<T>>(this);
            return result.GetEnumerator();


        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new EnumerationIsNotSupportedException();
        }

    }
}
