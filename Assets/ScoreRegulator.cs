using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class ScoreRegulator : MonoBehaviour
{
    //�ϐ��̐錾
    private int point;
    //�X�R�A��\������e�L�X�g
    private GameObject BallObject;


    // Start is called before the first frame update
    void Start()
    {
        //�^�O�ɂ���Ď擾�|�C���g��ς���
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


    //�Փˎ��ɌĂ΂��֐�
    private void OnCollisionEnter(Collision other)
    {
        //�|�C���g�����Z����
        this.BallObject.GetComponent<ScoreController>().score += point;
    }
}
