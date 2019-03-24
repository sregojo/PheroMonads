using System;

namespace PheroMonads
{
    public sealed class MaybeNone<T> : IMaybe<T>
    {
        public void Case(Action some, Action none)
            => none();

        public IMaybe<U> Case<U>(Action some, Func<U> none)
            => Maybe.Some(none());

        public void Case(Action<T> some, Action none)
            => none();

        public IMaybe<U> Case<U>(Action<T> some, Func<U> none)
            => Maybe.Some(none());

        public IMaybe<U> Case<U>(Func<U> some, Action none)
        {
            none();
            return Maybe.None<U>();
        }

        public IMaybe<U> Case<U>(Func<T, U> some, Action none)
        {
            none();
            return Maybe.None<U>();
        }

        public U Case<U>(Func<U> some, Func<U> none)
            => none();

        public U Case<U>(Func<T, U> some, Func<U> none)
            => none();

        public IEither<Us, Un> Case<Us, Un>(Func<Us> some, Func<Un> none)
            => Either.Create<Us, Un>(none());

        public IMaybe<U> Case<U>(Func<U> some, Func<IMaybe<U>> none)
            => none();

        public IMaybe<U> Case<U>(Func<IMaybe<U>> some, Func<U> none)
            => Maybe.Some(none());

        public IMaybe<U> Case<U>(Func<IMaybe<U>> some, Func<IMaybe<U>> none)
            => none();

        public void None(Action none)
            => none();

        public IMaybe<U> None<U>(Func<U> none)
            => Maybe.Some(none());

        public IMaybe<T> None(Func<IMaybe<T>> none)
            => none();

        public void Some(Action some) { return; }

        public void Some(Action<T> some) { return; }

        public IMaybe<U> Some<U>(Func<U> some)
            => Maybe.None<U>();

        public IMaybe<U> Some<U>(Func<T, U> some)
            => Maybe.None<U>();

        public IMaybe<T> Some(Func<IMaybe<T>> some)
            => Maybe.None<T>();

        public IMaybe<T> Some(Func<T, IMaybe<T>> some)
            => Maybe.None<T>();
    }
}
