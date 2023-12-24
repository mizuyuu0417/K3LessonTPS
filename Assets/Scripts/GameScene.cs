using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// �Q�[���V�[���̊Ǘ��N���X
/// </summary>
public class GameScene : MonoBehaviour
{
    public GameObject Player;           // �v���C���[�I�u�W�F�N�g
    public GameObject GameStartUI;      // StartUI
    public GameObject GameOverUI;       // GameOverUI
    public GameObject GameOverCamera;   // �Q�[���I�[�o�[���p�J����

    /// <summary>
    /// �Q�[���I�u�W�F�N�g���������ꂽ�u�ԂɈ�x�����Ă΂��
    /// (���m�ɂ͈Ⴄ�̂ŋC�ɂȂ���͒��ׂĂ�������)
    /// </summary>
    public void Start()
    {
        // �uStartUI�v��\������
        GameStartUI.SetActive(true);
        //5�b��ɁuStartUI�v���폜�����悤�ɐݒ�
        Destroy(GameStartUI, 5);

        //�uGameOverUI�v���\���ɂ���
        GameOverUI.SetActive(false);
        // �u�Q�[���I�[�o�[���p�J�����v���\���ɂ���
        GameOverCamera.SetActive(false);
    }

    /// <summary>
    /// �Q�[���I�[�o�[����
    /// </summary>
    public void OnGameOver()
    {
        // �v���C���[�I�u�W�F�N�g���폜����
        Destroy(Player);
        //�uGameOverUI�v��\������
        GameOverUI.SetActive(true);
        // �u�Q�[���I�[�o�[���p�J�����v��\���ɂ���
        GameOverCamera.SetActive(true);
    }

    /// <summary>
    /// Title��ʂ�
    /// </summary>
    public void GoTitle()
    {
        // �uTitle�v�V�[���ɃV�[����؂�ւ���
        SceneManager.LoadScene("Title");
    }
}
