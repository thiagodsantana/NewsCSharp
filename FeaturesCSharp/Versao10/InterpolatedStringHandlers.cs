using System.Runtime.CompilerServices;

namespace FeaturesCSharp.Versao10
{
    public class InterpolatedStringHandlers
    {
        static void Main()
        {
            LogMessage("INFO", $"O valor de X é {42} e o de Y é {10}.");
        }

        static void LogMessage(string logLevel, [InterpolatedStringHandlerArgument("logLevel")] CustomLogInterpolatedStringHandler handler)
        {
            if (handler.IsEnabled)
            {
                Console.WriteLine(handler.GetFormattedText());
            }
        }
    }

    [InterpolatedStringHandler]
    public readonly ref struct CustomLogInterpolatedStringHandler
    {
        private readonly string _logLevel;
        private readonly System.Text.StringBuilder _builder;

        public bool IsEnabled => _logLevel != "DEBUG"; // Exemplo de filtro

        public CustomLogInterpolatedStringHandler(int literalLength, int formattedCount, string logLevel)
        {
            _logLevel = logLevel;
            _builder = new System.Text.StringBuilder(literalLength);
        }

        public void AppendLiteral(string s)
        {
            _builder.Append(s);
        }

        public void AppendFormatted<T>(T value)
        {
            _builder.Append(value);
        }

        public string GetFormattedText() => _builder.ToString();
    }
}
