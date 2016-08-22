using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {


    GameObject Player;
    GameObject mainCamera;
    public float posission_x = 0;
    public float posission_y = 0;
    public float posission_z = 0;
    public float rotat_x = 0;
    public float rotat_y = 180;
    public float rotat_z = 0;
    // Use this for initialization
    void Start ()
    {
        Player = GameObject.Find("unitychan");
        mainCamera = GameObject.Find("MC");
    }
	
    int flag = 0;
	// Update is called once per frame
	void Update ()
    {
            mainCamera.transform.position =
                new Vector3(
                    Player.transform.position.x + posission_x,
                    Player.transform.position.y + posission_y,
                    Player.transform.position.z + posission_z
                    );


        if (Input.GetKeyDown(KeyCode.L))
        {

            posission_x = 0;
            posission_y = 1;
            posission_z = 3;
            mainCamera.transform.Rotate(new Vector3(rotat_x, rotat_y, rotat_z));

        }
        if (Input.GetKeyUp(KeyCode.L))
        {
            posission_x = 0;
            posission_y = 1;
            posission_z = -3;
            mainCamera.transform.Rotate(new Vector3(rotat_x, -rotat_y, rotat_z));

        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            mainCamera.transform.Rotate(new Vector3(1, 0, 0), 30);
        }
        if (Input.GetKeyUp(KeyCode.U))
        {
            mainCamera.transform.Rotate(new Vector3(-1, 0, 0), 30);
        }

    }
}
