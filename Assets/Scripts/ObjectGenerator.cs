using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGenerator : MonoBehaviour
{
    public GameObject _wallPrefab;

    /// <summary>
    /// 生成感覚のカウンタ
    /// </summary>
    private float _generateCounter;

    /// <summary>
    /// 壁の生成間隔（秒）
    /// </summary>
    public float _generateSecond = 1.0f;

    /// <summary>
    /// 壁オブジェクト生成時に上下にずらす最大値
    /// </summary>
    public float _maxShift = 100.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // １秒で　_generateCounterが大体１増える
        _generateCounter += Time.deltaTime;

        // キーボードの[P]を入力したとき
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
