using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Page1 : MonoBehaviour {

    public List<Button> btnGroup;
    // Use this for initialization
    void Start () {
        btnGroup = new List<Button>();
        for (int i = 1; i < 6; i++)
        {
            GameObject item1 = GameObject.Find("color2_" + i);
            Image image1 = item1.GetComponent<Image>();
            image1.enabled = false;
        }

        for (int i = 1; i < 6; i++)
        {
            GameObject item = GameObject.Find("colorBtn" + i);
            Button btn = item.GetComponent<Button>();
            btn.onClick.AddListener(delegate ()
            {
                this.btnClick(item);
            });
            btnGroup.Add(btn);
        }


        GameObject Back3d = GameObject.Find("3dBack");
        Image back = Back3d.GetComponent<Image>();
        back.enabled = false;

        GameObject showBaiSe = GameObject.Find("showBaiSe");
        Image showBaiSeImg = showBaiSe.GetComponent<Image>();
        showBaiSeImg.enabled = false;

        GameObject btn3 = GameObject.Find("btn360");
        Button btnObj = btn3.GetComponent<Button>();
        btnObj.onClick.AddListener(delegate ()
        {
            GameObject item1 = GameObject.Find("showBaiSe");
            Image image1 = item1.GetComponent<Image>();
            image1.enabled = true;
            back.enabled = true;
        });
    }

    public void btnClick(GameObject obj)
    {
        for (int i = 1; i < 6; i++)
        {
            //Text text = btnGroup[i].GetComponentInChildren<Text>();
            //text.fontSize = 12;
            //text.color = Color.black;
            //btnGroup[i].image.sprite = normalImage.sprite;
            
            GameObject item0 = GameObject.Find("color2_" + i);
            Image image0 = item0.GetComponent<Image>();
            image0.enabled = false;
        }
        
        int currentSelectIndex = 1;
        switch (obj.name)
        {
            case "colorBtn1":
                currentSelectIndex = 1;
                break;
            case "colorBtn2":
                currentSelectIndex = 2;
                break;
            case "colorBtn3":
                currentSelectIndex = 3;
                break;
            case "colorBtn4":
                currentSelectIndex = 4;
                break;
            case "colorBtn5":
                currentSelectIndex = 5;
                break;
        }

        GameObject item = GameObject.Find("color2_" + currentSelectIndex);
        Image image1 = item.GetComponent<Image>();
        image1.enabled = true;
    }


    // Update is called once per frame
    void Update () {
	
	}
}
