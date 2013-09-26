using PatternLibrary.Patterns.Command.Interface;

namespace PatternLibrary.Patterns.Command.Abstract
{
    public abstract class Command<T> : ICommand
    {
        protected T Target;

        protected Command(T target)
        {
            Target = target;
        }

        public abstract void Exequte();
        public abstract void Undo();
    }
}