using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TouExtensionExample.Roles.Neutral;
using TownOfUs.Modules.Localization;

namespace TouExtensionExample.Options.Roles.Neutral;

public sealed class SentinelOptions : AbstractOptionGroup<SentinelRole>
{
    public override string GroupName => TouLocale.Get("ExampleRoleSentinel", "Sentinel");

    [ModdedNumberOption("ExampleOptionSentinelKillCooldown", 5f, 120f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float KillCooldown { get; set; } = 25f;

    [ModdedNumberOption("ExampleOptionSentinelExplodeCooldown", 5f, 120f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float ExplodeCooldown { get; set; } = 60f;

    public ModdedNumberOption ExplosionRadius { get; set; } = new("ExampleOptionSentinelExplosionRadius", 0.25f, 0.05f, 1f, 0.05f,
        MiraNumberSuffixes.Multiplier, "0.00");

    [ModdedToggleOption("ExampleOptionSentinelImpostorVision")]
    public bool ImpostorVision { get; set; } = true;

    [ModdedToggleOption("ExampleOptionSentinelCanVent")]
    public bool CanVent { get; set; }
}