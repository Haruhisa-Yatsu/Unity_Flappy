using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    /// <summary>
    /// 自分のレクとトランスフォーム
    /// </summary>
    private RectTransform _rectTransform;

    /// <summary>
    /// 左に移動する速さ
    /// </summary>
    public float _velocity = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        _velocity += Random.Range(0.5f, 0.5f);
        _rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        // 左に進む処理
        var pos = _rectTransform.position;
        pos.x += -_velocity * Time.deltaTime;

        _rectTransform.position = pos;


        // 画面左に進んだらDestroy(削除)する
        if (pos.x < -1000.0f)
        {
            Destroy(gameObject);
        }
    }
}
