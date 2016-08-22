using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public float speed;
	// Use this for initialization
	void Start ()
    {
        float r = GetComponent<Renderer>().material.color.r;
        float g = GetComponent<Renderer>().material.color.g;
        float b = GetComponent<Renderer>().material.color.b;
        float a = GetComponent<Renderer>().material.color.a;
        GetComponent<Renderer>().material.color = new Color(r, g, b, 0.4f);
    }

    // Update is called once per frame
    int count = 0;
    void Update ()
    {
        if (count > 180)
        {
            Object.Destroy(this.gameObject);
        }
        count++;
    }

    void OnCollisionEnter(Collision col)
    {
        Object.Destroy(this.gameObject);
    }
}
