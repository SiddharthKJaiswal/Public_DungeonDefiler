// Copyright Siddharth Jaiswal

using UnrealBuildTool;
using System.Collections.Generic;

public class MazeRunnerTarget : TargetRules
{
	public MazeRunnerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.Latest;

		ExtraModuleNames.AddRange( new string[] { "MazeRunner" } );
	}
}
