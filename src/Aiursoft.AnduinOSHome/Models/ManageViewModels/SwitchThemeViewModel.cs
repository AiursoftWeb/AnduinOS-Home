using System.ComponentModel.DataAnnotations;

namespace Aiursoft.AnduinOSHome.Models.ManageViewModels;

public class SwitchThemeViewModel
{
    [Required]
    public required string Theme { get; set; }
}
