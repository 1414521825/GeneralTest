using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass : MonoBehaviour
{
    void Start()
    {
        //���Ǵ����ֵ�ķ�ʽ��ע��������β���
        //����ͨ������ġ��ڴ�����У�����ʹ���ַ�����
        //BadGuy ��Ϊ����ֵ��
        Dictionary<string, BadGuy> badguys = new Dictionary<string, BadGuy>();

        BadGuy bg1 = new BadGuy("Harvey", 50);
        BadGuy bg2 = new BadGuy("Magneto", 100);

        //����ʹ�� Add() ����������
        //�����ֵ��С�
        badguys.Add("gangster", bg1);
        badguys.Add("mutant", bg2);

        BadGuy magneto = badguys["mutant"];

        BadGuy temp = null;

        //����һ�ַ����ֵ���ֵ�ĸ���ȫ
        //�������ķ�����
        if (badguys.TryGetValue("birds", out temp))
        {
            //�ɹ���
        }
        else
        {
            //ʧ�ܣ�
        }
    }
}
