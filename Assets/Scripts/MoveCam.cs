using UnityEngine;

public class MoveCam : MonoBehaviour
{
    public GameObject virtualCam;

    private void OnTriggerEnter2D(Collider2D other) //������ �浹�� �߻��ϴ� �ڵ�
    {
        if (other.gameObject.tag == "Player") //�÷��̾�� �浹 ����
        {
            virtualCam.SetActive(true); //�ش� ī�޶� ON
        }
    }

    private void OnTriggerExit2D(Collider2D other) //���� ������ ������ �߻��ϴ� �ڵ�
    {
        if (other.gameObject.tag == "Player") //�÷��̾�� �浹 ����
        {
            virtualCam.SetActive(false); //�ش� ī�޶� OFF
        }
    }
}