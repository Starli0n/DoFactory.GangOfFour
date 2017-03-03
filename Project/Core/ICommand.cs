namespace DoFactory.GangOfFour
{
	// Interface for the Command Design Pattern
    public interface ICommand
    {
        void Do();
    }

	// A no command concrete implementations
    public class NoCommand : ICommand
    {
        public static readonly ICommand Default = new NoCommand();
        public void Do() {}
    }
}
