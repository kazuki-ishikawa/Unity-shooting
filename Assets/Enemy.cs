using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public int HP;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (HP<0)
        {
            Object.Destroy(this.gameObject);
        }
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("pb"))
        {
            HP--;
        }
    }
}
