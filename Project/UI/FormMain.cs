using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DoFactory.GangOfFour
{
    public partial class FormMain : Form
    {
        // Constantes
#if DEBUG
        private const string c_sRootPath = "../../";
#else
        private const string c_sRootPath = "";
#endif
        private const string c_sCreationalPath = c_sRootPath + "1.Creational";
        private const string c_sStructuralPath = c_sRootPath + "2.Structural";
        private const string c_sBehavioralPath = c_sRootPath + "3.Behavioral";
        private const string c_sImagePath = c_sRootPath + "Image";
        private const string c_sImageFormat = "Level{0}.gif";
        private static readonly string[] c_sFrequencyDescription = new string[] {
            "None", "Low", "Medium low", "Medium", "Medium high", "High" };

        // Data members
        private GangOfFour m_gof;
        private TreeNode m_gofByCategoryNode;
        private TreeNode m_gofByLevelNode;
        private List<Image> m_frequencyLevelImages;
        private bool m_bCtrlDown;
        private bool m_bAltDown;

        public FormMain()
        {
            InitializeComponent();

            m_gof = new GangOfFour();
            m_frequencyLevelImages = new List<Image>();
            m_bCtrlDown = false;
            m_bAltDown = false;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            /*** Init Components ***/

            // Initialize each pattern with their details
            m_gof.LoadFiles(PatternCategory.Creational, c_sCreationalPath);
            m_gof.LoadFiles(PatternCategory.Structural, c_sStructuralPath);
            m_gof.LoadFiles(PatternCategory.Behavioral, c_sBehavioralPath);

            // Create two root node
            // 1) Sort pattern by category
            // 2) Sort pattern by frequency level
            m_gofByCategoryNode = new TreeNode(m_gof.Name);
            m_gofByLevelNode = new TreeNode(m_gof.Name);

            // Create nodes for each category
            TreeNode creationalNode = new TreeNode("Creational Patterns");
            TreeNode structuralNode = new TreeNode("Structural Patterns");
            TreeNode behavioralNode = new TreeNode("Behavioral Patterns");

            // Add each category to the appropriate root
            m_gofByCategoryNode.Nodes.Add(creationalNode);
            m_gofByCategoryNode.Nodes.Add(structuralNode);
            m_gofByCategoryNode.Nodes.Add(behavioralNode);

            // Create nodes for each frequency level
            // Add each fequency level to the appropriate root
            // Load frequency images
            TreeNode node;
            string sImageFormat = Path.Combine(c_sImagePath, c_sImageFormat);
            m_frequencyLevelImages.Add(Image.FromFile(string.Format(sImageFormat, 0)));
            foreach (int i in Enumerable.Range(1, GangOfFour.FrequencyLevelCount))
            {
                node = new TreeNode("Level " + i);
                m_gofByLevelNode.Nodes.Insert(0, node); // Order by level desc

                m_frequencyLevelImages.Add(Image.FromFile(string.Format(sImageFormat, i)));
            }

            // Create nodes for each pattern
            TreeNodeCommand nodeCmd;
            foreach (Pattern pattern in m_gof.Items)
            {
                // Create a node for a pattern
                nodeCmd = new TreeNodeCommand(pattern.Name);

                // Set the concrete commands to the invoker (see: command design pattern)
                nodeCmd.Command = new CommandPattern(nodeCmd.Text, m_gof);

                // Dispatch it to the appropriate category
                switch (pattern.Category)
                {
                    case PatternCategory.Creational:
                        creationalNode.Nodes.Add(nodeCmd);
                        break;
                    case PatternCategory.Structural:
                        structuralNode.Nodes.Add(nodeCmd);
                        break;
                    case PatternCategory.Behavioral:
                        behavioralNode.Nodes.Add(nodeCmd);
                        break;
                    default:
                        break;
                }

                // Do the same for the level frequency
                // A tree node does not support to be added at different places
                // Then, it has to be cloned
                nodeCmd = (TreeNodeCommand)nodeCmd.Clone();
                node = m_gofByLevelNode.Nodes[GangOfFour.FrequencyLevelCount - pattern.FrequencyLevel];
                node.Nodes.Add(nodeCmd);
            }

            /*** Init UI ***/

            // Select the category sort at first
            m_treeView.Nodes.Add(m_gofByCategoryNode);
            m_treeView.ExpandAll();

            // Select the node during a right click event
            // (By default a node is also selected with a left click event)
            m_treeView.NodeMouseClick += (s, args) => m_treeView.SelectedNode = args.Node;
        }

        // Double click on a node
        // - On the root to switch the view (order by category or frequency level)
        // - On a pattern (leaf) to run the associated pattern
        // - No effect on a sub-node
        private void m_treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Switch view when the root node is clicked
            if (e.Node.Text == m_gof.Name)
            {
                TreeNode node = m_treeView.Nodes[0] == m_gofByCategoryNode ?
                    m_gofByLevelNode : m_gofByCategoryNode;

                m_treeView.Nodes.Clear();
                m_treeView.Nodes.Add(node);
                m_treeView.ExpandAll();
            }
            else if (e.Button == MouseButtons.Left)
            {
                ExecutePattern(e.Node);
            }
        }

        // TreeView change selection
        private void m_treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Find the pattern associate to the node
            Pattern pattern = GetPatternFromNode(e.Node);

            // Adapt the UI
            m_lPatternName.Text = string.IsNullOrEmpty(pattern.Name) ? m_gof.Name : pattern.Name;
            m_rtbDefinition.Text = pattern.Definition;
            m_pbDiagram.Image = pattern.Diagram;
            SetRtbCode(pattern);
            m_rtbParticipants.Rtf = pattern.Participants;
            m_pbFrequencyLevel.Image = m_frequencyLevelImages[pattern.FrequencyLevel];
            m_lFrequencyDescription.Text = c_sFrequencyDescription[pattern.FrequencyLevel];
            m_bRun.Enabled = !string.IsNullOrEmpty(pattern.Name);
        }

        // Radio change selection
        private void Radio_CheckedChanged(object sender, EventArgs e)
        {
            Pattern pattern = GetPatternFromNode(m_treeView.SelectedNode);
            SetRtbCode(pattern); // Update the code rich text box when the selection of a radio button changed

            // Update the gof current type
            // used by CommandPatter.Do() to execute the appropriated code
            if (m_rbStructural.Checked)
                m_gof.CurrentType= PatternCommandType.Structural;

            else if (m_rbRealworld.Checked)
                m_gof.CurrentType = PatternCommandType.RealWorld;

            else if (m_rbOptimized.Checked)
                m_gof.CurrentType = PatternCommandType.Optimized;
        }

        // Run click
        private void m_bRun_Click(object sender, EventArgs e)
        {
            ExecutePattern(m_treeView.SelectedNode);
        }

        // Temporally change the type of code while pressing Alt-Key
        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            // Execute on Enter-Key pressed
            if (e.KeyCode == Keys.Enter)
                ExecutePattern(m_treeView.SelectedNode);

            // Keys.Menu is Alt-Key
            else if (e.KeyCode == Keys.Menu && !m_bAltDown)
                ToggleCode();
        }

        // The revert of KeyDown
        private void FormMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Menu && m_bAltDown)
                ToggleCode();
        }

        // Get the pattern associated to the node
        private Pattern GetPatternFromNode(TreeNode node)
        {
            return m_gof.GetPattern(node.Text) ?? Pattern.NoPattern;
        }

        // Set the code rich text box accordingly to the pattern and the selected radio button
        private void SetRtbCode(Pattern pattern)
        {
            if (m_rbStructural.Checked)
                m_rtbCode.Text = pattern.StructuralCodeIntro;

            else if (m_rbRealworld.Checked)
                m_rtbCode.Text = pattern.RealWorldCodeIntro;

            else if (m_rbOptimized.Checked)
                m_rtbCode.Text = pattern.OptimizedCodeIntro;
        }

        private void ExecutePattern(TreeNode node)
        {
            TreeNodeCommand nodeCmd = node as TreeNodeCommand;
            if (nodeCmd == null)
                return; // Nothing to do if the node is not a leaf

            nodeCmd.Command.Do();
        }

        // Switch between Structural code <--> Real-world code
        // Do nothing for bOptimized code
        private void ToggleCode()
        {
            m_bAltDown = !m_bAltDown;

            if (m_rbStructural.Checked)
                m_rbRealworld.Checked = true;

            else if (m_rbRealworld.Checked)
                m_rbStructural.Checked = true;

            else if (m_rbOptimized.Checked)
                m_rbOptimized.Checked = m_rbOptimized.Checked;
        }
    }
}
