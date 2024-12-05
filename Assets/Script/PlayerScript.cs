using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerScript : MonoBehaviour
{
    float normalSpeed = 3f; // �ʏ펞�̈ړ����x
    float sprintSpeed = 5f; // �_�b�V�����̈ړ����x
    float jump = 8f;        // �W�����v��

    Rigidbody rb;

    float gravity = 10f;    // �d�͂̑傫��

    Vector3 moveDirection = Vector3.zero;

    Vector3 startPos;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        //�ړ����x���擾
        float speed = Input.GetKey(KeyCode.LeftShift) ? sprintSpeed : normalSpeed;
        // W�L�[�i�O���ړ��j
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = transform.forward * speed;
        }

        // S�L�[�i����ړ��j
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = -transform.forward * speed;
        }

        // D�L�[�i�E�ړ��j
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = transform.right * speed;
        }

        // A�L�[�i���ړ��j
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = -transform.right * speed;
        }
        // �J�����̌�������ɂ������ʕ����̃x�N�g��
        Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;

        // �O�㍶�E�̓��́iWASD�L�[�j����A�ړ��̂��߂̃x�N�g�����v�Z
        // Input.GetAxis("Vertical") �͑O��iWS�L�[�j�̓��͒l
        // Input.GetAxis("Horizontal") �͍��E�iAD�L�[�j�̓��͒l
        Vector3 moveZ = cameraForward * Input.GetAxis("Vertical") * speed;  //�@�O��i�J������j�@ 
        Vector3 moveX = Camera.main.transform.right * Input.GetAxis("Horizontal") * speed; // ���E�i�J������j= gravity * Time.deltaTime;

        // �v���C���[�̌�������͂̌����ɕύX�@
        //transform.LookAt(transform.position + moveZ + moveX);


    }
}
