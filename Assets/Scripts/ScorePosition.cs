using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePosition : MonoBehaviour {

    

    RectTransform rt;
    Vector2 startPos;

    void Start()
    {
        rt = GetComponent<RectTransform>();
        startPos = rt.anchoredPosition;
    }

    void Update()
    {
      

        rt.anchoredPosition = Vector2.Lerp(Vector2.zero, startPos, 100);
    }
}
