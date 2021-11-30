using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SceneInfo", menuName = "ScriptableObjects/ModelsInfoScriptableObject", order = 1)]
public class ModelsInfo : ScriptableObject
{
    public List<GameObject> ModelsToDisplay;
}
