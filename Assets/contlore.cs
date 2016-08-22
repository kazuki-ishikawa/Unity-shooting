using UnityEngine;
using System.Collections;

public class contlore : MonoBehaviour
{

    private Animator animator;
    float speed = 0.1f;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public int count = 0;
    //transform.Rotate(new Vector3(0,-1,0));
   
    // Update is called once per frame
    void Update()
    {
        //待機に移行
        animator.SetBool("on", false);
        //シフトの場合低速
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = speed / 2;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = speed * 2;
        }

        //移動関数
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * speed;
            animator.SetBool("on", true);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * speed;
            animator.SetBool("on", true);
        }
        if ( Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += transform.right * -speed;
            animator.SetBool("on", true);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += transform.forward * -speed;
            animator.SetBool("on", true);
        }
        //////////////////////////////////////////////////////////

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += transform.up * speed;
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.position -= transform.up * speed;
        }
        
    }
}

//初期データ

//if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.D))
//{
//    transform.position += transform.right * speed;
//    animator.SetBool("on", true);
//}
//else if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.A))
//{
//    transform.position += transform.right * -speed;
//    animator.SetBool("on", true);
//}
//else if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.S))
//{
//    transform.position += transform.forward * -speed;
//    animator.SetBool("on", true);
//}
//else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
//{
//    transform.position += transform.forward * speed;
//    animator.SetBool("on", true);
//    if (count == 2)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 45);
//        count = 1;
//    }
//    else if (count == 3)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 90);
//        count = 1;
//    }
//    else if (count == 4)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 135);
//        count = 1;
//    }
//    else if (count == 5)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 180);
//        count = 1;
//    }
//    else if (count == 6)
//    {
//        transform.Rotate(new Vector3(0, 1, 0), 135);
//        count = 1;
//    }
//    else if (count == 7)
//    {
//        transform.Rotate(new Vector3(0, 1, 0), 90);
//        count = 1;
//    }
//    else if (count == 0)
//    {
//        transform.Rotate(new Vector3(0, 1, 0), 45);
//        count = 1;
//    }
//}
//else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
//{
//    transform.position += transform.forward * speed;
//    animator.SetBool("on", true);
//    if (count == 4)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 45);
//        count = 3;
//    }
//    else if (count == 5)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 90);
//        count = 3;
//    }
//    else if (count == 6)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 135);
//        count = 3;
//    }
//    else if (count == 7)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 180);
//        count = 3;
//    }
//    else if (count == 0)
//    {
//        transform.Rotate(new Vector3(0, 1, 0), 135);
//        count = 3;
//    }
//    else if (count == 1)
//    {
//        transform.Rotate(new Vector3(0, 1, 0), 90);
//        count = 3;
//    }
//    else if (count == 2)
//    {
//        transform.Rotate(new Vector3(0, 1, 0), 45);
//        count = 3;
//    }
//}
//else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
//{
//    transform.position += transform.forward * speed;
//    animator.SetBool("on", true);
//    if (count == 6)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 45);
//        count = 5;
//    }
//    else if (count == 7)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 90);
//        count = 5;
//    }
//    else if (count == 0)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 135);
//        count = 5;
//    }
//    else if (count == 1)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 180);
//        count = 5;
//    }
//    else if (count == 2)
//    {
//        transform.Rotate(new Vector3(0, 1, 0), 135);
//        count = 5;
//    }
//    else if (count == 3)
//    {
//        transform.Rotate(new Vector3(0, 1, 0), 90);
//        count = 5;
//    }
//    else if (count == 4)
//    {
//        transform.Rotate(new Vector3(0, 1, 0), 45);
//        count = 5;
//    }
//}
//else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
//{
//    transform.position += transform.forward * speed;
//    animator.SetBool("on", true);
//    if (count == 0)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 45);
//        count = 7;
//    }
//    else if (count == 1)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 90);
//        count = 7;
//    }
//    else if (count == 2)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 135);
//        count = 7;
//    }
//    else if (count == 3)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 180);
//        count = 7;
//    }
//    else if (count == 4)
//    {
//        transform.Rotate(new Vector3(0, 1, 0), 135);
//        count = 7;
//    }
//    else if (count == 5)
//    {
//        transform.Rotate(new Vector3(0, 1, 0), 90);
//        count = 7;
//    }
//    else if (count == 6)
//    {
//        transform.Rotate(new Vector3(0, 1, 0), 45);
//        count = 7;
//    }
//}
//else if (Input.GetKey(KeyCode.W))
//{
//    transform.position += transform.forward * speed;
//    animator.SetBool("on", true);
//    if (count == 1)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 45);
//        count = 0;
//    }
//    else if (count == 2)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 90);
//        count = 0;
//    }
//    else if (count == 3)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 135);
//        count = 0;
//    }
//    else if (count == 4)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 180);
//        count = 0;
//    }
//    else if (count == 5)
//    {
//        transform.Rotate(new Vector3(0, 1, 0), 135);
//        count = 0;
//    }
//    else if (count == 6)
//    {
//        transform.Rotate(new Vector3(0, 1, 0), 90);
//        count = 0;
//    }
//    else if (count == 7)
//    {
//        transform.Rotate(new Vector3(0, 1, 0), 45);
//        count = 0;
//    }
//    else if (count == 8)
//    {
//        count = 0;
//    }
//}
//else if (Input.GetKey(KeyCode.D))
//{
//    transform.position += transform.forward * speed;
//    animator.SetBool("on", true);
//    if (count == 3)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 45);
//        count = 2;
//    }
//    else if (count == 4)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 90);
//        count = 2;
//    }
//    else if (count == 5)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 135);
//        count = 2;
//    }
//    else if (count == 6)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 180);
//        count = 2;
//    }
//    else if (count == 7)
//    {
//        transform.Rotate(new Vector3(0, 1, 0), 135);
//        count = 2;
//    }
//    else if (count == 0)
//    {
//        transform.Rotate(new Vector3(0, 1, 0), 90);
//        count = 2;
//    }
//    else if (count == 1)
//    {
//        transform.Rotate(new Vector3(0, 1, 0), 45);
//        count = 2;
//    }
//}

