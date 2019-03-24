using System;

namespace PheroMonads
{
    public sealed class EitherRight<Tl, Tr> : EitherOperand<Tr>, IEither<Tl, Tr>
    {
        public EitherRight(Tr value) : base(value) { }

        public void Case(Action left, Action right)
            => right();

        public void Case(Action left, Action<Tr> right)
            => right(this.value);

        public IMaybe<TU> Case<TU>(Action left, Func<TU> right)
            => Maybe.Some(right());

        public IMaybe<TU> Case<TU>(Action left, Func<IMaybe<TU>> right)
            => Maybe.Some(right());

        public IMaybe<TU> Case<TU>(Action left, Func<Tr, TU> right)
            => Maybe.Some(right(this.value));

        public IMaybe<TU> Case<TU>(Action left, Func<Tr, IMaybe<TU>> right)
            => Maybe.Some(right(this.value));

        public void Case(Action<Tl> left, Action right)
            => right();

        public void Case(Action<Tl> left, Action<Tr> right)
            => right(this.value);

        public IMaybe<TU> Case<TU>(Action<Tl> left, Func<TU> right)
            => Maybe.Some(right());

        public IMaybe<TU> Case<TU>(Action<Tl> left, Func<IMaybe<TU>> right)
            => Maybe.Some(right());

        public IMaybe<TU> Case<TU>(Action<Tl> left, Func<Tr, TU> right)
            => Maybe.Some(right(this.value));

        public IMaybe<TU> Case<TU>(Action<Tl> left, Func<Tr, IMaybe<TU>> right)
            => Maybe.Some(right(this.value));

        public IMaybe<TU> Case<TU>(Func<TU> left, Action right)
        {
            right();
            return Maybe.None<TU>();
        }

        public IMaybe<TU> Case<TU>(Func<TU> left, Action<Tr> right)
        {
            right(this.value);
            return Maybe.None<TU>();
        }

        public TU Case<TU>(Func<TU> left, Func<Tr, TU> right)
            => right(this.value);

        public IMaybe<TU> Case<TU>(Func<TU> left, Func<Tr, IMaybe<TU>> right)
            => Maybe.Some(right(this.value));

        public IEither<TUl, TUr> Case<TUl, TUr>(Func<TUl> left, Func<Tr, TUr> right)
            => Either.Create<TUl, TUr>(right(this.value));

        public IMaybe<TU> Case<TU>(Func<Tl, TU> left, Action right)
        {
            right();
            return Maybe.None<TU>();
        }

        public IMaybe<TU> Case<TU>(Func<Tl, TU> left, Action<Tr> right)
        {
            right(this.value);
            return Maybe.None<TU>();
        }

        public TU Case<TU>(Func<Tl, TU> left, Func<Tr, TU> right)
            => right(this.value);

        public IMaybe<TU> Case<TU>(Func<Tl, TU> left, Func<Tr, IMaybe<TU>> right)
            => Maybe.Some(right(this.value));

        public IEither<TUl, TUr> Case<TUl, TUr>(Func<Tl, TUl> left, Func<Tr, TUr> right)
            => Either.Create<TUl, TUr>(right(this.value));

        public IMaybe<TU> Case<TU>(Func<IMaybe<TU>> left, Action right)
        {
            right();
            return Maybe.None<TU>();
        }

        public IMaybe<TU> Case<TU>(Func<IMaybe<TU>> left, Action<Tr> right)
        {
            right(this.value);
            return Maybe.None<TU>();
        }

        public IMaybe<TU> Case<TU>(Func<IMaybe<TU>> left, Func<TU> right)
            => Maybe.Some(right());

        public IMaybe<TU> Case<TU>(Func<IMaybe<TU>> left, Func<Tr, TU> right)
            => Maybe.Some(right(this.value));

        public IMaybe<TU> Case<TU>(Func<IMaybe<TU>> left, Func<Tr, IMaybe<TU>> right)
            => Maybe.Some(right(this.value));

        public IMaybe<TU> Case<TU>(Func<Tl, IMaybe<TU>> left, Action right)
        {
            right();
            return Maybe.None<TU>();
        }

        public IMaybe<TU> Case<TU>(Func<Tl, IMaybe<TU>> left, Action<Tr> right)
        {
            right(this.value);
            return Maybe.None<TU>();
        }

        public IMaybe<TU> Case<TU>(Func<Tl, IMaybe<TU>> left, Func<TU> right)
            => Maybe.Some(right());

        public IMaybe<TU> Case<TU>(Func<Tl, IMaybe<TU>> left, Func<Tr, TU> right)
            => Maybe.Some(right(this.value));

        public IMaybe<TU> Case<TU>(Func<Tl, IMaybe<TU>> left, Func<Tr, IMaybe<TU>> right)
            => Maybe.Some(right(this.value));

        public IMaybe<Tr> Left(Action left)
            => Maybe.Some(this.value);

        public IMaybe<Tr> Left(Action<Tl> left)
            => Maybe.Some(this.value);

        public Tr Left(Func<Tr> left)
            => this.value;

        public Tr Left(Func<Tl, Tr> left)
            => this.value;

        public IEither<Tr, TU> Left<TU>(Func<TU> left)
            => Either.Create<Tr, TU>(this.value);

        public IEither<Tr, TU> Left<TU>(Func<Tl, TU> left)
            => Either.Create<Tr, TU>(this.value);

        public IEither<Tr, TU> Left<TU>(Func<IEither<Tr, TU>> left)
            => Either.Create<Tr, TU>(this.value);

        public IEither<Tr, TU> Left<TU>(Func<Tl, IEither<Tr, TU>> left)
            => Either.Create<Tr, TU>(this.value);

        public IMaybe<Tr> Left(Func<IMaybe<Tr>> left)
            => Maybe.None<Tr>();

        public IMaybe<Tr> Left(Func<Tl, IMaybe<Tr>> left)
            => Maybe.None<Tr>();

        public IMaybe<Tl> Right(Action right)
        {
            right();
            return Maybe.None<Tl>();
        }

        public IMaybe<Tl> Right(Action<Tr> right)
        {
            right(this.value);
            return Maybe.None<Tl>();
        }

        public Tl Right(Func<Tl> right)
            => right();

        public Tl Right(Func<Tr, Tl> right)
            => right(this.value);

        public IEither<Tl, TU> Right<TU>(Func<TU> right)
            => Either.Create<Tl, TU>(right());

        public IEither<Tl, TU> Right<TU>(Func<Tr, TU> right)
            => Either.Create<Tl, TU>(right(this.value));

        public IEither<Tl, TU> Right<TU>(Func<IEither<Tl, TU>> right)
            => Either.Create<Tl, TU>(right());

        public IEither<Tl, TU> Right<TU>(Func<Tr, IEither<Tl, TU>> right)
            => Either.Create<Tl, TU>(right(this.value));

        public IMaybe<Tl> Right(Func<IMaybe<Tl>> right)
            => Maybe.Some(right());

        public IMaybe<Tl> Right(Func<Tr, IMaybe<Tl>> right)
            => Maybe.Some(right(this.value));
    }
}
