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
            TalkPanel.SetActive(true); 
        }
        else if (other.gameObject.tag == "Player1") //�÷��̾�� �浹 ����
        {
            TalkPanel.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other) //���� ������ ������ �߻��ϴ� �ڵ�
    {
        if (other.gameObject.tag == "Player") //�÷��̾�� �浹 ����
        {
            TalkPanel.SetActive(false);
        }
        else if (other.gameObject.tag == "Player1") //�÷��̾�� �浹 ����
        {
            TalkPanel.SetActive(false);
        }
    }
}
