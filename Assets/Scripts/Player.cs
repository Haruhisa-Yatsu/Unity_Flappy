using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    /// <summary>
    /// ���N�g�g�����X�t�H�[��
    /// </summary>
    private RectTransform _rectTransform;

    public float _gravity;

    /// <summary>
    /// ����
    /// </summary>
    public float _velocity = 0.0f;

    /// <summary>
    /// �W�����v��
    /// </summary>
    public float _jump = 2.0f;

    /// <summary>
    /// �X�R�A�N���X
    /// </summary>
    public Score _score;


    // Start is called before the first frame update
    void Start()
    {
        _rectTransform = GetComponent<RectTransform>();

    }

    // Update is called once per frame
    void Update()
    {
        // 1/60 �b
        _velocity += _gravity * Time.deltaTime;


        // ���N���b�N����͂����� True
        if (Input.GetMouseButtonDown(0))
        {
            _velocity = -_jump;
        }

        // �ړ�����
        var position = _rectTransform.localPosition;
        position += new Vector3(0, -_velocity, 0) * Time.deltaTime;

        // �V��ɓ����Ԃ������̏���
        if(position.y > 360.0f)
        {
            position.y = 360.0f;
            _velocity = 0.0f;
        }

        // ���������Ƃ��̏���
        if(position.y < -460.0f)
        {
            GameOver();
        }

        _rectTransform.localPosition = position;
    }

    /// <summary>
    /// �Q�[���I�[�o�[�̏������܂Ƃ߂�
    /// </summary>
    private void GameOver()
    {
        SceneManager.LoadScene("Title");

        Debug.Log("�ǂɓ���������");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // "Wall"�^�O���������I�u�W�F�N�g��Trigger�ɏՓ˂�����
        if (collision.CompareTag("Wall"))
        {
            GameOver();
        }

        // "ScoreUp"�^�O���������I�u�W�F�N�g��Trigger�ɏՓ˂�����
        if (collision.CompareTag("ScoreUp"))
        {
            _score.ScoreUp();
        }
    }
}
