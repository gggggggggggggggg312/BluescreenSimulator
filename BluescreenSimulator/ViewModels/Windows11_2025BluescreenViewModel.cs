using BluescreenSimulator.ViewModels;

namespace BluescreenSimulator.ViewModels
{
    [BluescreenView(typeof(BluescreenWindow))]
    [CmdParameter("--win11", Description = "Uses a Windows 11 (2025) blue screen.")]
    public class Windows11_2025BluescreenViewModel
        : BluescreenViewModelBase<Windows10Bluescreen>
    {
        public override string StyleName => "Windows 11 (2025)";

        // Windows 11–style helpers
        public string ProgressText => $"{Progress}% complete";

        public string StopCode2025
        {
            get
            {
                if (string.IsNullOrWhiteSpace(StopCode))
                    return string.Empty;

                return $"Stop code: {StopCode}";
            }
        }

        public override bool SupportsRainbow => true;
    }
}
