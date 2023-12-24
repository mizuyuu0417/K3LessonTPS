using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// HP管理クラス
/// </summary>
public class Health : MonoBehaviour
{
    public float HealthValue = 100; // キャラクターのHP

    /// <summary>
    /// 相手にダメージを当てえる
    /// </summary>
    /// <param name="value"></param>
    public void TakeDamage(float value)
    {
        //HPからダメージ分引く
        HealthValue -= value;

        //HPが0以下の時に処理が行われる
        if (HealthValue <= 0)
        {
            //自身を削除する
            Destroy(this.gameObject);
        }
    }
}
