using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PhotonManager : MonoBehaviourPunCallbacks
{



    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    


    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
       // base.OnConnectedToMaster();
    }

    public override void OnJoinedLobby()
    {
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions { MaxPlayers = 8 }, TypedLobby.Default);
      //  base.OnJoinedLobby();
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.Instantiate("Player", new Vector2(Random.Range(-10, 10), gameObject.transform.position.y), Quaternion.identity);
        //base.OnJoinedRoom();
    }
}
