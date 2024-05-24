using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeImage : MonoBehaviour
{
    public GameObject chupcha1;
    public GameObject chupcha2;
    public Sprite[] spriteArray;
    public GameObject ImageHolder;

    public void showWhite(bool value)
    {
        white.SetActive(value);
    }

    public void showBlack(bool value)
    {
        black.SetActive(value);
    }
    public void changeImages(int index)
    {
        if (index == 0)
            ImageHolder.GetComponent<Image>().sprite = spriteArray[0];
        else(index == 1)
            ImageHolder.GetComponent<Image>().sprite = spriteArray[1];
    }
}
