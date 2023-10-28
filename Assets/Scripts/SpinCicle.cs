using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SpinCicle : MonoBehaviour
{
    public Image[] images;
    public Image[] inImages;

    private void Start()
    {
        for(int i = 0; i < images.Length; i++)
        {
            images[i].rectTransform.position = new Vector3(2000f, 2000f, 0);
            inImages[i].rectTransform.position = new Vector3(2000f, 2000f, 0);
        }
    }

    private void Spin(int n)
    {
        Debug.Log("执行了Spin函数");
        float r = 125f;
        float theta = 360f / n;
        for (int i = 0; i < n; i++)
        {
            float angle = i * theta;

            inImages[i].transform.SetParent(images[i].transform);
            images[i].rectTransform.position = new Vector3(r * Mathf.Cos(angle * Mathf.Deg2Rad), r * Mathf.Sin(angle * Mathf.Deg2Rad), 700f);
            images[i].rectTransform.rotation = Quaternion.Euler(0f, 0f, angle);
            //inImages[i].rectTransform.position = Vector3.zero;
        }
    }

    private void Update()
    {
        //Debug.Log("执行了Update");
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("按下了空格");
            Spin(6);
        }
    }
}
