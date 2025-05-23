﻿#nullable enable

using System.Diagnostics.CodeAnalysis;
using JetBrains.Metadata.Reader.API;
using JetBrains.Metadata.Reader.Impl;

namespace JetBrains.ReSharper.Plugins.Unity.UnityEditorIntegration.Api
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static class KnownTypes
    {
        // System
        public static readonly IClrTypeName SystemVersion = new ClrTypeName("System.Version");

        // UnityEngine
        public static readonly IClrTypeName AddComponentMenu = new ClrTypeName("UnityEngine.AddComponentMenu");
        public static readonly IClrTypeName AnimationCurve = new ClrTypeName("UnityEngine.AnimationCurve");
        public static readonly IClrTypeName Animator = new ClrTypeName("UnityEngine.Animator");
        public static readonly IClrTypeName Bounds = new ClrTypeName("UnityEngine.Bounds");
        public static readonly IClrTypeName BoundsInt = new ClrTypeName("UnityEngine.BoundsInt");
        public static readonly IClrTypeName Camera = new ClrTypeName("UnityEngine.Camera");
        public static readonly IClrTypeName Color = new ClrTypeName("UnityEngine.Color");
        public static readonly IClrTypeName Color32 = new ClrTypeName("UnityEngine.Color32");
        public static readonly IClrTypeName Component = new ClrTypeName("UnityEngine.Component");
        public static readonly IClrTypeName ComputeShader = new ClrTypeName("UnityEngine.ComputeShader");
        public static readonly IClrTypeName CreateAssetMenuAttribute = new ClrTypeName("UnityEngine.CreateAssetMenuAttribute");
        public static readonly IClrTypeName Debug = new ClrTypeName("UnityEngine.Debug");
        public static readonly IClrTypeName ExecuteInEditMode = new ClrTypeName("UnityEngine.ExecuteInEditMode");
        public static readonly IClrTypeName GameObject = new ClrTypeName("UnityEngine.GameObject");
        public static readonly IClrTypeName Gradient = new ClrTypeName("UnityEngine.Gradient");
        public static readonly IClrTypeName GUIStyle = new ClrTypeName("UnityEngine.GUIStyle");
        public static readonly IClrTypeName HeaderAttribute = new ClrTypeName("UnityEngine.HeaderAttribute");
        public static readonly IClrTypeName HideInInspectorAttribute = new ClrTypeName("UnityEngine.HideInInspector");
        public static readonly IClrTypeName ImageEffectAfterScale = new ClrTypeName("UnityEngine.ImageEffectAfterScale");
        public static readonly IClrTypeName ImageEffectAllowedInSceneView = new ClrTypeName("UnityEngine.ImageEffectAllowedInSceneView");
        public static readonly IClrTypeName ImageEffectOpaque = new ClrTypeName("UnityEngine.ImageEffectOpaque");
        public static readonly IClrTypeName ImageEffectTransformsToLDR = new ClrTypeName("UnityEngine.ImageEffectTransformsToLDR");
        public static readonly IClrTypeName Input = new ClrTypeName("UnityEngine.Input");
        public static readonly IClrTypeName LayerMask = new ClrTypeName("UnityEngine.LayerMask");
        public static readonly IClrTypeName Material = new ClrTypeName("UnityEngine.Material");
        public static readonly IClrTypeName MaterialPropertyBlock = new ClrTypeName("UnityEngine.MaterialPropertyBlock");
        public static readonly IClrTypeName Matrix4x4 = new ClrTypeName("UnityEngine.Matrix4x4");
        public static readonly IClrTypeName MinAttribute = new ClrTypeName("UnityEngine.MinAttribute");
        public static readonly IClrTypeName MonoBehaviour = new ClrTypeName("UnityEngine.MonoBehaviour");
        public static readonly IClrTypeName Object = new ClrTypeName("UnityEngine.Object");
        public static readonly IClrTypeName Physics = new ClrTypeName("UnityEngine.Physics");
        public static readonly IClrTypeName Physics2D = new ClrTypeName("UnityEngine.Physics2D");
        public static readonly IClrTypeName Quaternion = new ClrTypeName("UnityEngine.Quaternion");
        public static readonly IClrTypeName RangeAttribute = new ClrTypeName("UnityEngine.RangeAttribute");
        public static readonly IClrTypeName RequireComponent = new ClrTypeName("UnityEngine.RequireComponent");
        public static readonly IClrTypeName Rect = new ClrTypeName("UnityEngine.Rect");
        public static readonly IClrTypeName RectInt = new ClrTypeName("UnityEngine.RectInt");
        public static readonly IClrTypeName RectOffset = new ClrTypeName("UnityEngine.RectOffset");
        public static readonly IClrTypeName Resources = new ClrTypeName("UnityEngine.Resources");
        public static readonly IClrTypeName GlobalKeyword = new ClrTypeName("UnityEngine.Rendering.GlobalKeyword");
        public static readonly IClrTypeName LocalKeyword = new ClrTypeName("UnityEngine.Rendering.LocalKeyword");
        public static readonly IClrTypeName RuntimeInitializeOnLoadMethodAttribute = new ClrTypeName("UnityEngine.RuntimeInitializeOnLoadMethodAttribute");
        public static readonly IClrTypeName ScriptableObject = new ClrTypeName("UnityEngine.ScriptableObject");
        public static readonly IClrTypeName SerializeField = new ClrTypeName("UnityEngine.SerializeField");
        public static readonly IClrTypeName SerializeReference = new ClrTypeName("UnityEngine.SerializeReference");
        public static readonly IClrTypeName Shader = new ClrTypeName("UnityEngine.Shader");
        public static readonly IClrTypeName SpaceAttribute = new ClrTypeName("UnityEngine.SpaceAttribute");
        public static readonly IClrTypeName TooltipAttribute = new ClrTypeName("UnityEngine.TooltipAttribute");
        public static readonly IClrTypeName Transform = new ClrTypeName("UnityEngine.Transform");
        public static readonly IClrTypeName Vector2 = new ClrTypeName("UnityEngine.Vector2");
        public static readonly IClrTypeName Vector2Int = new ClrTypeName("UnityEngine.Vector2Int");
        public static readonly IClrTypeName Vector3 = new ClrTypeName("UnityEngine.Vector3");
        public static readonly IClrTypeName Vector3Int = new ClrTypeName("UnityEngine.Vector3Int");
        public static readonly IClrTypeName Vector4 = new ClrTypeName("UnityEngine.Vector4");
        public static readonly IClrTypeName UnityEvent = new ClrTypeName("UnityEngine.Events.UnityEventBase");
        public static readonly IClrTypeName SphericalHarmonicsL2 = new ClrTypeName("UnityEngine.Rendering.SphericalHarmonicsL2");
        public static readonly IClrTypeName LazyLoadReference = new ClrTypeName("UnityEngine.LazyLoadReference`1");
        public static readonly IClrTypeName VisualElement = new ClrTypeName("UnityEngine.UIElements.VisualElement");
        public static readonly IClrTypeName Mathf = new ClrTypeName("UnityEngine.Mathf");
        public static readonly IClrTypeName Profiler = new ClrTypeName("UnityEngine.Profiling.Profiler");

        // UnityEngine.Networking
        public static readonly IClrTypeName NetworkBehaviour = new ClrTypeName("UnityEngine.Networking.NetworkBehaviour");
        public static readonly IClrTypeName SyncVarAttribute =
            new ClrTypeName("UnityEngine.Networking.SyncVarAttribute");

        // UnityEngine.Rendering
        public static readonly IClrTypeName CommandBuffer = new ClrTypeName("UnityEngine.Rendering.CommandBuffer");
        
        // UnityEngine.Serialization
        public static readonly IClrTypeName FormerlySerializedAsAttribute =
            new ClrTypeName("UnityEngine.Serialization.FormerlySerializedAsAttribute");

        // UnityEditor
        public static readonly IClrTypeName BuildTarget = new ClrTypeName("UnityEditor.BuildTarget");
        public static readonly IClrTypeName CanEditMultipleObjects = new ClrTypeName("UnityEditor.CanEditMultipleObjects");
        public static readonly IClrTypeName CustomEditor = new ClrTypeName("UnityEditor.CustomEditor");
        public static readonly IClrTypeName Editor = new ClrTypeName("UnityEditor.Editor");
        public static readonly IClrTypeName EditorWindow = new ClrTypeName("UnityEditor.EditorWindow");
        public static readonly IClrTypeName DrawGizmo = new ClrTypeName("UnityEditor.DrawGizmo");
        public static readonly IClrTypeName GizmoType = new ClrTypeName("UnityEditor.GizmoType");
        public static readonly IClrTypeName InitializeOnLoadAttribute = new ClrTypeName("UnityEditor.InitializeOnLoadAttribute");
        public static readonly IClrTypeName InitializeOnLoadMethodAttribute = new ClrTypeName("UnityEditor.InitializeOnLoadMethodAttribute");
        public static readonly IClrTypeName MenuCommand = new ClrTypeName("UnityEditor.MenuCommand");
        public static readonly IClrTypeName MenuItemAttribute = new ClrTypeName("UnityEditor.MenuItem");
        public static readonly IClrTypeName PreferenceItem = new ClrTypeName("UnityEditor.PreferenceItem");
        public static readonly IClrTypeName PropertyDrawer = new ClrTypeName("UnityEditor.PropertyDrawer");
        public static readonly IClrTypeName RequiredSignatureAttribute = new ClrTypeName("UnityEditor.RequiredSignatureAttribute");
        public static readonly IClrTypeName AssetDatabase = new ClrTypeName("UnityEditor.AssetDatabase");

        // UnityEditor.Callbacks
        public static readonly IClrTypeName DidReloadScripts = new ClrTypeName("UnityEditor.Callbacks.DidReloadScripts");
        public static readonly IClrTypeName OnOpenAssetAttribute = new ClrTypeName("UnityEditor.Callbacks.OnOpenAssetAttribute");
        public static readonly IClrTypeName PostProcessBuildAttribute = new ClrTypeName("UnityEditor.Callbacks.PostProcessBuildAttribute");
        public static readonly IClrTypeName PostProcessSceneAttribute = new ClrTypeName("UnityEditor.Callbacks.PostProcessSceneAttribute");

        // UnityEditor.SceneManagement
        public static readonly IClrTypeName EditorSceneManager = new ClrTypeName("UnityEditor.SceneManagement.EditorSceneManager");
        public static readonly IClrTypeName SceneManager = new ClrTypeName("UnityEngine.SceneManagement.SceneManager");

        // ECS/DOTS
        public static readonly IClrTypeName ComponentSystemBase = new ClrTypeName("Unity.Entities.ComponentSystemBase");
        public static readonly IClrTypeName SystemBase = new ClrTypeName("Unity.Entities.SystemBase");
        public static readonly IClrTypeName ISystem = new ClrTypeName("Unity.Entities.ISystem");
        public static readonly IClrTypeName IBaker = new ClrTypeName("Unity.Entities.IBaker");
        public static readonly IClrTypeName Baker = new ClrTypeName("Unity.Entities.Baker`1");
        public static readonly IClrTypeName IAspect = new ClrTypeName("Unity.Entities.IAspect");
        public static readonly IClrTypeName IJobEntity = new ClrTypeName("Unity.Entities.IJobEntity");
        public static readonly IClrTypeName IComponentData = new ClrTypeName("Unity.Entities.IComponentData");
        public static readonly IClrTypeName ComponentLookup = new ClrTypeName("Unity.Entities.ComponentLookup`1");
        public static readonly IClrTypeName SystemState = new ClrTypeName("Unity.Entities.SystemState");
        public static readonly IClrTypeName SystemAPI = new ClrTypeName("Unity.Entities.SystemAPI");
        public static readonly IClrTypeName SystemAPIQueryBuilder = new ClrTypeName("Unity.Entities.SystemAPIQueryBuilder");
        public static readonly IClrTypeName Entity = new ClrTypeName("Unity.Entities.Entity");
        public static readonly IClrTypeName RefRO = new ClrTypeName("Unity.Entities.RefRO`1");
        public static readonly IClrTypeName RefRW = new ClrTypeName("Unity.Entities.RefRW`1");
        public static readonly IClrTypeName EnabledRefRO = new ClrTypeName("Unity.Entities.EnabledRefRO`1");
        public static readonly IClrTypeName EnabledRefRW = new ClrTypeName("Unity.Entities.EnabledRefRW`1");
        public static readonly IClrTypeName IQueryTypeParameter = new ClrTypeName("Unity.Entities.IQueryTypeParameter");
        public static readonly IClrTypeName IEnableableComponent = new ClrTypeName("Unity.Entities.IEnableableComponent");
        public static readonly IClrTypeName TransformUsageFlags = new ClrTypeName("Unity.Entities.TransformUsageFlags");
        public static readonly IClrTypeName DOTSCompilerGenerated = new ClrTypeName("Unity.Jobs.DOTSCompilerGeneratedAttribute");
        
        //Unity.Mathematics
        public static readonly IClrTypeName Random = new ClrTypeName("Unity.Mathematics.Random");
        public static readonly IClrTypeName Float2 = new ClrTypeName("Unity.Mathematics.float2");
        public static readonly IClrTypeName Float3 = new ClrTypeName("Unity.Mathematics.float3");

        // Burst
        public static readonly IClrTypeName BurstCompiler = new ClrTypeName("Unity.Burst.BurstCompiler");
        public static readonly IClrTypeName BurstCompileAttribute = new ClrTypeName("Unity.Burst.BurstCompileAttribute");
        public static readonly IClrTypeName BurstDiscardAttribute = new ClrTypeName("Unity.Burst.BurstDiscardAttribute");
        public static readonly IClrTypeName JobProducerAttribute = new ClrTypeName("Unity.Jobs.LowLevel.Unsafe.JobProducerTypeAttribute");
        public static readonly IClrTypeName NativeSetClassTypeToNullOnScheduleAttribute = new ClrTypeName("Unity.Collections.LowLevel.Unsafe.NativeSetClassTypeToNullOnScheduleAttribute");
        public static readonly IClrTypeName SharedStatic = new ClrTypeName("Unity.Burst.SharedStatic`1");

        //Custom attributes
        public static readonly IClrTypeName AssetPathAttribute = new ClrTypeName("JetBrains.Annotations.AssetPathAttribute");
        
        
        // Jobs
        public static readonly IClrTypeName LambdaSingleJobDescriptionConstructionMethods = new ClrTypeName("Unity.Entities.LambdaSingleJobDescriptionConstructionMethods");
        public static readonly IClrTypeName LambdaForEachDescriptionConstructionMethods = new ClrTypeName("Unity.Entities.LambdaForEachDescriptionConstructionMethods");
        public static readonly IClrTypeName LambdaJobDescriptionConstructionMethods = new ClrTypeName("Unity.Entities.LambdaJobDescriptionConstructionMethods");
        // public static readonly IClrTypeName Job = new ClrTypeName("Unity.Jobs.IJob");
        // public static readonly IClrTypeName JobFor = new ClrTypeName("Unity.Jobs.IJobFor");
        // public static readonly IClrTypeName JobParallelFor = new ClrTypeName("Unity.Jobs.IJobParallelFor");
        // public static readonly IClrTypeName AnimationJob = new ClrTypeName("UnityEngine.Animations.IAnimationJob");
        // public static readonly IClrTypeName JobParallelForTransform = new ClrTypeName("UnityEngine.Jobs.IJobParallelForTransform");
        // public static readonly IClrTypeName JobParticleSystem = new ClrTypeName("UnityEngine.ParticleSystemJobs.IJobParticleSystem");
        // public static readonly IClrTypeName JobParticleSystemParallelFor = new ClrTypeName("UnityEngine.ParticleSystemJobs.IJobParticleSystemParallelFor");
        // public static readonly IClrTypeName JobParticleSystemParallelForBatch = new ClrTypeName("UnityEngine.ParticleSystemJobs.IJobParticleSystemParallelForBatch");
        
        //Unity.Collections
        
        //  UnityEngine.UIElements
        public static readonly IClrTypeName UQueryExtensions = new ClrTypeName("UnityEngine.UIElements.UQueryExtensions");
   
        //Obsolete types
        public static readonly ClrTypeName FixedString32 = new("Unity.Collections.FixedString32");
        public static readonly ClrTypeName FixedString64 = new("Unity.Collections.FixedString64");
        public static readonly ClrTypeName FixedString128 = new("Unity.Collections.FixedString128");
        public static readonly ClrTypeName FixedString512 = new("Unity.Collections.FixedString512");
        public static readonly ClrTypeName FixedString4096 = new("Unity.Collections.FixedString4096");
        
        public static readonly ClrTypeName FixedString32Bytes = new("Unity.Collections.FixedString32Bytes");
        public static readonly ClrTypeName FixedString64Bytes = new("Unity.Collections.FixedString64Bytes");
        public static readonly ClrTypeName FixedString128Bytes = new("Unity.Collections.FixedString128Bytes");
        public static readonly ClrTypeName FixedString512Bytes = new("Unity.Collections.FixedString512Bytes");
        public static readonly ClrTypeName FixedString4096Bytes = new("Unity.Collections.FixedString4096Bytes");
    }
}