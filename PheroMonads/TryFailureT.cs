using System;

namespace PheroMonads
{
    public sealed class TryFailure<T> : TryFailure, ITry<T>
    {
        public TryFailure(Exception ex) : base(ex) { }

        public void Case(Action<T> success, Action failure)
            => failure();

        public void Case(Action<T> success, Action<Exception> failure)
            => failure(this.value);

        public IMaybe<U> Case<U>(Action<T> success, Func<U> failure)
            => Maybe.Some(failure());

        public IMaybe<U> Case<U>(Action<T> success, Func<Exception, U> failure)
            => Maybe.Some(failure(this.value));

        public IMaybe<U> Case<U>(Action<T> success, Func<Exception, IMaybe<U>> failure)
            => Maybe.Some(failure(this.value));

        public IMaybe<U> Case<U>(Func<T, U> success, Action failure)
        {
            failure();
            return Maybe.None<U>();
        }

        public IMaybe<U> Case<U>(Func<T, IMaybe<U>> success, Action failure)
        {
            failure();
            return Maybe.None<U>();
        }

        public IMaybe<U> Case<U>(Func<T, U> success, Action<Exception> failure)
        {
            failure(this.value);
            return Maybe.None<U>();
        }

        public IMaybe<U> Case<U>(Func<T, IMaybe<U>> success, Action<Exception> failure)
        {
            failure(this.value);
            return Maybe.None<U>();
        }

        public U Case<U>(Func<T, U> success, Func<U> failure)
            => failure();

        public IMaybe<U> Case<U>(Func<T, IMaybe<U>> success, Func<U> failure)
            => Maybe.Some(failure());

        public IMaybe<U> Case<U>(Func<T, U> success, Func<IMaybe<U>> failure)
            => Maybe.Some(failure());

        public IMaybe<U> Case<U>(Func<T, IMaybe<U>> success, Func<IMaybe<U>> failure)
            => Maybe.Some(failure());

        public U Case<U>(Func<T, U> success, Func<Exception, U> failure)
            => failure(this.value);

        public IMaybe<U> Case<U>(Func<T, IMaybe<U>> success, Func<Exception, U> failure)
            => Maybe.Some(failure(this.value));

        public IMaybe<U> Case<U>(Func<T, U> success, Func<Exception, IMaybe<U>> failure)
            => Maybe.Some(failure(this.value));

        public IMaybe<U> Case<U>(Func<T, IMaybe<U>> success, Func<Exception, IMaybe<U>> failure)
            => Maybe.Some(failure(this.value));

        public IEither<Us, Uf> Case<Us, Uf>(Func<T, Us> success, Func<Uf> failure)
            => Either.Create<Us, Uf>(failure());

        public IEither<Us, Uf> Case<Us, Uf>(Func<T, Us> success, Func<Exception, Uf> failure)
            => Either.Create<Us, Uf>(failure(this.value));

        public void Success(Action<T> success) { return; }

        public IMaybe<U> Success<U>(Func<T, U> success)
            => Maybe.None<U>();

        public IMaybe<U> Success<U>(Func<T, IMaybe<U>> success)
            => Maybe.None<U>();
    }
}
