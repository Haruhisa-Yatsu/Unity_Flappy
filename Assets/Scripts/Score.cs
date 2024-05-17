using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TextMeshPro���g�p����ۂɕK�v��Using
using TMPro;


public class Score : MonoBehaviour
{
    /// <summary>
    /// TMP�R���|�[�l���g
    /// </summary>
    public TMP_Text _text;

    /// <summary>
    /// �X�R�A������
    /// </summary>
    private string _scoreText = "score : ";

    /// <summary>
    /// �X�R�A���J�E���g�A�b�v���Ă����ϐ�
    /// </summary>
    private int _score = 0;

    /// <summary>
    /// �X�R�A�����Z�����鏈��
    /// </summary>
    public void ScoreUp()
    {
        _score++;
        ScoreTextUpdate();
    }

    /// <summary>
    /// �\������Ă���X�R�A���X�V���鏈��
    /// </summary>
    private void ScoreTextUpdate()
    {
        _text.text = _scoreText + _score;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.U))
        {
            ScoreUp();
        }

    }
}
