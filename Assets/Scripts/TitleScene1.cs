using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// �^�C�g���Ǘ��N���X
/// </summary>
public class TitleScene1 : MonoBehaviour
{
    /// <summary>
    /// �Q�[����ʂ�
    /// </summary>
    public void GoTitle()
    {
        //�@�uGame�v�V�[���ɃV�[����؂�ւ���
        SceneManager.LoadScene("Title");
    }
}
