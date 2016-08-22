using UnityEngine;
using System.Collections;

public class opsion_right : MonoBehaviour {

    // bullet prefab
    public GameObject bullet;

    // 弾丸発射点
    public Transform muzzle;

    public float speed;

    public float change_possition;
    int count = 0;

    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            transform.position += transform.right * change_possition;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            transform.position -= transform.right * change_possition;
        }

        if (Input.GetKey(KeyCode.Z))
        {
            if (count % 10 == 0)
            {
                transform.Rotate(new Vector3(0, -10, 0));
                // 弾丸の複製
                GameObject bullets1 = GameObject.Instantiate(bullet, muzzle.position, Quaternion.identity) as GameObject;
                // 弾丸の位置を調整
                bullets1.transform.position = muzzle.position;
                // Rigidbodyに力を加えて発射
                bullets1.GetComponent<Rigidbody>().AddForce(this.gameObject.transform.forward * speed);


                transform.Rotate(new Vector3(0, 10, 0));
                // 弾丸の複製
                GameObject bullets2 = GameObject.Instantiate(bullet, muzzle.position, Quaternion.identity) as GameObject;
                // 弾丸の位置を調整
                bullets2.transform.position = muzzle.position;
                // Rigidbodyに力を加えて発射
                bullets2.GetComponent<Rigidbody>().AddForce(this.gameObject.transform.forward * speed);



            }
        }

        count++;
    }
}
