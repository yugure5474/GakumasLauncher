using System.Diagnostics;
using System.Text;

namespace GakumasLauncher
{
    public record GakumasArgs
    {
        public DateTime DateTime { get; }
        public string ViewerId { get; }
        public string OpenId { get; }
        public string PfAccessToken { get; }
        public string ExePath { get; }

        public GakumasArgs(DateTime dateTime, string viewerId, string openId, string pfAccessToken, string exePath)
        {
            DateTime = dateTime;
            ViewerId = viewerId ?? string.Empty;
            OpenId = openId ?? string.Empty;
            PfAccessToken = pfAccessToken ?? string.Empty;
            ExePath = exePath ?? string.Empty;
        }

        public Process? StartProcess()
        {
            string arguments = $"/viewer_id={ViewerId} /open_id={OpenId} /pf_access_token={PfAccessToken}";
            return Process.Start(new ProcessStartInfo
            {
                WorkingDirectory = Path.GetDirectoryName(ExePath),
                Arguments = arguments,
                FileName = ExePath,
            });
        }
    }
}
