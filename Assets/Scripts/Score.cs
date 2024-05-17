using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TextMeshProを使用する際に必要なUsing
using TMPro;


public class Score : MonoBehaviour
{
    /// <summary>
    /// TMPコンポーネント
    /// </summary>
    public TMP_Text _text;

    /// <summary>
    /// スコア文字列
    /// </summary>
    private string _scoreText = "score : ";

    /// <summary>
    /// スコアをカウントアップしていく変数
    /// </summary>
    private int _score = 0;

    /// <summary>
    /// スコアを加算させる処理
    /// </summary>
    public void ScoreUp()
    {
        _score++;
        ScoreTextUpdate();
    }

    /// <summary>
    /// 表示されているスコアを更新する処理
    /// </summary>
    private void ScoreTextUpdate()
    {
        _text.text = _scoreText + _score;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.U))
        {
            ScoreUp();
        }

    }
}
