using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �v���C���[�ړ��Ǘ��N���X
/// </summary>
public class PlayerMove : MonoBehaviour
{
    public float Speed = 1;         // �v���C���[�̈ړ����x
    public float RotateSpeed = 1;   // �v���C���[�̉�]���x
    public float JumpPower = 10;    // �W�����v�̈ړ���

    // private
    private Rigidbody _rigidbody;   // Rigidbody�R���|�[�l���g

    /// <summary>
    /// �Q�[���I�u�W�F�N�g���������ꂽ�u�ԂɈ�x�����Ă΂��
    /// (���m�ɂ͈Ⴄ�̂ŋC�ɂȂ���͒��ׂĂ�������)
    /// </summary>
    void Start()
    {
        // �}�E�X�J�[�\���������Ȃ��悤�ɂ���
        Cursor.visible = false;
        // �}�E�X�J�[�\���������Ȃ��悤�ɌŒ肳����
        Cursor.lockState = CursorLockMode.Locked;
        // ���̃Q�[���I�u�W�F�N�g����RigidBody�R���|�[�l���g���擾����
        _rigidbody = this.gameObject.GetComponent<Rigidbody>();
    }

    /// <summary>
    /// ���̃Q�[���I�u�W�F�N�g��Destroy(�폜)�����u�ԂɈ�x�����Ă΂��
    /// </summary>
    private void OnDestroy()
    {
        // �}�E�X�J�[�\����\������
        Cursor.visible = true;
        // �}�E�X�J�[�\���𓮂�����悤�ɂ���
        Cursor.lockState = CursorLockMode.None;
    }

    /// <summary>
    /// ���t���[���Ă΂��
    /// </summary>
    void Update()
    {
        // �L�����N�^�[�̉�]
        float yaw = Input.GetAxis("Mouse X") * RotateSpeed;                   // �}�E�X�̈ړ��ʂ��g���ďc��]����
        this.gameObject.transform.eulerAngles += new Vector3(0, yaw, 0);    // ���g����]

        // �L�����N�^�[�̈ړ�
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Quaternion horizontalRotation = Quaternion.AngleAxis(transform.eulerAngles.y, Vector3.up);
        //�uwasd�v�̓��͂����l���g���ăv���C���[���ړ�
        _rigidbody.position += horizontalRotation * new Vector3(h, 0, v) * Speed * Time.deltaTime;

        // �W�����v
        // �X�y�b�N�L�[���������܂ꂽ�u�Ԃ̂ݏ������s����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //�v���C���[�ɑ΂��ď������JumpPower�������Ռ�(��)��^����B
            _rigidbody.AddForce(new Vector3(0, JumpPower, 0), ForceMode.Impulse);
        }
    }
}
