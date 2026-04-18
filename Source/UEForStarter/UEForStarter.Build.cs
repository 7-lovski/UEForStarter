// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UEForStarter : ModuleRules
{
	public UEForStarter(ReadOnlyTargetRules Target) : base(Target)
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
			"UEForStarter",
			"UEForStarter/Variant_Platforming",
			"UEForStarter/Variant_Platforming/Animation",
			"UEForStarter/Variant_Combat",
			"UEForStarter/Variant_Combat/AI",
			"UEForStarter/Variant_Combat/Animation",
			"UEForStarter/Variant_Combat/Gameplay",
			"UEForStarter/Variant_Combat/Interfaces",
			"UEForStarter/Variant_Combat/UI",
			"UEForStarter/Variant_SideScrolling",
			"UEForStarter/Variant_SideScrolling/AI",
			"UEForStarter/Variant_SideScrolling/Gameplay",
			"UEForStarter/Variant_SideScrolling/Interfaces",
			"UEForStarter/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
