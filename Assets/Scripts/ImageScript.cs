using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    public GameObject Krekli1;
    public GameObject Krekli2;
    public GameObject Krekli3;
    public GameObject Bikses1;
    public GameObject Bikses2;
    public GameObject Bikses3;
    public GameObject Apavi1;
    public GameObject Apavi2;
    public GameObject Apavi3;
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
   

    public void izkritosais(int skaitlis){
        if (skaitlis == 0){
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];
        } if (skaitlis == 1){
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];     
        }
    }

    public void showKrekli(bool value)
    {
        Krekli1.SetActive(value);
        Krekli2.SetActive(value);
        Krekli3.SetActive(value);
    }

    public void showBikses(bool value)
    {
        Bikses1.SetActive(value);
        Bikses2.SetActive(value);
        Bikses3.SetActive(value);
    }

    public void showApavi(bool value)
    {
        Apavi1.SetActive(value);
        Apavi2.SetActive(value);
        Apavi3.SetActive(value);
    }

    public Dropdown dropdown;
    public GameObject scrollView1;
    public GameObject scrollView2;

    void Start()
    {
        
        scrollView1.SetActive(true);
        scrollView2.SetActive(false);

       
        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);
    }

    void OnDropdownValueChanged(int index)
    {
        
        switch (index)
        {
            case 0: 
                scrollView1.SetActive(true);
                scrollView2.SetActive(false);
                break;
            case 1: 
                scrollView1.SetActive(false);
                scrollView2.SetActive(true);
                break;
            default:
                scrollView1.SetActive(true);
                scrollView2.SetActive(false);
                break;
        }
    }
}
