using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    public GameObject chupcha1;
    public GameObject chupcha2;
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;

    public void izkritosais(int skaitlis){
        if (skaitlis == 0){
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];
        } if (skaitlis == 1){
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];
        }
    }
}
