using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤー移動管理クラス
/// </summary>
public class PlayerMove : MonoBehaviour
{
    public float Speed = 1;         // プレイヤーの移動速度
    public float RotateSpeed = 1;   // プレイヤーの回転速度
    public float JumpPower = 10;    // ジャンプの移動量

    // private
    private Rigidbody _rigidbody;   // Rigidbodyコンポーネント

    /// <summary>
    /// ゲームオブジェクトが生成された瞬間に一度だけ呼ばれる
    /// (正確には違うので気になる方は調べてください)
    /// </summary>
    void Start()
    {
        // マウスカーソルを見えないようにする
        Cursor.visible = false;
        // マウスカーソルが動かないように固定させる
        Cursor.lockState = CursorLockMode.Locked;
        // このゲームオブジェクトからRigidBodyコンポーネントを取得する
        _rigidbody = this.gameObject.GetComponent<Rigidbody>();
    }

    /// <summary>
    /// このゲームオブジェクトがDestroy(削除)される瞬間に一度だけ呼ばれる
    /// </summary>
    private void OnDestroy()
    {
        // マウスカーソルを表示する
        Cursor.visible = true;
        // マウスカーソルを動かせるようにする
        Cursor.lockState = CursorLockMode.None;
    }

    /// <summary>
    /// 毎フレーム呼ばれる
    /// </summary>
    void Update()
    {
        // キャラクターの回転
        float yaw = Input.GetAxis("Mouse X") * RotateSpeed;                   // マウスの移動量を使って縦回転入力
        this.gameObject.transform.eulerAngles += new Vector3(0, yaw, 0);    // 自身を回転

        // キャラクターの移動
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Quaternion horizontalRotation = Quaternion.AngleAxis(transform.eulerAngles.y, Vector3.up);
        //「wasd」の入力した値を使ってプレイヤーを移動
        _rigidbody.position += horizontalRotation * new Vector3(h, 0, v) * Speed * Time.deltaTime;

        // ジャンプ
        // スペックキーが押し込まれた瞬間のみ処理が行われる
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //プレイヤーに対して上向きにJumpPower分だけ衝撃(力)を与える。
            _rigidbody.AddForce(new Vector3(0, JumpPower, 0), ForceMode.Impulse);
        }
    }
}
