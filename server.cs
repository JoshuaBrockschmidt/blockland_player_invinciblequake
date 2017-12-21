if(ForceRequiredAddOn("Player_Quake") == $Error::AddOn_NotFound) {
	error("Player_Quake could not be loaded! Invincible Quake-Like Player will not be loaded");
	return $Error::AddOn_NotFound;
}
exec("./Player_InvincibleQuake.cs");

// Thanks to Jetz (BLID: 3673) for the script.
// Original code from Demian's Player_Invincible add-on.
package AllowInvincibleQuakeSuicide
{
	function serverCmdSuicide(%client) {
		if(%client.player.getDatablock() == PlayerInvincibleQuake.getID())
			%client.player.setDatablock(PlayerStandardArmor);
		Parent::ServerCmdSuicide(%client);
	}
};
activatePackage(AllowInvincibleQuakeSuicide);
