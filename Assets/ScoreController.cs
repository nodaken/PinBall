using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreController : MonoBehaviour
{

    //スコア変数の初期化
    public int score = 0;
    //スコアを表示するテキスト
    private GameObject ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        //シーン中のScoreTextオブジェクトを取得
        this.ScoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        //スコアをTextに代入する
        this.ScoreText.GetComponent<Text>().text = score.ToString();
    }
}
