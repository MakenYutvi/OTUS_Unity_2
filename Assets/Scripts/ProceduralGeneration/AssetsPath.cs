using System.Collections.Generic;

public static class AssetsPath
{
    public static readonly Dictionary<PlatformType, string> Platforms =
        new Dictionary<PlatformType, string>
    {
        {PlatformType.Main, "Platforms/Platforms_Main"},
        {PlatformType.Short, "Platforms/Platforms_Short"},
        {PlatformType.BevelRight, "Platforms/Platforms_Bevel"},
        {PlatformType.AutumnHill, "Platforms/Platforms_AutumnHill"},
        {PlatformType.Move, "Platforms/Platforms_Move"},

    };

    public static readonly Dictionary<AdditionalObjectType, string> AdditionalObjects =
        new Dictionary<AdditionalObjectType, string>
        {
            {AdditionalObjectType.Saw, "Traps/Traps_Saw"},
            {AdditionalObjectType.AidKit, "Bonuses/Bonuses_AidKit"},
            {AdditionalObjectType.Coin, "Bonuses/Bonuses_Coin"},
            {AdditionalObjectType.CannonBall, "Traps/Traps_CannonBall"},
        };
}
