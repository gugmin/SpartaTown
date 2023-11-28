using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public GameObject TalkPanel;
    private void OnTriggerEnter2D(Collider2D other) //������ �浹�� �߻��ϴ� �ڵ�
    {
        if (other.gameObject.tag == "Player") //�÷��̾�� �浹 ����
        {
            TalkPanel.SetActive(true); //�ش� ī�޶� ON
        }
    }

    private void OnTriggerExit2D(Collider2D other) //���� ������ ������ �߻��ϴ� �ڵ�
    {
        if (other.gameObject.tag == "Player") //�÷��̾�� �浹 ����
        {
            TalkPanel.SetActive(false);
        }
    }
}
