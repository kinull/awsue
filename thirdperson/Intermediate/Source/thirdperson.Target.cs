using UnrealBuildTool;

public class thirdpersonTarget : TargetRules
{
	public thirdpersonTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("thirdperson");
	}
}
