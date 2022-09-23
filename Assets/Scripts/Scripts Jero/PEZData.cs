using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PEZDataSO", menuName = "PEZ Data")]
public class PEZData : ScriptableObject
{
    public string[] dialoguePEZ;
    public bool hasTalked;
}
