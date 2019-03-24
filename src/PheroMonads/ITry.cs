using System;
using System.Collections.Generic;
using System.Text;

namespace PheroMonads
{
    public interface ITry
    {
        void Case(Action success, Action failure);
        void Case(Action success, Action<Exception> failure);

        IMaybe<U> Case<U>(Action success, Func<U> failure);
        IMaybe<U> Case<U>(Action success, Func<Exception, U> failure);
        IMaybe<U> Case<U>(Action success, Func<Exception, IMaybe<U>> failure);

        IMaybe<U> Case<U>(Func<U> success, Action failure);
        IMaybe<U> Case<U>(Func<IMaybe<U>> success, Action failure);
        IMaybe<U> Case<U>(Func<U> success, Action<Exception> failure);
        IMaybe<U> Case<U>(Func<IMaybe<U>> success, Action<Exception> failure);

        U Case<U>(Func<U> success, Func<U> failure);
        IMaybe<U> Case<U>(Func<IMaybe<U>> success, Func<U> failure);
        IMaybe<U> Case<U>(Func<U> success, Func<IMaybe<U>> failure);
        IMaybe<U> Case<U>(Func<IMaybe<U>> success, Func<IMaybe<U>> failure);
        U Case<U>(Func<U> success, Func<Exception, U> failure);
        IMaybe<U> Case<U>(Func<IMaybe<U>> success, Func<Exception, U> failure);
        IMaybe<U> Case<U>(Func<U> success, Func<Exception, IMaybe<U>> failure);
        IMaybe<U> Case<U>(Func<IMaybe<U>> success, Func<Exception, IMaybe<U>> failure);

        IEither<Us, Uf> Case<Us, Uf>(Func<Us> success, Func<Uf> failure);
        IEither<Us, Uf> Case<Us, Uf>(Func<Us> success, Func<Exception, Uf> failure);

        void Success(Action success);

        IMaybe<U> Success<U>(Func<U> success);
        IMaybe<U> Success<U>(Func<IMaybe<U>> success);

        void Failure(Action failure);
        void Failure(Action<Exception> failure);

        IMaybe<U> Failure<U>(Func<U> failure);
        IMaybe<U> Failure<U>(Func<IMaybe<U>> failure);
        IMaybe<U> Failure<U>(Func<Exception, U> failure);
        IMaybe<U> Failure<U>(Func<Exception, IMaybe<U>> failure);
    }
}
