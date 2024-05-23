using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    /// <summary>
    /// 自分のレクとトランスフォーム
    /// </summary>
    private RectTransform _rectTransform;

    /// <summary>
    /// デストロイするポジションを示すトランスフォームを指定する
    /// </summary>
    public RectTransform _destroyPosition;

    /// <summary>
    /// 左に移動する速さ
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
        // 左に進む処理
        var pos = _rectTransform.localPosition;
        pos.x += -_velocity * Time.deltaTime;

        _rectTransform.localPosition = pos;


        // 画面左に進んだらDestroy(削除)する
        if (pos.x < _destroyPosition.localPosition.x)
        {
            Destroy(gameObject);
        }
    }
}
