using UnityEngine;
using System.Collections;

public class drop : MonoBehaviour {
    
    // bullet prefab
    public GameObject bullet;

    // 弾丸発射点
    public Transform muzzle;

    // 弾丸の速度
    public float speed = 1000;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    int count = 0;
    void OnCollisionStay(Collision col)
    {
        
        if (col.gameObject.CompareTag("Player") && count%5==0)
        {
            // 弾丸の複製
            GameObject bullets = GameObject.Instantiate(bullet) as GameObject;

            // Rigidbodyに力を加えて発射
            bullets.GetComponent<Rigidbody>().AddForce(0, -5, 0);
            // 弾丸の位置を調整
            bullets.transform.position = muzzle.position;
        }
        count++;
    }
}
