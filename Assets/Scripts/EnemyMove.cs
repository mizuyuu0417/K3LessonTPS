using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 敵の移動処理
/// </summary>
public class EnemyMove : MonoBehaviour
{
    public float Speed = 10;    // 敵の移動速度
    // private 
    private GameObject duck;    // ゲームオブジェクト(アヒル)

    /// <summary>
    /// ゲームオブジェクトが生成された瞬間に一度だけ呼ばれる
    /// (正確には違うので気になる方は調べてください)
    /// </summary>
    void Start()
    {
        //「Duck」という名前のゲームオブジェクトを探してduckに渡す
        duck = GameObject.Find("Duck");
    }

    /// <summary>
    /// 毎フレーム呼ばれる
    /// </summary>
    void Update()
    {
        // アヒルの現在座標から自身の座標を引いて向きベクトルを取得します
        Vector3 velocity = duck.transform.position - this.gameObject.transform.position;
        // 自身の座標に「向きベクトル(正規化済み) * 移動速度 * deltaTime(１フレームの時間分)」を加算する
        this.gameObject.transform.position += velocity.normalized * Speed * Time.deltaTime;
    }
}

