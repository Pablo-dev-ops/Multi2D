using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class Conection : MonoBehaviourPunCallbacks
{
    public TextMeshProUGUI texto;
    public Button botonConectar, botonUnirseASala;

    // Start is called before the first frame update
    void Start()
    {
        texto.text = ("Bienvenido");
        botonUnirseASala.gameObject.SetActive(false);
    }
    void Update()
    { 

    }
    override
    public void OnConnectedToMaster()
    {
        print("Conecatado al master");
        botonConectar.gameObject.SetActive(false);
        texto.text = ("Conectado");
        botonUnirseASala.gameObject.SetActive(true);
    }
    public void ButtonConnect()
    {
        botonConectar.gameObject.SetActive(false);
        texto.text = ("Conectando al servidor, por favor espere...");
        PhotonNetwork.ConnectUsingSettings();
    }
    public void ButtonUnirseASala()
    {
            RoomOptions options = new RoomOptions() { MaxPlayers = 4 };

            PhotonNetwork.JoinOrCreateRoom("room1", options, TypedLobby.Default);       
    }
    override
    public void OnJoinedRoom()
    {
        texto.text = ("Conexion a sala " + PhotonNetwork.CurrentRoom.Name + " hay " + PhotonNetwork.CurrentRoom.PlayerCount + " jugadores conectados");
    }
}
