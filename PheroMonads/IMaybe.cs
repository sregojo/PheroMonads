using System;

namespace PheroMonads
{
    public interface IMaybe<T>
    {
        void Case(Action some, Action none);

        IMaybe<U> Case<U>(Action some, Func<U> none);


        void Case(Action<T> some, Action none);

        IMaybe<U> Case<U>(Action<T> some, Func<U> none);


        IMaybe<U> Case<U>(Func<U> some, Action none);

        IMaybe<U> Case<U>(Func<T, U> some, Action none);


        U Case<U>(Func<U> some, Func<U> none);

        U Case<U>(Func<T, U> some, Func<U> none);


        IEither<Us, Un> Case<Us, Un>(Func<Us> some, Func<Un> none);


        IMaybe<U> Case<U>(Func<U> some, Func<IMaybe<U>> none);

        IMaybe<U> Case<U>(Func<IMaybe<U>> some, Func<U> none);

        IMaybe<U> Case<U>(Func<IMaybe<U>> some, Func<IMaybe<U>> none);


        void Some(Action some);

        void Some(Action<T> some);

        IMaybe<U> Some<U>(Func<U> some);

        IMaybe<U> Some<U>(Func<T, U> some);

        IMaybe<T> Some(Func<IMaybe<T>> some);

        IMaybe<T> Some(Func<T, IMaybe<T>> some);


        void None(Action none);

        IMaybe<U> None<U>(Func<U> none);

        IMaybe<T> None(Func<IMaybe<T>> none);
    }
}
