using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// タイトル管理クラス
/// </summary>
public class TitleScene1 : MonoBehaviour
{
    /// <summary>
    /// ゲーム画面へ
    /// </summary>
    public void GoTitle()
    {
        //　「Game」シーンにシーンを切り替える
        SceneManager.LoadScene("Title");
    }
}
