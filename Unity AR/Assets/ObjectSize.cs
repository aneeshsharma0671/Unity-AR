using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSize : MonoBehaviour
{
    public Slider Size_slider;

    public void Start()
    {
        Size_slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    private void Awake()
    {
        Size_slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    public void Update()
    {
        Vector3 Size = new Vector3(Size_slider.value, Size_slider.value, Size_slider.value);
        gameObject.transform.localScale = Size;
    }
}
