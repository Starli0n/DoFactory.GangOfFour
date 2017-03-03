using System.Drawing;

namespace DoFactory.GangOfFour
{
    public enum PatternCategory
    {
        Creational,
        Structural,
        Behavioral
    }

    public class Pattern
    {
        public static readonly Pattern NoPattern = new Pattern();

        public string Name { get; set; }
        public PatternCategory Category { get; set; }
        public int FrequencyLevel { get; set; }
        public Image Diagram { get; set; }
        public string Definition { get; set; }
        public string Participants { get; set; } // Rtf
        public string StructuralCodeIntro { get; set; }
        public string RealWorldCodeIntro { get; set; }
        public string OptimizedCodeIntro { get; set; }
    }
}
