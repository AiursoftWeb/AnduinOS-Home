using Aiursoft.AnduinOSHome.Configuration;
using Aiursoft.AnduinOSHome.Services;
using Aiursoft.AnduinOSHome.Services.FileStorage;
using Microsoft.AspNetCore.Mvc;

namespace Aiursoft.AnduinOSHome.Views.Shared.Components.MarketingNavbar;

public class MarketingNavbar(
    GlobalSettingsService globalSettingsService,
    StorageService storageService) : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(MarketingNavbarViewModel? model = null)
    {
        model ??= new MarketingNavbarViewModel();
        model.ProjectName = await globalSettingsService.GetSettingValueAsync(SettingsMap.ProjectName);
        var logoPath = await globalSettingsService.GetSettingValueAsync(SettingsMap.ProjectLogo);
        if (!string.IsNullOrWhiteSpace(logoPath))
        {
            model.LogoUrl = storageService.RelativePathToInternetUrl(logoPath, HttpContext);
        }
        return View(model);
    }
}
