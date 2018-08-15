using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player
{
    private int hp = 100;
    private int power = 50;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "のダメージを受けた");
    }
}

public class test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

        Player myPlayer = new Player();
        myPlayer.Attack();
        myPlayer.Damage(20);


        float min = TestMethod(3, 4);

        string mess = "HelloWorld " + min;
        Debug.Log(mess);

        Vector2 vec2 = new Vector2(1.0f, 2.0f);
        vec2.x += 5.0f;
        vec2.y += 6.0f;

        Debug.Log(vec2);

        Vector2 start = new Vector2(2.0f, 3.0f);
        Vector2 end = new Vector2(8.0f, -3.0f);

        Vector2 dir = end - start;
        Debug.Log("dir="+ dir + " len=" + dir.magnitude);

    }

    // Update is called once per frame
    void Update()
    {

    }

    float TestMethod(int param1, int param2)
    {
        int[] array = { 1, 2, 3, 4 };
        int temp = param1 + param2;

        float[] cal = new float[4];

        for (int i = 0; i < cal.Length; i++)
        {
            cal[i] = (float)temp / (float)array[i];
        }

        float min = cal[0];
        for (int i = 0; i < cal.Length - 1; i++)
        {
            if (cal[i] > cal[i + 1])
            {
                min = cal[i + 1];
            }
            else
            {
                string mess = "cal[" + i + "]の方が小さい";
                Debug.Log(mess);
            }
        }

        return min;
    }
}
