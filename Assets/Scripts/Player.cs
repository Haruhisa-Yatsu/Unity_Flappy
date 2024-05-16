using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Player : MonoBehaviour
{
    /// <summary>
    /// レクトトランスフォーム
    /// </summary>
    private RectTransform _rectTransform;


    /// <summary>
    /// 速さ
    /// </summary>
    public float _velocity = 0.0f;

    /// <summary>
    /// ジャンプ力
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
        // 1/60 秒
        _velocity += 9.80665f * Time.deltaTime;


        // 左クリックを入力した時 True
        if (Input.GetMouseButtonDown(0))
        {
            _velocity = -_jump;
        }

        // 移動処理
        var position = _rectTransform.position;

        position += new Vector3(0, -_velocity, 0);

        // ここからの箇所は確認をしやすくするためのコードなので
        // 特に写さなくて大丈夫です
        if(position.y < 0)
        {
            position.y = 0;
        }
        // ----ここまで

        _rectTransform.position = position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("壁に当たったよ");
    }

}
