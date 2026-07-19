// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GASSystem : ModuleRules
{
	public GASSystem(ReadOnlyTargetRules Target) : base(Target)
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
			"GASSystem",
			"GASSystem/Variant_Platforming",
			"GASSystem/Variant_Platforming/Animation",
			"GASSystem/Variant_Combat",
			"GASSystem/Variant_Combat/AI",
			"GASSystem/Variant_Combat/Animation",
			"GASSystem/Variant_Combat/Gameplay",
			"GASSystem/Variant_Combat/Interfaces",
			"GASSystem/Variant_Combat/UI",
			"GASSystem/Variant_SideScrolling",
			"GASSystem/Variant_SideScrolling/AI",
			"GASSystem/Variant_SideScrolling/Gameplay",
			"GASSystem/Variant_SideScrolling/Interfaces",
			"GASSystem/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
