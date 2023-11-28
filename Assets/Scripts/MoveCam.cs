using UnityEngine;

public class MoveCam : MonoBehaviour
{
    public GameObject virtualCam;

    private void OnTriggerEnter2D(Collider2D other) //영역과 충돌시 발생하는 코드
    {
        if (other.gameObject.tag == "Player") //플레이어와 충돌 감지
        {
            virtualCam.SetActive(true); //해당 카메라 ON
        }
    }

    private void OnTriggerExit2D(Collider2D other) //영역 밖으로 나갈때 발생하는 코드
    {
        if (other.gameObject.tag == "Player") //플레이어와 충돌 감지
        {
            virtualCam.SetActive(false); //해당 카메라 OFF
        }
    }
}