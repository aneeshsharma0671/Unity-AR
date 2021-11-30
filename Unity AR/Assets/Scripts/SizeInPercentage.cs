using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeInPercentage : MonoBehaviour
{
    public float widthInpercent;
    public float heightInpecent;
    RectTransform m_rect;
    public RectTransform Canvas_rect;

    private void Start()
    {
        m_rect = GetComponent<RectTransform>();

          m_rect.sizeDelta = new Vector2(widthInpercent*Canvas_rect.sizeDelta.x , heightInpecent*Canvas_rect.sizeDelta.y);
        Debug.Log(Canvas_rect.sizeDelta);
    }
}
