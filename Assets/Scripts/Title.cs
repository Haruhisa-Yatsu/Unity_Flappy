using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �V�[����ǂݍ��ޏ������g�p����̂ɕK�v��using
using UnityEngine.SceneManagement;


public class Title : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // ��������L�[���͂�������True��Ԃ��@����ȊO��False
        // Input.anyKeyDown
        if (Input.anyKeyDown)
        {
            // �V�[��"Game"��ǂݍ��ޏ���
            SceneManager.LoadScene("Game");
        }
    }
}
