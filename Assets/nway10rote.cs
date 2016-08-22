using UnityEngine;
using System.Collections;

public class nway10rote : MonoBehaviour {

    //縦way数
    public int way;

    public int rad;

    public int rote;

    public int span;


    // bullet prefab
    public GameObject bullet;

    public Transform Player;

    // 弾丸発射点
    public Transform muzzle;

    // 弾丸の速度
    public float speed;


    int count=0;
    int flag = 0;

    // Use this for initialization
    void Start ()
    {
        transform.LookAt(Player.position);
        transform.Rotate(new Vector3(0, rad * (int)(way/2), 0));

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (count % span == 0)
        {
            for (int x = 0; x < way; x++)
            {
                if(x==way/2) transform.Rotate(new Vector3(0, 0, rote));
                // 弾丸の複製
                GameObject bullets1 = GameObject.Instantiate(bullet, muzzle.position, Quaternion.identity) as GameObject;
                // 弾丸の位置を調整
                bullets1.transform.position = muzzle.position;
                // Rigidbodyに力を加えて発射
                bullets1.GetComponent<Rigidbody>().AddForce(this.gameObject.transform.forward * speed);
                transform.Rotate(new Vector3(0, -rad, 0));
            }
            transform.Rotate(new Vector3(0, rad * way , 0));
        }
        if (count > 340)
        {
            transform.LookAt(Player.position);
            transform.Rotate(new Vector3(0, rad * (int)(way / 2), 0));
            count = 0;
        }
        count++;
    }
}
