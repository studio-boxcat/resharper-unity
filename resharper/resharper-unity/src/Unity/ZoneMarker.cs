﻿using JetBrains.Application.BuildScript.Application.Zones;
using JetBrains.ReSharper.Daemon.SolutionAnalysis;
using JetBrains.ReSharper.Feature.Services.Daemon;
using JetBrains.ReSharper.Plugins.Json;
using JetBrains.ReSharper.Plugins.Yaml;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.ReSharper.Resources.Shell;

namespace JetBrains.ReSharper.Plugins.Unity
{
    // IMPORTANT! Do not add any requirements to this zone that aren't satisfied by IInspectCodeZone, otherwise we won't
    // be able to run in CLT
    [ZoneDefinition(ZoneFlags.AutoEnable)]
    [ZoneDefinitionConfigurableFeature("Unity Plugin", "Game development with Unity", true)]
    public interface IUnityPluginZone : IZone,
        IRequire<DaemonZone>,
        IRequire<ILanguageJsonNewZone>,
        IRequire<ILanguageCSharpZone>,
        IRequire<PsiFeaturesImplZone>,
        IRequire<ILanguageYamlZone>,
        IRequire<SweaZone>
    {
    }

    [ZoneMarker]
    public class ZoneMarker : IRequire<IUnityPluginZone>
    {
    }
}