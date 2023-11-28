using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public GameObject TalkPanel;
    private void OnTriggerEnter2D(Collider2D other) //영역과 충돌시 발생하는 코드
    {
        if (other.gameObject.tag == "Player") //플레이어와 충돌 감지
        {
            TalkPanel.SetActive(true); //해당 카메라 ON
        }
    }

    private void OnTriggerExit2D(Collider2D other) //영역 밖으로 나갈때 발생하는 코드
    {
        if (other.gameObject.tag == "Player") //플레이어와 충돌 감지
        {
            TalkPanel.SetActive(false);
        }
    }
}
