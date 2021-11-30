using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject anchor_gameobject;
    public ModelsInfo modelsInfo;
    GameObject model;

    private void Awake()
    {
        model = modelsInfo.ModelsToDisplay[SceneInfo.ModelsIndex];
    }

    public void spawnobject()
    {
        GameObject a = Instantiate(model,anchor_gameobject.transform);
        a.transform.position = anchor_gameobject.transform.position;
        Debug.Log(a.transform.localPosition);
    }

}
