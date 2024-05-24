using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UI;

public class ShowText : MonoBehaviour
{
    int gads;
    int vecums;
    string vards;
    public InputField name;
    public InputField age;
    public GameObject displayField;

    public void getText()
    {
        vards = name.text;
        gads = int.Parse(age.text);
        vecums = 2024 - gads;
            displayField.GetComponent<Text>().text =
                "Supervaronis " + vards + " ir " + vecums + " gadu vecs!";
       
    }
}
