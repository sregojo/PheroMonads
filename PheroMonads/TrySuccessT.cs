using System;

namespace PheroMonads
{
    public sealed class TrySuccess<T> : TrySuccess, ITry<T>
    {
        private readonly T value;

        public TrySuccess(T value) => this.value = value;

        public void Case(Action<T> success, Action failure)
            => success(this.value);

        public void Case(Action<T> success, Action<Exception> failure)
            => success(this.value);

        public IMaybe<U> Case<U>(Action<T> success, Func<U> failure)
        {
            success(this.value);
            return Maybe.None<U>();
        }

        public IMaybe<U> Case<U>(Action<T> success, Func<Exception, U> failure)
        {
            success(this.value);
            return Maybe.None<U>();
        }

        public IMaybe<U> Case<U>(Action<T> success, Func<Exception, IMaybe<U>> failure)
        {
            success(this.value);
            return Maybe.None<U>();
        }

        public IMaybe<U> Case<U>(Func<T, U> success, Action failure)
            => Maybe.Some(success(this.value));

        public IMaybe<U> Case<U>(Func<T, IMaybe<U>> success, Action failure)
            => success(this.value);

        public IMaybe<U> Case<U>(Func<T, U> success, Action<Exception> failure)
            => Maybe.Some(success(this.value));

        public IMaybe<U> Case<U>(Func<T, IMaybe<U>> success, Action<Exception> failure)
            => success(this.value);

        public U Case<U>(Func<T, U> success, Func<U> failure)
            => success(this.value);

        public IMaybe<U> Case<U>(Func<T, IMaybe<U>> success, Func<U> failure)
            => success(this.value);

        public IMaybe<U> Case<U>(Func<T, U> success, Func<IMaybe<U>> failure)
            => Maybe.Some(success(this.value));

        public IMaybe<U> Case<U>(Func<T, IMaybe<U>> success, Func<IMaybe<U>> failure)
            => success(this.value);

        public U Case<U>(Func<T, U> success, Func<Exception, U> failure)
            => success(this.value);

        public IMaybe<U> Case<U>(Func<T, IMaybe<U>> success, Func<Exception, U> failure)
            => success(this.value);

        public IMaybe<U> Case<U>(Func<T, U> success, Func<Exception, IMaybe<U>> failure)
            => Maybe.Some(success(this.value));

        public IMaybe<U> Case<U>(Func<T, IMaybe<U>> success, Func<Exception, IMaybe<U>> failure)
            => success(this.value);

        public IEither<Us, Uf> Case<Us, Uf>(Func<T, Us> success, Func<Uf> failure)
            => Either.Create<Us, Uf>(success(this.value));

        public IEither<Us, Uf> Case<Us, Uf>(Func<T, Us> success, Func<Exception, Uf> failure)
            => Either.Create<Us, Uf>(success(this.value));

        public void Success(Action<T> success)
            => success(this.value);

        public IMaybe<U> Success<U>(Func<T, U> success)
            => Maybe.Some(success(this.value));

        public IMaybe<U> Success<U>(Func<T, IMaybe<U>> success)
            => success(this.value);
    }
}
