using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    /// <summary>
    /// �����̃��N�ƃg�����X�t�H�[��
    /// </summary>
    private RectTransform _rectTransform;

    /// <summary>
    /// ���Ɉړ����鑬��
    /// </summary>
    public float _velocity = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        // ���ɐi�ޏ���
        var pos = _rectTransform.position;
        pos.x += -_velocity * Time.deltaTime;

        _rectTransform.position = pos;


        // ��ʍ��ɐi�񂾂�Destroy(�폜)����
        if (pos.x < -100.0f)
        {
            Destroy(gameObject);
        }
    }
}
