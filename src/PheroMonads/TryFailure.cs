using System;

namespace PheroMonads
{
    public class TryFailure : ITry
    {
        protected readonly Exception value;

        public TryFailure(Exception value) => this.value = value;

        public void Case(Action success, Action failure)
            => failure();

        public void Case(Action success, Action<Exception> failure)
            => failure(this.value);

        public IMaybe<U> Case<U>(Action success, Func<U> failure)
            => Maybe.Some(failure());

        public IMaybe<U> Case<U>(Action success, Func<Exception, U> failure)
            => Maybe.Some(failure(this.value));

        public IMaybe<U> Case<U>(Action success, Func<Exception, IMaybe<U>> failure)
            => Maybe.Some(failure(this.value));

        public IMaybe<U> Case<U>(Func<U> success, Action failure)
        {
            failure();
            return Maybe.None<U>();
        }

        public IMaybe<U> Case<U>(Func<IMaybe<U>> success, Action failure)
        {
            failure();
            return Maybe.None<U>();
        }

        public IMaybe<U> Case<U>(Func<U> success, Action<Exception> failure)
        {
            failure(this.value);
            return Maybe.None<U>();
        }

        public IMaybe<U> Case<U>(Func<IMaybe<U>> success, Action<Exception> failure)
        {
            failure(this.value);
            return Maybe.None<U>();
        }

        public U Case<U>(Func<U> success, Func<U> failure)
            => failure();

        public IMaybe<U> Case<U>(Func<IMaybe<U>> success, Func<U> failure)
            => Maybe.Some(failure());

        public IMaybe<U> Case<U>(Func<U> success, Func<IMaybe<U>> failure)
            => Maybe.Some(failure());

        public IMaybe<U> Case<U>(Func<IMaybe<U>> success, Func<IMaybe<U>> failure)
            => Maybe.Some(failure());

        public U Case<U>(Func<U> success, Func<Exception, U> failure)
            => failure(this.value);

        public IMaybe<U> Case<U>(Func<IMaybe<U>> success, Func<Exception, U> failure)
            => Maybe.Some(failure(this.value));

        public IMaybe<U> Case<U>(Func<U> success, Func<Exception, IMaybe<U>> failure)
            => Maybe.Some(failure(this.value));

        public IMaybe<U> Case<U>(Func<IMaybe<U>> success, Func<Exception, IMaybe<U>> failure)
            => Maybe.Some(failure(this.value));

        public IEither<Us, Uf> Case<Us, Uf>(Func<Us> success, Func<Uf> failure)
            => Either.Create<Us, Uf>(failure());

        public IEither<Us, Uf> Case<Us, Uf>(Func<Us> success, Func<Exception, Uf> failure)
            => Either.Create<Us, Uf>(failure(this.value));

        public void Failure(Action failure)
            => failure();

        public void Failure(Action<Exception> failure)
            => failure(this.value);

        public IMaybe<U> Failure<U>(Func<U> failure)
            => Maybe.Some(failure());

        public IMaybe<U> Failure<U>(Func<IMaybe<U>> failure)
            => Maybe.Some(failure());

        public IMaybe<U> Failure<U>(Func<Exception, U> failure)
            => Maybe.Some(failure(this.value));

        public IMaybe<U> Failure<U>(Func<Exception, IMaybe<U>> failure)
            => Maybe.Some(failure(this.value));

        public void Success(Action success) { return; }

        public IMaybe<U> Success<U>(Func<U> success)
            => Maybe.None<U>();

        public IMaybe<U> Success<U>(Func<IMaybe<U>> success)
            => Maybe.None<U>();
    }
}
