using System;
using UnityEngine;
using Object = UnityEngine.Object;


public sealed class PlatformFactory
{
    private PlatformBehaviour _mainPlatform;
    private PlatformBehaviour _shortPlatform;
    private PlatformBehaviour _AutumnHillPlatform;
    private PlatformBehaviour _BevelRightPlatform;
    private PlatformBehaviour _MovePlatform;

    public PlatformBehaviour GetPlatform(PlatformType type)
    {
        PlatformBehaviour prefab;
        switch (type)
        {
            case PlatformType.Main:
                prefab = GetMainPlatform();
                break;
            case PlatformType.Short:
                prefab = GetShortPlatform();
                break;
            case PlatformType.BevelRight:
                prefab = GetBevelRightPlatform();
                break;
            case PlatformType.AutumnHill:
                prefab = GetAutumnHillPlatform();
                break;
            case PlatformType.Move:
                prefab = GetMovePlatform();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(type), type, null);
        }

        return Object.Instantiate(prefab);
    }


    private PlatformBehaviour GetShortPlatform()
    {
        if (!_shortPlatform)
        {
            _shortPlatform =
                Resources.Load<PlatformBehaviour>
                    (AssetsPath.Platforms[PlatformType.Short]);
        }

        return _shortPlatform;
    }


    private PlatformBehaviour GetMainPlatform()
    {
        if (!_mainPlatform)
        {
            _mainPlatform =
                Resources.Load<PlatformBehaviour>
                    (AssetsPath.Platforms[PlatformType.Main]);
        }

        return _mainPlatform;
    }

    private PlatformBehaviour GetBevelRightPlatform()
    {
        if (!_BevelRightPlatform)
        {
            _BevelRightPlatform =
                Resources.Load<PlatformBehaviour>
                    (AssetsPath.Platforms[PlatformType.BevelRight]);
        }

        return _BevelRightPlatform;
    }

    private PlatformBehaviour GetAutumnHillPlatform()
    {
        if (!_AutumnHillPlatform)
        {
            _AutumnHillPlatform =
                Resources.Load<PlatformBehaviour>
                    (AssetsPath.Platforms[PlatformType.AutumnHill]);
        }

        return _AutumnHillPlatform;
    }

    private PlatformBehaviour GetMovePlatform()
    {
        if (!_MovePlatform)
        {
            _MovePlatform =
                Resources.Load<PlatformBehaviour>
                    (AssetsPath.Platforms[PlatformType.Move]);
        }

        return _MovePlatform;
    }

}
