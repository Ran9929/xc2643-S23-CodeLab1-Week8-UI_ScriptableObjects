using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (
    fileName = "New Family Member",
    menuName = "ScriptableObjects/FamilyMember",
    order = 1
)]

public class FamilyScriptableObject : ScriptableObject
{
    public string name;

    public FamilyScriptableObject father;
    public FamilyScriptableObject son;
    public FamilyScriptableObject husband;
    public FamilyScriptableObject wife;
}
