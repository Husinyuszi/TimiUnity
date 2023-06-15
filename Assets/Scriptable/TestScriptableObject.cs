using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="TestSO",menuName ="MyGame/Something/TestSO")]
public class TestScriptableObject : ScriptableObject
{
    [SerializeField] Vector3 testVector;
    [SerializeField] List<string> testList;
    [SerializeField] GameObject testGameObject;
}
