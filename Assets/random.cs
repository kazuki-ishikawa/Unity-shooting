using UnityEngine;
using System.Collections;

public class random : MonoBehaviour {

    // bullet prefab
    public GameObject bullet;

    // 弾丸発射点
    public Transform muzzle;

    public Transform Player;

    public float speed;

    // Use this for initialization
    void Start () {
	
	}
    int count = 0;
	// Update is called once per frame
	void Update () {
        if (count % 2 == 0)
        {
            transform.LookAt(Player.position);

            // 弾丸の複製
            GameObject bullets2 = GameObject.Instantiate(bullet, muzzle.position, Quaternion.identity) as GameObject;
            // 弾丸の位置を調整
            bullets2.transform.position = muzzle.position;
            // Rigidbodyに力を加えて発射
            bullets2.GetComponent<Rigidbody>().AddForce(this.gameObject.transform.forward * speed);
            
        }
        count++;
    }
}
