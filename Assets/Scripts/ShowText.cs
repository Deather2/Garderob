using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UI;

public class ShowText : MonoBehaviour
{
    string text;
    string vards;
    public GameObject name;
    public GameObject age;
    public GameObject displayField;

    public void text()
    {
        vards = name.GetComponent<Text>().text;
        
    }
}
