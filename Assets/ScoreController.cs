using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoarContl : MonoBehaviour
{

    //�X�R�A�ϐ��̏�����
    private int score = 0;
    //�X�R�A��\������e�L�X�g
    private GameObject ScoreText;


    // Start is called before the first frame update
    void Start()
    {
        //�V�[������ScoreText�I�u�W�F�N�g���擾
        this.ScoreText = GameObject.Find("ScoreText");
    }


    // Update is called once per frame
    void Update()
    {
 
    }


}
