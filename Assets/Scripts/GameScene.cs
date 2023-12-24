using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// ゲームシーンの管理クラス
/// </summary>
public class GameScene : MonoBehaviour
{
    public GameObject Player;           // プレイヤーオブジェクト
    public GameObject GameStartUI;      // StartUI
    public GameObject GameOverUI;       // GameOverUI
    public GameObject GameOverCamera;   // ゲームオーバー時用カメラ

    /// <summary>
    /// ゲームオブジェクトが生成された瞬間に一度だけ呼ばれる
    /// (正確には違うので気になる方は調べてください)
    /// </summary>
    public void Start()
    {
        // 「StartUI」を表示する
        GameStartUI.SetActive(true);
        //5秒後に「StartUI」が削除されるように設定
        Destroy(GameStartUI, 5);

        //「GameOverUI」を非表示にする
        GameOverUI.SetActive(false);
        // 「ゲームオーバー時用カメラ」を非表示にする
        GameOverCamera.SetActive(false);
    }

    /// <summary>
    /// ゲームオーバー処理
    /// </summary>
    public void OnGameOver()
    {
        // プレイヤーオブジェクトを削除する
        Destroy(Player);
        //「GameOverUI」を表示する
        GameOverUI.SetActive(true);
        // 「ゲームオーバー時用カメラ」を表示にする
        GameOverCamera.SetActive(true);
    }

    /// <summary>
    /// Title画面へ
    /// </summary>
    public void GoTitle()
    {
        // 「Title」シーンにシーンを切り替える
        SceneManager.LoadScene("Title");
    }
}
