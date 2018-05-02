using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;



namespace Prototype.NetworkLobby
{
    // Subclass this and redefine the function you want
    // then add it to the lobby prefab
    public class NameAndColor_Net : LobbyHook
    {
        public override void OnLobbyServerSceneLoadedForPlayer(NetworkManager manager, GameObject lobbyPlayer, GameObject gamePlayer) {
            LobbyPlayer lobby = lobbyPlayer.GetComponent<LobbyPlayer>();
            PlayerStats_Net player = gamePlayer.GetComponent<PlayerStats_Net>();
            player.color = lobby.playerColor;
            player.Pname = lobby.playerName;
        }
    }

}
