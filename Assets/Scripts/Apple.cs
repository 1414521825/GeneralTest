using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Apple : Fruit
{
    public Apple()
    {
        Debug.Log("1st Apple Constructor Called");
    }

    //��Щ�����Ǹ��Ƿ��������
    //���Ը��Ǹ����е��κ�
    //�鷽����
    public override void Chop()
    {
        base.Chop();
        Debug.Log("The apple has been chopped.");
    }

    public override void SayHello()
    {
        base.SayHello();
        Debug.Log("Hello, I am an apple.");
    }
}
