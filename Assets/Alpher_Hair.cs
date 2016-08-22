using UnityEngine;
using System.Collections;

public class Alpher_Hair : MonoBehaviour {
    float r;
    float g;
    float b;
    float a;

    int flag = 0;
    // Use this for initialization
    void Start()
    {
        r = GetComponent<Renderer>().material.color.r;
        g = GetComponent<Renderer>().material.color.g;
        b = GetComponent<Renderer>().material.color.b;
        a = GetComponent<Renderer>().material.color.a;
    }

    // Update is called once per frame
    void Update()
    {
        if (flag == 0)
        {
            GetComponent<Renderer>().material.shader = Shader.Find("UnityChan/Hair");
            GetComponent<Renderer>().material.color = new Color(r, g, b, a);
        }
        else if (flag == 1)
        {
            GetComponent<Renderer>().material.shader = Shader.Find("UnityChan/Skin - Transparent");
            GetComponent<Renderer>().material.color = new Color(r, g, b, 0.1f);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (flag == 0)
            {
                flag = 1;
            }
            else if (flag == 1)
            {
                flag = 0;
            }
        }
    }
}
