using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Script : MonoBehaviour
{   
    public int speed = 10;
    private GameObject Player;
    private Rigidbody Rigidbody_Player;
    private Vector3 Player_pos;
    private Vector3 Cam_pos;
    private GameObject cam;
    private float player_pos_z;
    public int offset;

    void Start()
    {
        Player = GameObject.Find("Player");
        Rigidbody_Player = Player.GetComponent<Rigidbody>();

        player_pos_z =(float) Player_pos.z;

        cam = GameObject.Find("Main Camera");
        Cam_pos = cam.transform.position;

        Player_pos = Player.transform.position;
    }

    void FixedUpdate()
    {
        Rigidbody_Player.AddForce(new Vector3(0,0,-speed));
        cam.transform.position =new Vector3(Cam_pos.x,Cam_pos.y,(player_pos_z));        
    }

    public void addforce(){
        
    }
}
