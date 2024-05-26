using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SizeChange : MonoBehaviour
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
    public GameObject slaiderisGarums;
    public GameObject slaiderisPlatums;

    public void mainitAttelaGarumu()
    {
        float size = slaiderisGarums.GetComponent<UnityEngine.UI.Slider>().value;
        Vector3 scale = mainigaisAttels.transform.localScale;
        scale.x = size;
        mainigaisAttels.transform.localScale = scale;
    }

    public void mainitAttelaPlatumu(){
        float size = slaiderisPlatums.GetComponent<UnityEngine.UI.Slider>().value;
        Vector3 scale = mainigaisAttels.transform.localScale;
        scale.y = size;
        mainigaisAttels.transform.localScale = scale;
    }

}
