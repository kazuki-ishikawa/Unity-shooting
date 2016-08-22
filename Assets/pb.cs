using UnityEngine;
using System.Collections;

public class pb : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        float r = GetComponent<Renderer>().material.color.r;
        float g = GetComponent<Renderer>().material.color.g;
        float b = GetComponent<Renderer>().material.color.b;
        float a = GetComponent<Renderer>().material.color.a;
        GetComponent<Renderer>().material.color = new Color(r, g, b, 0.4f);
    }

    // Update is called once per frame
    void Update()
    {
        if (count > 180)
        {
            Object.Destroy(this.gameObject);
        }
        count++;
    }
    int count = 0;
    void OnCollisionStay(Collision col)
    {
        
            Object.Destroy(this.gameObject);
    }
}
