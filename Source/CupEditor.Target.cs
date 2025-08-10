// Copyright 2025 rylynn6318. All rights reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class CupEditorTarget : TargetRules
{
	public CupEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "Cup" } );
        IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_6;
    }
}
