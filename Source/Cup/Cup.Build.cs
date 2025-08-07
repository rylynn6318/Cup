// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class Cup : ModuleRules
{
    public Cup(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicIncludePaths.AddRange(new string[]
        {
            "Cup"
        });

        PublicDependencyModuleNames.AddRange(new string[]
        {
            "Core",
            "CoreUObject",
            "Engine",
            "InputCore"
        });

        PrivateDependencyModuleNames.AddRange(new string[]
        {
            "Slate",
            "SlateCore",
            "CommonUI",
            "CommonGame",
            "UMG",
        });
    }
}
