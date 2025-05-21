using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace GakumasLauncher
{
    public static class ArgumentExtractor
    {
        public static readonly string DefaultPath = 
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            @"\dmmgameplayer5\logs\dll.log";

        public static GakumasArgs Extract() => Extract(DefaultPath);
        public static GakumasArgs Extract(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("The log file does not exist.", path);
            }

            string exeName = "gakumas.exe";
            string linePattern = $@"Execute of:: gakumas exe";

            var matchedLines = File.ReadAllLines(path)
                .Where(line => line.Contains(linePattern))
                .ToArray();

            if (matchedLines.Length == 0)
            {
                throw new InvalidOperationException("No execution information found in the log.");
            }

            for (int i = matchedLines.Length - 1; i >= 0; i--)
            {
                string line = matchedLines[i];

                if (!TryExtractArgument(line, @"time=""([^""]+)""", out var time) ||
                    !DateTimeOffset.TryParse(time, out var dto))
                {
                    continue;
                }

                if (!TryExtractArgument(line, "/viewer_id=([^\\s]+)", out var viewId))
                {
                    continue;
                }

                if (!TryExtractArgument(line, "/open_id=([^\\s]+)", out var openId))
                {
                    continue;
                }

                if (!TryExtractArgument(line, "/pf_access_token=([^\\s]+)", out var pfAccessToken))
                {
                    continue;
                }

                if (!TryExtractArgument(line, @$"exe:\s*(.*?{Regex.Escape(exeName)})", out var exePath))
                {
                    continue;
                }

                return new GakumasArgs(dto.DateTime, viewId, openId, pfAccessToken, exePath);
            }

            throw new InvalidOperationException("Failed to extract all required information from the log.");
        }

        private static bool TryExtractArgument(string line, string pattern, [NotNullWhen(true)] out string? arg)
        {
            var match = Regex.Match(line, pattern);
            if (match.Success && match.Groups.Count > 1)
            {
                arg = match.Groups[1].Value;
                return true;
            }
            arg = default;
            return false;
        }
    }
}
