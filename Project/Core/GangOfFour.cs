using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoFactory.GangOfFour
{
    public class GangOfFour
    {
        public const int FrequencyLevelCount = 5;

        private const string c_sDiagramFormat = "{0}{1}.gif";
        private const string c_sRTFFormat = "{0}{1}.rtf";
        private static readonly string[] c_sTxtSections = new string[] {
            "Definition", "Structural code", "Real-world code", "Optimized code" };

        public string Name { get; } = "GangOfFour";
        public ICollection<Pattern> Items { get; set; }
        public PatternCommandType CurrentType { get; set; }

        public GangOfFour()
        {
            CurrentType = PatternCommandType.Structural;
            Items = new List<Pattern>(new Pattern[]
                {
                    new Pattern
                    {
                        Name = "AbstractFactory",
                        Category = PatternCategory.Creational,
                        FrequencyLevel = 5,
                    },
                    new Pattern
                    {
                        Name = "Builder",
                        Category = PatternCategory.Creational,
                        FrequencyLevel = 2,
                    },
                    new Pattern
                    {
                        Name = "FactoryMethod",
                        Category = PatternCategory.Creational,
                        FrequencyLevel = 5,
                    },
                    new Pattern
                    {
                        Name = "Prototype",
                        Category = PatternCategory.Creational,
                        FrequencyLevel = 3,
                    },
                    new Pattern
                    {
                        Name = "Singleton",
                        Category = PatternCategory.Creational,
                        FrequencyLevel = 4,
                    },
                    new Pattern
                    {
                        Name = "Adapter",
                        Category = PatternCategory.Structural,
                        FrequencyLevel = 4,
                    },
                    new Pattern
                    {
                        Name = "Bridge",
                        Category = PatternCategory.Structural,
                        FrequencyLevel = 3,
                    },
                    new Pattern
                    {
                        Name = "Composite",
                        Category = PatternCategory.Structural,
                        FrequencyLevel = 4,
                    },
                    new Pattern
                    {
                        Name = "Decorator",
                        Category = PatternCategory.Structural,
                        FrequencyLevel = 3,
                    },
                    new Pattern
                    {
                        Name = "Facade",
                        Category = PatternCategory.Structural,
                        FrequencyLevel = 5,
                    },
                    new Pattern
                    {
                        Name = "Flyweight",
                        Category = PatternCategory.Structural,
                        FrequencyLevel = 1,
                    },
                    new Pattern
                    {
                        Name = "Proxy",
                        Category = PatternCategory.Structural,
                        FrequencyLevel = 4,
                    },
                    new Pattern
                    {
                        Name = "ChainOfResponsibility",
                        Category = PatternCategory.Behavioral,
                        FrequencyLevel = 2,
                    },
                    new Pattern
                    {
                        Name = "Command",
                        Category = PatternCategory.Behavioral,
                        FrequencyLevel = 4,
                    },
                    new Pattern
                    {
                        Name = "Interpreter",
                        Category = PatternCategory.Behavioral,
                        FrequencyLevel = 1,
                    },
                    new Pattern
                    {
                        Name = "Iterator",
                        Category = PatternCategory.Behavioral,
                        FrequencyLevel = 5,
                    },
                    new Pattern
                    {
                        Name = "Mediator",
                        Category = PatternCategory.Behavioral,
                        FrequencyLevel = 2,
                    },
                    new Pattern
                    {
                        Name = "Memento",
                        Category = PatternCategory.Behavioral,
                        FrequencyLevel = 1,
                    },
                    new Pattern
                    {
                        Name = "Observer",
                        Category = PatternCategory.Behavioral,
                        FrequencyLevel = 5,
                    },
                    new Pattern
                    {
                        Name = "State",
                        Category = PatternCategory.Behavioral,
                        FrequencyLevel = 3,
                    },
                    new Pattern
                    {
                        Name = "Strategy",
                        Category = PatternCategory.Behavioral,
                        FrequencyLevel = 4,
                    },
                    new Pattern
                    {
                        Name = "TemplateMethod",
                        Category = PatternCategory.Behavioral,
                        FrequencyLevel = 3,
                    },
                    new Pattern
                    {
                        Name = "Visitor",
                        Category = PatternCategory.Behavioral,
                        FrequencyLevel = 1,
                    },
                });
        }

        // Get patterns by category
        public IEnumerable<Pattern> Patterns(PatternCategory category)
        {
            return from p in Items
                   where p.Category == category
                   select p;
        }

        // Get patterns by level
        public IEnumerable<Pattern> Patterns(int level)
        {
            return from p in Items
                   where p.FrequencyLevel == level
                   select p;
        }

        // Get pattern by name
        internal Pattern GetPattern(string sName)
        {
            return (from p in Items
                    where p.Name == sName
                    select p
                    ).FirstOrDefault();
        }

        // Load data from various files
        public void LoadFiles(PatternCategory category, string sPath)
        {
            string sBase;
            RichTextBox rtf = new RichTextBox();
            foreach (Pattern p in Patterns(category))
            {
                sBase = Path.Combine(sPath, p.Name);
                p.Diagram = Image.FromFile(sBase + ".gif");
                List<string> section = LoadSections(sBase + ".txt");
                p.Definition = section[0];
                p.StructuralCodeIntro = section[1];
                p.RealWorldCodeIntro = section[2];
                p.OptimizedCodeIntro = section[3];
                rtf.LoadFile(sBase + ".rtf");
                p.Participants = rtf.Rtf;
            }
        }

        // Load sections of the txt files
        public List<string> LoadSections(string sFile)
        {
            List<string> sections = new List<string>();
            StringBuilder section = new StringBuilder();

            // Read each line of the txt file
            foreach (string sLine in File.ReadLines(sFile))
            {
                // Reach a new section and Skip the first one which is empty
                if (c_sTxtSections.Contains(sLine) && section.Length > 0)
                {
                    // Flush the builder
                    sections.Add(section.ToString());
                    section.Clear();
                }
                section.AppendLine(sLine);
            }
            // Flush the section after EOF
            sections.Add(section.ToString());

            // Add empty missing sections
            while (sections.Count < c_sTxtSections.Count())
                sections.Add("");

            return sections;
        }
    }
}
