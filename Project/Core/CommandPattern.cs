using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace DoFactory.GangOfFour
{
    // The three type of code examples
    public enum PatternCommandType
    {
        Structural,
        RealWorld,
        Optimized
    }

    // Concrete class for the Command Design pattern
    public class CommandPattern : ICommand
    {
        private const string c_sAppFormat = "DoFactory.GangOfFour.{0}.{1}.MainApp";
        private const string c_sLogFormat = "Run {0} pattern - {1}\n";
        private const string c_sEntryPoint = "Main";
        private const string c_sMainAppError = "Unable to find the app named:\n   ";
        private const string c_sMainError = "Unable to find the entry point 'Main' for app named:\n   ";
        private string m_sPatternName;
        private GangOfFour m_gof;

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool FreeConsole();

        public CommandPattern(string sPatternName, GangOfFour gof)
        {
            m_sPatternName = sPatternName;
            m_gof = gof; // Use only to get the current type while performing the action
        }

        public void Do()
        {
            try
            {
                // Create a console
                AllocConsole();

                PatternCommandType type = m_gof.CurrentType;

                // Log the running pattern
                Console.WriteLine(string.Format(c_sLogFormat, m_sPatternName, type.ToString()));

                // Find Class by reflection
                string sAppName = string.Format(c_sAppFormat, m_sPatternName, type.ToString());
                Type mainApp = Type.GetType(sAppName);
                if (mainApp == null)
                    throw new GoFException(c_sMainAppError + sAppName);

                // Find Main Entry point by reflection
                MethodInfo main = mainApp.GetMethod(c_sEntryPoint, BindingFlags.Static | BindingFlags.Public);
                if (main == null)
                    throw new GoFException(c_sMainError + sAppName);

                // Call the main entry point for the pattern
                main.Invoke(null, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                if (ex.InnerException != null)
                {
                    Console.WriteLine();
                    Console.WriteLine(ex.InnerException.Message);
                }


                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);

                Console.ReadKey();
            }
            finally
            {
                // Release the console
                FreeConsole();
            }
        }
    }
}
