using Aiursoft.UiStack.Layout;

namespace Aiursoft.AnduinOSHome.Models.BackgroundJobs;

public class JobsIndexViewModel : UiStackLayoutViewModel
{
    public IEnumerable<JobInfo> AllRecentJobs { get; init; } = [];
}
