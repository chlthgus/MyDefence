using UnityEngine;

public class EventTest : MonoBehaviour
{
    public void Awake()
    {
        Debug.Log("[1] Awake ����");
    }
    private void OnEnable()
    {
        Debug.Log("[6-1] OnEnable ����");  // (���ӿ�����Ʈ�� Ȱ��ȭ�ɶ�) 1ȸ�� ����
    }



        private void Start()
    {
        Debug.Log("[2] Start ����");  // (Ȱ��ȭ�ɶ�)1ȸ�� ����
    }

    private void FixedUpdate()
    {
        Debug.Log("[3] FixedUpdate ����");    //1�ʿ� 50������ ����
    }

    private void Update()
    {
        Debug.Log("[4] Update ����");     //�� �����Ӹ��� ȣ��
    }

    private void LateUpdate()
    {
        Debug.Log("[5] LateUpdate ����");     //Update() ���� �ڿ� �ٷ� ���� ����
    }

    private void OnDisable()
    {
        Debug.Log("[6-2] OnDisable ����");    //(�� Ȱ��ȭ�ɶ�) 1ȸ ����
    }


    private void OnDestroy()
    {
        Debug.Log("[7] OnDestroy ����");    // 1ȸ ����
    }



}
