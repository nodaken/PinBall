using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class ScoreRegulator : MonoBehaviour
{
    //変数の宣言
    private int point;
    //スコアを表示するテキスト
    private GameObject BallObject;


    // Start is called before the first frame update
    void Start()
    {
        //タグによって取得ポイントを変える
        if (tag == "SmallStarTag")
        {
            this.point = 10;
        }
        else if (tag == "LargeStarTag")
        {
            this.point = 20;
        }
        else if (tag == "SmallCloudTag")
        {
            this.point = 40;
        }
        else if (tag == "LargeCloudTag")
        {
            this.point = 80;
        }

        Debug.Log(point);
        Debug.Log(tag);
        this.BallObject = GameObject.Find("Ball");

    }


    //衝突時に呼ばれる関数
    private void OnCollisionEnter(Collision other)
    {
        //ポイントを加算する
        this.BallObject.GetComponent<ScoreController>().score += point;
    }
}
