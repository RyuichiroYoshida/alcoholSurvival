using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "MyGame / Create ParameterTable")]
public class ParameterTable : ScriptableObject
{
    [SerializeField] string testString = "test�ł�";

    public string _TestString {get { return testString; } }
}