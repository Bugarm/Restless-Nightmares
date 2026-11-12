// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class RestlessNightmare : ModuleRules
{
	public RestlessNightmare(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"RestlessNightmare",
			"RestlessNightmare/Variant_Platforming",
			"RestlessNightmare/Variant_Platforming/Animation",
			"RestlessNightmare/Variant_Combat",
			"RestlessNightmare/Variant_Combat/AI",
			"RestlessNightmare/Variant_Combat/Animation",
			"RestlessNightmare/Variant_Combat/Gameplay",
			"RestlessNightmare/Variant_Combat/Interfaces",
			"RestlessNightmare/Variant_Combat/UI",
			"RestlessNightmare/Variant_SideScrolling",
			"RestlessNightmare/Variant_SideScrolling/AI",
			"RestlessNightmare/Variant_SideScrolling/Gameplay",
			"RestlessNightmare/Variant_SideScrolling/Interfaces",
			"RestlessNightmare/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
