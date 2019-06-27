using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    private int hp = 100;   // 体力
    private int mp = 53;   // 魔力
    private int power = 25; // 攻撃力

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }
    // 魔法攻撃用の関数
    public void Magic()
    {
        int fire = 5; //fireの消費mp


        //「魔法攻撃をした。残りMPは〇〇。」と表示してください。mpが足りない場合、「MPが足りないため魔法が使えない。」
        if (mp >= fire)
        { 
            mp = mp - fire;

            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");

        }
        else
        {

            Debug.Log("MPが足りないため魔法が使えない。");
        }

    }

}
public class Test : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

        Boss lastboss = new Boss();

        for (int i = 1; i <= 11; i ++)
        {

            Debug.Log( i + "回目の魔法攻撃");

            lastboss.Magic();

        }

        Debug.Log("発展課題用ここまで");

        int[] array = new int[5];

        Debug.Log("順にarray配列を表示");

        for ( int i = 0; i <= 4; i++) {

            array[i] = i;

            Debug.Log(array[i]);

        }

        Debug.Log("逆にarray配列を表示");

        for ( int x = 4; x >= 0; x--) {

            Debug.Log(array[x]);


        }

    }

	
	// Update is called once per frame
	void Update () {
		
	}
}
