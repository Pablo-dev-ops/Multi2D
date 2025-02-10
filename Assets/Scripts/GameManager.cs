using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         if (PhotonNetwork.IsMasterClient)
                    PhotonNetwork.Instantiate ("Frog", new Vector3(0f, -3f, 0f), Quaternion.identity);
         else
                  PhotonNetwork.Instantiate ("Frog", new Vector3(15f, -3f, 0f), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
