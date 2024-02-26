using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SlimeScriptableObject", order = 2)]
public class SlimeScriptableObject : MonoBehaviour
{
    public string prefabName;

    public int moveSpeed;
}
