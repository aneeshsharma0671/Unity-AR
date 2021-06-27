using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSize : MonoBehaviour
{
    public Slider Size_slider;

    public void Awake()
    {
        Size_slider = GameObject.Find("Panel").transform.Find("Slider").GetComponent<Slider>();
    }

    public void Start()
    {
        gameObject.transform.localScale = new Vector3(0.1f,0.1f,0.1f);
    }
    public void Update()
    {
     
        Vector3 Size = new Vector3(Size_slider.value, Size_slider.value, Size_slider.value);
        gameObject.transform.localScale = Size;
    }
    public void enableSlider()
    {
        Size_slider.gameObject.SetActive(true);

    }
    public void disableSlider()
    {
        Size_slider.gameObject.SetActive(false);
    }
    
}
