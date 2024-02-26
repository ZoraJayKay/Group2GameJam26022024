using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SlimeScriptableObject", order = 3)]
public class SlimeScriptableObject : ScriptableObject
{
    public string prefabName;
    public GameObject slimePrefab;
}
