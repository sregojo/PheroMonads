namespace PheroMonads
{
    public static class Either
    {
        public static IEither<Tl, Tr> Create<Tl, Tr>(Tl value)
            => new EitherLeft<Tl, Tr>(value);

        public static IEither<Tl, Tr> Create<Tl, Tr>(Tr value)
            => new EitherRight<Tl, Tr>(value);

        public static IEither<Tl, Tr> Create<Tl, Tr>(IEither<Tl, Tr> value) => value;

        public static IMaybe<Tl> Create<Tl, Tr>(IEither<Tl, IMaybe<Tl>> value)
            => value.Case(
                right: (right) => right,
                left: (left) => left);

        public static IMaybe<Tr> Create<Tl, Tr>(IEither<Tr, IMaybe<Tr>> value)
            => value.Case(
                right: (right) => right,
                left: (left) => left);
    }
}
