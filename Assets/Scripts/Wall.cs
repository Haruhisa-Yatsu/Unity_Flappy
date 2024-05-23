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
    /// �f�X�g���C����|�W�V�����������g�����X�t�H�[�����w�肷��
    /// </summary>
    public RectTransform _destroyPosition;

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
        var pos = _rectTransform.localPosition;
        pos.x += -_velocity * Time.deltaTime;

        _rectTransform.localPosition = pos;


        // ��ʍ��ɐi�񂾂�Destroy(�폜)����
        if (pos.x < _destroyPosition.localPosition.x)
        {
            Destroy(gameObject);
        }
    }
}
