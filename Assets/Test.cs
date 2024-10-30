using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
        // 球の速度
          public float speed;
        //   private float speed2 = 0.1f;
          public int returnPoint;

    // Start is called before the first frame update
    void Start()
    {


        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
        // objectを前に移動する
        // transform.Translate(Vector3.forward * 0.1F);

        // back 後ろ(Z)/left 左/right 右/up 上(X)/down 下(Y)
        transform.Translate(Vector3.forward * speed);

        if(transform.position.z >= returnPoint)
        {
            speed = -speed;
        }
        Debug.Log("あ！！財布落とした！！");


    }
}
