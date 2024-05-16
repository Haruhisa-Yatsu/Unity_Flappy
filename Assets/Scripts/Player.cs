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


    /// <summary>
    /// ����
    /// </summary>
    public float _velocity = 0.0f;

    /// <summary>
    /// �W�����v��
    /// </summary>
    public float _jump = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        _rectTransform = GetComponent<RectTransform>();

    }

    // Update is called once per frame
    void Update()
    {
        // 1/60 �b
        _velocity += 9.80665f * Time.deltaTime;


        // ���N���b�N����͂����� True
        if (Input.GetMouseButtonDown(0))
        {
            _velocity = -_jump;
        }

        // �ړ�����
        var position = _rectTransform.position;

        position += new Vector3(0, -_velocity, 0);


        if(position.y > 720.0f)
        {
            position.y = 720.0f;
            _velocity = 0.0f;
        }

        if(position.y < -100)
        {
            GameOver();
        }

        _rectTransform.position = position;
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
        GameOver();
    }

}
