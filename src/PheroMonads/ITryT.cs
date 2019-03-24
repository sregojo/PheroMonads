using System;
using System.Collections.Generic;
using System.Text;

namespace PheroMonads
{
    public interface ITry<T> : ITry
    {
        void Case(Action<T> success, Action failure);
        void Case(Action<T> success, Action<Exception> failure);

        IMaybe<U> Case<U>(Action<T> success, Func<U> failure);
        IMaybe<U> Case<U>(Action<T> success, Func<Exception, U> failure);
        IMaybe<U> Case<U>(Action<T> success, Func<Exception, IMaybe<U>> failure);

        IMaybe<U> Case<U>(Func<T, U> success, Action failure);
        IMaybe<U> Case<U>(Func<T, IMaybe<U>> success, Action failure);
        IMaybe<U> Case<U>(Func<T, U> success, Action<Exception> failure);
        IMaybe<U> Case<U>(Func<T, IMaybe<U>> success, Action<Exception> failure);

        U Case<U>(Func<T, U> success, Func<U> failure);
        IMaybe<U> Case<U>(Func<T, IMaybe<U>> success, Func<U> failure);
        IMaybe<U> Case<U>(Func<T, U> success, Func<IMaybe<U>> failure);
        IMaybe<U> Case<U>(Func<T, IMaybe<U>> success, Func<IMaybe<U>> failure);
        U Case<U>(Func<T, U> success, Func<Exception, U> failure);
        IMaybe<U> Case<U>(Func<T, IMaybe<U>> success, Func<Exception, U> failure);
        IMaybe<U> Case<U>(Func<T, U> success, Func<Exception, IMaybe<U>> failure);
        IMaybe<U> Case<U>(Func<T, IMaybe<U>> success, Func<Exception, IMaybe<U>> failure);

        IEither<Us, Uf> Case<Us, Uf>(Func<T, Us> success, Func<Uf> failure);
        IEither<Us, Uf> Case<Us, Uf>(Func<T, Us> success, Func<Exception, Uf> failure);

        void Success(Action<T> success);

        IMaybe<U> Success<U>(Func<T, U> success);
        IMaybe<U> Success<U>(Func<T, IMaybe<U>> success);
    }
}
