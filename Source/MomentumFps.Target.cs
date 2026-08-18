// Copyright Ghostdmc

using UnrealBuildTool;
using System.Collections.Generic;

public class MomentumFpsTarget : TargetRules
{
	public MomentumFpsTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V7;

		ExtraModuleNames.AddRange( new string[] { "MomentumFps" } );
	}
}
