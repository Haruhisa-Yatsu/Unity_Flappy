using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// シーンを読み込む処理を使用するのに必要なusing
using UnityEngine.SceneManagement;


public class Title : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // 何かしらキー入力をしたらTrueを返す　それ以外はFalse
        // Input.anyKeyDown
        if (Input.anyKeyDown)
        {
            // シーン"Game"を読み込む処理
            SceneManager.LoadScene("Game");
        }
    }
}
