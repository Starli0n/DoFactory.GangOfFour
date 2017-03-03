using System.Windows.Forms;

namespace DoFactory.GangOfFour
{
    // Invoker for the Command Design Pattern
    public class TreeNodeCommand : TreeNode
    {
        private ICommand m_command;

        public ICommand Command
        {
            get
            {
                return m_command;
            }
            set
            {
                // Set to a default command if null,
                // so it could be executed whatever
                m_command = value ?? NoCommand.Default;
            }
        }

        public TreeNodeCommand(string text) : base(text)
        {
            Command = null;
        }

        // A TreeNode does not support to be part of another TreeView,
        // so it needs to be cloned
        override public object Clone()
        {
            return new TreeNodeCommand(this.Text)
            {
                Command = this.Command
            };
        }
    }
}
