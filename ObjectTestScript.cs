using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTestScript : MonoBehaviour
{
    public void DoClick()
    {
        int a = 10;

        MyCar myCar = new MyCar();
        myCar.Move();
        myCar.Move(a);

        MyK5 myK5 = new MyK5();
        myK5.Move();
        myK5.Move(a);

        MyCar myCar2 = new MyK5();
        myCar2.Move();
        myCar2.Move(a);
    }
}


public class MyCar
{
    Color color;

    public float velocity; // 계기판
    public string headLight; //헤드라이트
    public string roomMirror;
    public string sideMirror;

    public void DoLight()
    {

    }

    public virtual void Move()
    {
        Debug.Log("MycarMove");
    }

    public virtual void Move(int a)
    {
        Debug.Log("MycarMove " + a);
    }

    public void Klaxon()
    {

    }
}

public class MyK5 : MyCar
{
    public override void Move()
    {
        Debug.Log("K5Move");
    }
}
