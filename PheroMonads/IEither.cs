using System;

namespace PheroMonads
{
    public interface IEither<Tl, Tr>
    {
        void Case(Action left, Action right);

        void Case(Action left, Action<Tr> right);

        IMaybe<TU> Case<TU>(Action left, Func<TU> right);

        IMaybe<TU> Case<TU>(Action left, Func<IMaybe<TU>> right);

        IMaybe<TU> Case<TU>(Action left, Func<Tr, TU> right);

        IMaybe<TU> Case<TU>(Action left, Func<Tr, IMaybe<TU>> right);


        void Case(Action<Tl> left, Action right);

        void Case(Action<Tl> left, Action<Tr> right);

        IMaybe<TU> Case<TU>(Action<Tl> left, Func<TU> right);

        IMaybe<TU> Case<TU>(Action<Tl> left, Func<IMaybe<TU>> right);

        IMaybe<TU> Case<TU>(Action<Tl> left, Func<Tr, TU> right);

        IMaybe<TU> Case<TU>(Action<Tl> left, Func<Tr, IMaybe<TU>> right);


        IMaybe<TU> Case<TU>(Func<TU> left, Action right);

        IMaybe<TU> Case<TU>(Func<TU> left, Action<Tr> right);

        TU Case<TU>(Func<TU> left, Func<Tr, TU> right);

        IMaybe<TU> Case<TU>(Func<TU> left, Func<Tr, IMaybe<TU>> right);

        IEither<TUl, TUr> Case<TUl, TUr>(Func<TUl> left, Func<Tr, TUr> right);


        IMaybe<TU> Case<TU>(Func<Tl, TU> left, Action right);

        IMaybe<TU> Case<TU>(Func<Tl, TU> left, Action<Tr> right);

        TU Case<TU>(Func<Tl, TU> left, Func<Tr, TU> right);

        IMaybe<TU> Case<TU>(Func<Tl, TU> left, Func<Tr, IMaybe<TU>> right);

        IEither<TUl, TUr> Case<TUl, TUr>(Func<Tl, TUl> left, Func<Tr, TUr> right);


        IMaybe<TU> Case<TU>(Func<IMaybe<TU>> left, Action right);

        IMaybe<TU> Case<TU>(Func<IMaybe<TU>> left, Action<Tr> right);

        IMaybe<TU> Case<TU>(Func<IMaybe<TU>> left, Func<TU> right);

        IMaybe<TU> Case<TU>(Func<IMaybe<TU>> left, Func<Tr, TU> right);

        IMaybe<TU> Case<TU>(Func<IMaybe<TU>> left, Func<Tr, IMaybe<TU>> right);


        IMaybe<TU> Case<TU>(Func<Tl, IMaybe<TU>> left, Action right);

        IMaybe<TU> Case<TU>(Func<Tl, IMaybe<TU>> left, Action<Tr> right);

        IMaybe<TU> Case<TU>(Func<Tl, IMaybe<TU>> left, Func<TU> right);

        IMaybe<TU> Case<TU>(Func<Tl, IMaybe<TU>> left, Func<Tr, TU> right);

        IMaybe<TU> Case<TU>(Func<Tl, IMaybe<TU>> left, Func<Tr, IMaybe<TU>> right);


        IMaybe<Tr> Left(Action left);

        IMaybe<Tr> Left(Action<Tl> left);

        Tr Left(Func<Tr> left);

        IMaybe<Tr> Left(Func<IMaybe<Tr>> left);

        Tr Left(Func<Tl, Tr> left);

        IMaybe<Tr> Left(Func<Tl, IMaybe<Tr>> left);

        IEither<Tr, TU> Left<TU>(Func<TU> left);

        IEither<Tr, TU> Left<TU>(Func<Tl, TU> left);

        IEither<Tr, TU> Left<TU>(Func<IEither<Tr, TU>> left);

        IEither<Tr, TU> Left<TU>(Func<Tl, IEither<Tr, TU>> left);


        IMaybe<Tl> Right(Action right);

        IMaybe<Tl> Right(Action<Tr> right);

        Tl Right(Func<Tl> right);

        IMaybe<Tl> Right(Func<IMaybe<Tl>> right);

        Tl Right(Func<Tr, Tl> right);

        IMaybe<Tl> Right(Func<Tr, IMaybe<Tl>> right);

        IEither<Tl, TU> Right<TU>(Func<TU> right);

        IEither<Tl, TU> Right<TU>(Func<Tr, TU> right);

        IEither<Tl, TU> Right<TU>(Func<IEither<Tl, TU>> right);

        IEither<Tl, TU> Right<TU>(Func<Tr, IEither<Tl, TU>> right);
    }
}
