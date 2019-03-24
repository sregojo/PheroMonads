using System;

namespace PheroMonads
{
    public sealed class MaybeSome<T> : IMaybe<T>
    {
        private readonly T value;

        public MaybeSome(T value) => this.value = value;

        public void Case(Action some, Action none)
            => some();

        public IMaybe<U> Case<U>(Action some, Func<U> none)
        {
            some();
            return Maybe.None<U>();
        }

        public void Case(Action<T> some, Action none)
            => some(this.value);

        public IMaybe<U> Case<U>(Action<T> some, Func<U> none)
        {
            some(this.value);
            return Maybe.None<U>();
        }

        public IMaybe<U> Case<U>(Func<U> some, Action none)
            => Maybe.Some(some());

        public IMaybe<U> Case<U>(Func<T, U> some, Action none)
            => Maybe.Some(some(this.value));

        public U Case<U>(Func<U> some, Func<U> none)
            => some();

        public U Case<U>(Func<T, U> some, Func<U> none)
            => some(this.value);

        public IEither<Us, Un> Case<Us, Un>(Func<Us> some, Func<Un> none)
            => Either.Create<Us, Un>(some());

        public IMaybe<U> Case<U>(Func<U> some, Func<IMaybe<U>> none)
            => Maybe.Some(some());

        public IMaybe<U> Case<U>(Func<IMaybe<U>> some, Func<U> none)
            => some();

        public IMaybe<U> Case<U>(Func<IMaybe<U>> some, Func<IMaybe<U>> none)
            => some();

        public void None(Action none) { return; }

        public IMaybe<U> None<U>(Func<U> none)
            => Maybe.None<U>();

        public IMaybe<T> None(Func<IMaybe<T>> none)
            => Maybe.None<T>();

        public void Some(Action some)
            => some();

        public void Some(Action<T> some)
            => some(this.value);

        public IMaybe<U> Some<U>(Func<U> some)
            => Maybe.Some(some());

        public IMaybe<U> Some<U>(Func<T, U> some)
            => Maybe.Some(some(this.value));

        public IMaybe<T> Some(Func<IMaybe<T>> some)
            => some();

        public IMaybe<T> Some(Func<T, IMaybe<T>> some)
            => some(this.value);
    }
}
