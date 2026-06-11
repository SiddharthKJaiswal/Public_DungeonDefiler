// Copyright Siddharth Jaiswal

using UnrealBuildTool;
using System.Collections.Generic;

public class MazeRunnerEditorTarget : TargetRules
{
	public MazeRunnerEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.Latest;

		ExtraModuleNames.AddRange( new string[] { "MazeRunner" } );
	}
}
