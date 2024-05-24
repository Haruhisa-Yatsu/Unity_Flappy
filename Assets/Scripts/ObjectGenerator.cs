using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGenerator : MonoBehaviour
{
    public GameObject _wallPrefab;

    /// <summary>
    /// �������o�̃J�E���^
    /// </summary>
    private float _generateCounter;

    /// <summary>
    /// �ǂ̐����Ԋu�i�b�j
    /// </summary>
    public float _generateSecond = 1.0f;

    /// <summary>
    /// �ǃI�u�W�F�N�g�������ɏ㉺�ɂ��炷�ő�l
    /// </summary>
    public float _maxShift = 100.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // �P�b�Ł@_generateCounter����̂P������
        _generateCounter += Time.deltaTime;

        // �L�[�{�[�h��[P]����͂����Ƃ�
        if (_generateCounter > _generateSecond)
        {
            _generateCounter -= _generateSecond;
            var wall = Instantiate(_wallPrefab, transform);

            var pos = wall.transform.localPosition;
            pos.y += Random.Range(-1.0f, 1.0f) * _maxShift;
            wall.transform.localPosition = pos;

        }
    }
}
