using System;

namespace PheroMonads
{
    public class TrySuccess : ITry
    {
        public void Case(Action success, Action failure)
            => success();

        public void Case(Action success, Action<Exception> failure)
            => success();

        public IMaybe<U> Case<U>(Action success, Func<U> failure)
        {
            success();
            return Maybe.None<U>();
        }

        public IMaybe<U> Case<U>(Action success, Func<Exception, U> failure)
        {
            success();
            return Maybe.None<U>();
        }

        public IMaybe<U> Case<U>(Action success, Func<Exception, IMaybe<U>> failure)
        {
            success();
            return Maybe.None<U>();
        }

        public IMaybe<U> Case<U>(Func<U> success, Action failure)
            => Maybe.Some(success());

        public IMaybe<U> Case<U>(Func<IMaybe<U>> success, Action failure)
            => Maybe.Some(success());

        public IMaybe<U> Case<U>(Func<U> success, Action<Exception> failure)
            => Maybe.Some(success());

        public IMaybe<U> Case<U>(Func<IMaybe<U>> success, Action<Exception> failure)
            => Maybe.Some(success());

        public U Case<U>(Func<U> success, Func<U> failure)
            => success();

        public IMaybe<U> Case<U>(Func<IMaybe<U>> success, Func<U> failure)
            => Maybe.Some(success());

        public IMaybe<U> Case<U>(Func<U> success, Func<IMaybe<U>> failure)
            => Maybe.Some(success());

        public IMaybe<U> Case<U>(Func<IMaybe<U>> success, Func<IMaybe<U>> failure)
            => Maybe.Some(success());

        public U Case<U>(Func<U> success, Func<Exception, U> failure)
            => success();

        public IMaybe<U> Case<U>(Func<IMaybe<U>> success, Func<Exception, U> failure)
            => Maybe.Some(success());

        public IMaybe<U> Case<U>(Func<U> success, Func<Exception, IMaybe<U>> failure)
            => Maybe.Some(success());

        public IMaybe<U> Case<U>(Func<IMaybe<U>> success, Func<Exception, IMaybe<U>> failure)
            => Maybe.Some(success());

        public IEither<Us, Uf> Case<Us, Uf>(Func<Us> success, Func<Uf> failure)
            => Either.Create<Us, Uf>(success());

        public IEither<Us, Uf> Case<Us, Uf>(Func<Us> success, Func<Exception, Uf> failure)
            => Either.Create<Us, Uf>(success());

        public void Failure(Action failure) { return; }

        public void Failure(Action<Exception> failure) { return; }

        public IMaybe<U> Failure<U>(Func<U> failure)
            => Maybe.None<U>();

        public IMaybe<U> Failure<U>(Func<IMaybe<U>> failure)
            => Maybe.None<U>();

        public IMaybe<U> Failure<U>(Func<Exception, U> failure)
            => Maybe.None<U>();

        public IMaybe<U> Failure<U>(Func<Exception, IMaybe<U>> failure)
            => Maybe.None<U>();

        public void Success(Action success)
            => success();

        public IMaybe<U> Success<U>(Func<U> success)
            => Maybe.Some(success());

        public IMaybe<U> Success<U>(Func<IMaybe<U>> success)
            => success();
    }
}
