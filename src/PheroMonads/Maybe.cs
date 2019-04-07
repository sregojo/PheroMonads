using System;

namespace PheroMonads
{
    public static class Maybe
    {
        public static IMaybe<T> None<T>() => new MaybeNone<T>();

        public static IMaybe<T> None<T>(Action action) => new MaybeNone<T>(action);

        public static IMaybe<T> Some<T>(T someValue) => new MaybeSome<T>(someValue);

        public static IMaybe<T> Some<T>(IMaybe<T> value) => value;
    }
}