//else if (Input.GetKey(KeyCode.A))
//{
//    transform.position += transform.forward * speed;
//    animator.SetBool("on", true);
//    if (count == 7)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 45);
//        count = 6;
//    }
//    else if (count == 0)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 90);
//        count = 6;
//    }
//    else if (count == 1)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 135);
//        count = 6;
//    }
//    else if (count == 2)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 180);
//        count = 6;
//    }
//    else if (count == 3)
//    {
//        transform.Rotate(new Vector3(0, 1, 0), 135);
//        count = 6;
//    }
//    else if (count == 4)
//    {
//        transform.Rotate(new Vector3(0, 1, 0), 90);
//        count = 6;
//    }
//    else if (count == 5)
//    {
//        transform.Rotate(new Vector3(0, 1, 0), 45);
//        count = 6;
//    }
//}
//else if (Input.GetKey(KeyCode.S))
//{
//    transform.position += transform.forward * speed;
//    animator.SetBool("on", true);
//    if (count == 5)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 45);
//        count = 4;
//    }
//    else if (count == 6)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 90);
//        count = 4;
//    }
//    else if (count == 7)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 135);
//        count = 4;
//    }
//    else if (count == 0)
//    {
//        transform.Rotate(new Vector3(0, -1, 0), 180);
//        count = 4;
//    }
//    else if (count == 1)
//    {
//        transform.Rotate(new Vector3(0, 1, 0), 135);
//        count = 4;
//    }
//    else if (count == 2)
//    {
//        transform.Rotate(new Vector3(0, 1, 0), 90);
//        count = 4;
//    }
//    else if (count == 3)
//    {
//        transform.Rotate(new Vector3(0, 1, 0), 45);
//        count = 4;
//    }
//}
