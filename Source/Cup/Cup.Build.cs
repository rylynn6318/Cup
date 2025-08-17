// Copyright rylynn6318. All rights reserved.

using UnrealBuildTool;

public class Cup : ModuleRules
{
	public Cup(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicIncludePaths.AddRange(new string[] {
			"Cup",
		});

        PublicDependencyModuleNames.AddRange(new string[] { 
			"Core", 
			"CoreUObject",
			"Engine", 
			"InputCore",
		});

		PrivateDependencyModuleNames.AddRange(new string[] {
			"CommonUI",
			"Slate",
			"SlateCore",
			"UMG",
        });
	}
}
