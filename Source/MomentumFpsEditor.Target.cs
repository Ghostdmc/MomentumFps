// Copyright Ghostdmc

using UnrealBuildTool;
using System.Collections.Generic;

public class MomentumFpsEditorTarget : TargetRules
{
	public MomentumFpsEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V7;

		ExtraModuleNames.AddRange( new string[] { "MomentumFps" } );
	}
}
