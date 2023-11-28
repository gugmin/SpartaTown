using UnityEngine;

public class MoveCam : MonoBehaviour
{
    public GameObject virtualCam;
    public GameObject virtualCam1;

    private void OnTriggerEnter2D(Collider2D other) //������ �浹�� �߻��ϴ� �ڵ�
    {
        if (other.gameObject.tag == "Player") //�÷��̾�� �浹 ����
        {
            virtualCam.SetActive(true); //�ش� ī�޶� ON
        }
        else if (other.gameObject.tag == "Player1") //�÷��̾�� �浹 ����
        {
            virtualCam1.SetActive(true); //�ش� ī�޶� ON
        }
    }

    private void OnTriggerExit2D(Collider2D other) //���� ������ ������ �߻��ϴ� �ڵ�
    {
        if (other.gameObject.tag == "Player") //�÷��̾�� �浹 ����
        {
            virtualCam.SetActive(false);
            virtualCam1.SetActive(false); //�ش� ī�޶� OFF
        }
        else if (other.gameObject.tag == "Player1") //�÷��̾�� �浹 ����
        {
            virtualCam.SetActive(false);
            virtualCam1.SetActive(false); //�ش� ī�޶� OFF
        }
    }
}