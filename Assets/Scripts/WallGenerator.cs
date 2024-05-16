using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGenerator : MonoBehaviour
{
    public Wall _wallPrefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // キーボードの[P]を入力したとき
        if(Input.GetKeyDown(KeyCode.P))
        {
            Instantiate(_wallPrefab,transform);
        }
    }
}
