using System;

namespace PheroMonads
{
    public static class Try
    {
        public static ITry Run(Action action)
        {            
            try {
                action();
                return Try.Success();
            }
            catch (Exception ex) { return Try.Failure(ex); }
        }

        public static ITry<T> Run<T>(Func<T> action)
        {
            try { return Try.Success(action()); }
            catch (Exception ex) { return Try.Failure<T>(ex); }
        }

        public static ITry Success() => new TrySuccess();
        public static ITry<T> Success<T>(T value) => new TrySuccess<T>(value);
        public static ITry Failure(Exception ex) => new TryFailure(ex);
        public static ITry<T> Failure<T>(Exception ex) => new TryFailure<T>(ex);
    }
}
