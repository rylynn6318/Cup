// Copyright rylynn6318. All rights reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class CupTarget : TargetRules
{
	public CupTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "Cup" } );
	}
}
