namespace PheroMonads
{
    public static class Either
    {
        public static IEither<Tl, Tr> Create<Tl, Tr>(Tl value)
            => new EitherLeft<Tl, Tr>(value);

        public static IEither<Tl, Tr> Create<Tl, Tr>(Tr value)
            => new EitherRight<Tl, Tr>(value);

        public static IEither<Tl, Tr> Create<Tl, Tr>(IEither<Tl, Tr> value) => value;
    }
}
