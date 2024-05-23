using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    /// <summary>
    /// レクトトランスフォーム
    /// </summary>
    private RectTransform _rectTransform;

    public float _gravity;

    /// <summary>
    /// 速さ
    /// </summary>
    public float _velocity = 0.0f;

    /// <summary>
    /// ジャンプ力
    /// </summary>
    public float _jump = 2.0f;

    /// <summary>
    /// スコアクラス
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
        // 1/60 秒
        _velocity += _gravity * Time.deltaTime;


        // 左クリックを入力した時 True
        if (Input.GetMouseButtonDown(0))
        {
            _velocity = -_jump;
        }

        // 移動処理
        var position = _rectTransform.localPosition;
        position += new Vector3(0, -_velocity, 0) * Time.deltaTime;

        // 天井に頭をぶつけた時の処理
        if(position.y > 360.0f)
        {
            position.y = 360.0f;
            _velocity = 0.0f;
        }

        // 落下したときの処理
        if(position.y < -460.0f)
        {
            GameOver();
        }

        _rectTransform.localPosition = position;
    }

    /// <summary>
    /// ゲームオーバーの処理をまとめる
    /// </summary>
    private void GameOver()
    {
        SceneManager.LoadScene("Title");

        Debug.Log("壁に当たったよ");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // "Wall"タグを持ったオブジェクトのTriggerに衝突したら
        if (collision.CompareTag("Wall"))
        {
            GameOver();
        }

        // "ScoreUp"タグを持ったオブジェクトのTriggerに衝突したら
        if (collision.CompareTag("ScoreUp"))
        {
            _score.ScoreUp();
        }
    }
}
