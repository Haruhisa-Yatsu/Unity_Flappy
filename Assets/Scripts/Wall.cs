using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private RectTransform _rectTransform;

    public float _velocity = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        var pos = _rectTransform.position;
        pos.x += -_velocity * Time.deltaTime;

        _rectTransform.position = pos;


        if (pos.x < -100.0f)
        {
            Destroy(gameObject);
        }
    }
}
