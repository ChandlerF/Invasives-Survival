using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerNetworking : MonoBehaviour
{


    public MonoBehaviour[] ScriptsToIgnore;

    private PhotonView PhotonView;

    void Start()
    {
        PhotonView = GetComponent<PhotonView>();
        if (!PhotonView.IsMine)
        {
            foreach(var script in ScriptsToIgnore)
            {
                script.enabled = false;
            }
        }
    }

}
