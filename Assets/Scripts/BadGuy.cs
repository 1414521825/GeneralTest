using UnityEngine;
using System.Collections;
using System; //������ IComparable �ӿ�

//���������洢��
//��ͬ�����е��ࡣΪ��ʹ��
//���ϵ� Sort() ������������Ҫ
//ʵ�� IComparable �ӿڡ�
public class BadGuy : IComparable<BadGuy>
{
    public string name;
    public int power;

    public BadGuy(string newName, int newPower)
    {
        name = newName;
        power = newPower;
    }

    //IComparable �ӿ���Ҫ
    //�˷�����
    public int CompareTo(BadGuy other)
    {
        if (other == null)
        {
            return 1;
        }

        //�����������졣
        return power - other.power;
    }
}