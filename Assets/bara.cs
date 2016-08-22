using UnityEngine;
using System.Collections;

public class bara : MonoBehaviour {

    public int bulet_num;

    public GameObject bullet;

    public Transform Player;

    public Transform muzzle;

    public int span;

    public int count;

    // 弾丸の速度
    public float speed;
    // Use this for initialization
    void Start ()
    {
        //transform.LookAt(Player.position);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (count % span == 0)
        {
            for (int x = 0; x < bulet_num; x++)
            {
                // 弾丸の複製
                GameObject bullets1 = GameObject.Instantiate(bullet, muzzle.position, Quaternion.identity) as GameObject;
                // 弾丸の位置を調整
                bullets1.transform.position = muzzle.position;
                // Rigidbodyに力を加えて発射
                bullets1.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-1.0f,1.0f), Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)) * speed);
            }
        }
        count++;

    }
}