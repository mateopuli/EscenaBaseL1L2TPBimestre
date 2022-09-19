using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "LUZDataSO", menuName = "LUZ Data")]
public class LUZData : ScriptableObject
{
    public string[] LUZFrases;
    public bool hasTalked;
}
