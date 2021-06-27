using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InfoManager : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public Dictionary<string, int> mapColliders = new Dictionary<string, int>();
    public Info[] items;
    private int index;
    public float typingSpeed = 0.02f;


    private void Start()
    {
        StartCoroutine(type());
        mapColliders.Add("skull", 1);
        mapColliders.Add("ribcage", 2);
        mapColliders.Add("spine", 3);
        mapColliders.Add("pelvis", 4);
        mapColliders.Add("limb", 5);

    }

    IEnumerator type()
    {
        foreach(char letter in items[index].sentence[0].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);

        }
    }

    public void updateSentence(string bodypart)
    {
        if(index < items.Length - 1)
        {
            index = mapColliders[bodypart];
            textDisplay.text = "";
            StartCoroutine(type());
        }
        else
        {
            textDisplay.text = "";
        }
    }
}
