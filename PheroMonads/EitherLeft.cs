using System;

namespace PheroMonads
{
    public sealed class EitherLeft<Tl, Tr> : EitherOperand<Tl>, IEither<Tl, Tr>
    {
        public EitherLeft(Tl value) : base(value) { }

        public void Case(Action left, Action right)
            => left();

        public void Case(Action left, Action<Tr> right)
            => left();

        public IMaybe<TU> Case<TU>(Action left, Func<TU> right)
        {
            left();
            return Maybe.None<TU>();
        }

        public IMaybe<TU> Case<TU>(Action left, Func<IMaybe<TU>> right)
        {
            left();
            return Maybe.None<TU>();
        }

        public IMaybe<TU> Case<TU>(Action left, Func<Tr, TU> right)
        {
            left();
            return Maybe.None<TU>();
        }

        public IMaybe<TU> Case<TU>(Action left, Func<Tr, IMaybe<TU>> right)
        {
            left();
            return Maybe.None<TU>();
        }

        public void Case(Action<Tl> left, Action right)
            => left(this.value);

        public void Case(Action<Tl> left, Action<Tr> right)
            => left(this.value);

        public IMaybe<TU> Case<TU>(Action<Tl> left, Func<TU> right)
        {
            left(this.value);
            return Maybe.None<TU>();
        }

        public IMaybe<TU> Case<TU>(Action<Tl> left, Func<IMaybe<TU>> right)
        {
            left(this.value);
            return Maybe.None<TU>();
        }

        public IMaybe<TU> Case<TU>(Action<Tl> left, Func<Tr, TU> right)
        {
            left(this.value);
            return Maybe.None<TU>();
        }

        public IMaybe<TU> Case<TU>(Action<Tl> left, Func<Tr, IMaybe<TU>> right)
        {
            left(this.value);
            return Maybe.None<TU>();
        }

        public IMaybe<TU> Case<TU>(Func<Tl, TU> left, Action right)
            => Maybe.Some(left(this.value));

        public IMaybe<TU> Case<TU>(Func<Tl, TU> left, Action<Tr> right)
            => Maybe.Some(left(this.value));

        public TU Case<TU>(Func<Tl, TU> left, Func<Tr, TU> right)
            => left(this.value);

        public IMaybe<TU> Case<TU>(Func<Tl, TU> left, Func<Tr, IMaybe<TU>> right)
            => Maybe.Some(left(this.value));

        public IEither<TUl, TUr> Case<TUl, TUr>(Func<Tl, TUl> left, Func<Tr, TUr> right)
            => Either.Create<TUl, TUr>(left(this.value));

        public IMaybe<TU> Case<TU>(Func<Tl, IMaybe<TU>> left, Action right)
            => Maybe.Some(left(this.value));

        public IMaybe<TU> Case<TU>(Func<Tl, IMaybe<TU>> left, Action<Tr> right)
            => Maybe.Some(left(this.value));

        public IMaybe<TU> Case<TU>(Func<Tl, IMaybe<TU>> left, Func<TU> right)
            => Maybe.Some(left(this.value));

        public IMaybe<TU> Case<TU>(Func<Tl, IMaybe<TU>> left, Func<Tr, TU> right)
            => Maybe.Some(left(this.value));

        public IMaybe<TU> Case<TU>(Func<Tl, IMaybe<TU>> left, Func<Tr, IMaybe<TU>> right)
            => Maybe.Some(left(this.value));

        public IMaybe<TU> Case<TU>(Func<TU> left, Action right)
            => Maybe.Some(left());

        public IMaybe<TU> Case<TU>(Func<TU> left, Action<Tr> right)
            => Maybe.Some(left());

        public TU Case<TU>(Func<TU> left, Func<Tr, TU> right)
            => left();

        public IMaybe<TU> Case<TU>(Func<TU> left, Func<Tr, IMaybe<TU>> right)
            => Maybe.Some(left());

        public IEither<TUl, TUr> Case<TUl, TUr>(Func<TUl> left, Func<Tr, TUr> right)
            => Either.Create<TUl, TUr>(left());

        public IMaybe<TU> Case<TU>(Func<IMaybe<TU>> left, Action right)
            => Maybe.Some(left());

        public IMaybe<TU> Case<TU>(Func<IMaybe<TU>> left, Action<Tr> right)
            => Maybe.Some(left());

        public IMaybe<TU> Case<TU>(Func<IMaybe<TU>> left, Func<TU> right)
            => Maybe.Some(left());

        public IMaybe<TU> Case<TU>(Func<IMaybe<TU>> left, Func<Tr, TU> right)
            => Maybe.Some(left());

        public IMaybe<TU> Case<TU>(Func<IMaybe<TU>> left, Func<Tr, IMaybe<TU>> right)
            => Maybe.Some(left());

        public IMaybe<Tr> Left(Action left)
        {
            left();
            return Maybe.None<Tr>();
        }

        public IMaybe<Tr> Left(Action<Tl> left)
        {
            left(this.value);
            return Maybe.None<Tr>();
        }

        public Tr Left(Func<Tr> left)
            => left();

        public Tr Left(Func<Tl, Tr> left)
            => left(this.value);

        public IEither<Tr, TU> Left<TU>(Func<TU> left)
            => Either.Create<Tr, TU>(left());

        public IEither<Tr, TU> Left<TU>(Func<Tl, TU> left)
            => Either.Create<Tr, TU>(left(this.value));

        public IEither<Tr, TU> Left<TU>(Func<IEither<Tr, TU>> left)
            => Either.Create<Tr, TU>(left());

        public IEither<Tr, TU> Left<TU>(Func<Tl, IEither<Tr, TU>> left)
            => Either.Create<Tr, TU>(left(this.value));

        public IMaybe<Tr> Left(Func<IMaybe<Tr>> left)
            => left();

        public IMaybe<Tr> Left(Func<Tl, IMaybe<Tr>> left)
            => left(this.value);

        public IMaybe<Tl> Right(Action right)
            => Maybe.None<Tl>();

        public IMaybe<Tl> Right(Action<Tr> right)
            => Maybe.None<Tl>();

        public Tl Right(Func<Tl> right)
            => this.value;

        public Tl Right(Func<Tr, Tl> right)
            => this.value;

        public IEither<Tl, TU> Right<TU>(Func<TU> right)
            => Either.Create<Tl, TU>(this.value);

        public IEither<Tl, TU> Right<TU>(Func<Tr, TU> right)
            => Either.Create<Tl, TU>(this.value);

        public IEither<Tl, TU> Right<TU>(Func<IEither<Tl, TU>> right)
            => Either.Create<Tl, TU>(this.value);

        public IEither<Tl, TU> Right<TU>(Func<Tr, IEither<Tl, TU>> right)
            => Either.Create<Tl, TU>(this.value);

        public IMaybe<Tl> Right(Func<IMaybe<Tl>> right)
            => Maybe.Some(this.value);

        public IMaybe<Tl> Right(Func<Tr, IMaybe<Tl>> right)
            => Maybe.Some(this.value);
    }
}
