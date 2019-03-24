namespace PheroMonads
{
    public abstract class EitherOperand<T>
    {
        protected readonly T value;

        protected EitherOperand(T value) => this.value = value;
    }
}
