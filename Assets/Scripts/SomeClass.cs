using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClass : MonoBehaviour
{
    void Start()
    {
        //���Ǵ����б�ķ�ʽ��ע�������
        //������ (< >) ��ָ�����͡�
        List<BadGuy> badguys = new List<BadGuy>();

        //���ｫ 3 �� BadGuy ��ӵ��б�
        badguys.Add(new BadGuy("Harvey", 50));
        badguys.Add(new BadGuy("Magneto", 100));
        badguys.Add(new BadGuy("Pip", 5));

        badguys.Sort();

        foreach (BadGuy guy in badguys)
        {
            print(guy.name + " " + guy.power);
        }

        //�������б�ʹ��
        //Ϊ�ա�
        badguys.Clear();
    }
}
