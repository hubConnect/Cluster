using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class ShipNetManager : NetworkManager 
{

	public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
	{
		Vector3 pos = Vector3.zero;
		pos.y += (conn.connectionId % 8)*2;
		pos.x += ((conn.connectionId / 4)*4);
		
		GameObject thePlayer = (GameObject)Instantiate(base.playerPrefab, pos, Quaternion.identity);
		ShipCombat tc = thePlayer.GetComponent<ShipCombat>();
		tc.InitializeFromShipType(ShipTypeManager.Random());
		
		NetworkServer.AddPlayerForConnection(conn, thePlayer, playerControllerId);
	}
}
