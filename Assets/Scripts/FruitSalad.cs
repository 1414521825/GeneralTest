using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalad : MonoBehaviour
{
    void Start()
    {
        Apple myApple = new Apple();

        //��ע�⣬Apple �汾�ķ���
        //������ Fruit �汾��������ע�⣬
        //���� Apple �汾ʹ�á�base���ؼ���
        //������ Fruit �汾��������߶������á�
        myApple.SayHello();
        myApple.Chop();

        //�����ǡ��ڶ�̬�����Ҳ�����á�
        //���� Fruit ��ķ����ǡ��顱�ģ�
        //�� Apple ��ķ����ǡ����ǡ��ģ����
        //�����ǽ� Apple ����ת��Ϊ Fruit ʱ��
        //��ʹ�� Apple �汾�ķ�����
        Fruit myFruit = new Apple();
        myFruit.SayHello();
        myFruit.Chop();
    }
}
