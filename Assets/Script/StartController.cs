using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartController : MonoBehaviour
{
    public void OnStartButtonPressed()
    {
        //�Q�[���}�l�[�W���[��F�����Ă��Ȃ�
        GameManager.Instance.StartGame();
    }
}
