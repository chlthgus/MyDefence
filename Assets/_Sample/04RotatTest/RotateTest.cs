using UnityEngine;

namespace Sample
{
    public class RotateTest : MonoBehaviour
    {
        //�ʵ�
        private float x;


        //ȸ���ӵ�
        public float trunSpeed = 5f;

        //�̵��ӵ�
        public float moveSpeed = 5f;


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            this.transform.rotation = Quaternion.Euler(90f, 0f, 0f); //x�� ȸ��
            this.transform.rotation = Quaternion.Euler(0f, 90f, 0f); //y�� ȸ��
            this.transform.rotation = Quaternion.Euler(0f, 0f, 90f); //z�� ȸ��
        }

        // Update is called once per frame
        void Update()
        {
             x += 1;

            //y�� �������� +ȸ��
            //  this.transform.rotation = Quaternion.Euler(0f, x, 0f);
            //x�� �������� +ȸ��
            // this.transform.rotation = Quaternion.Euler(x, 0f, 0f);
            //z�� �������� +ȸ��
            // this.transform.rotation = Quaternion.Euler(0f, 0f, x);

            //y�� �������� �ӵ� 5�� ȸ���ϱ�
            // x += Time.deltaTime * 5;
            // this.transform.rotation = Quaternion.Euler(0f, x, 0f);

            //y�� �������� �ӵ� 5�� ȸ���ϱ�
            // this.transform.Rotate(Vector3.up * Time.deltaTime * Time.turnSpeed);

            //Ÿ�� �������� ȸ���ϱ�
            // Vector3 dir = target.position - this.transform.position;

            //���� ���ͷ� ���� ���� ������ �ٶ󺸴� ȸ���� ���ϱ�
            //  Quaternion targetRotation = Quaternion.LookRotation(dir);

            //  Quaternion lookRotation = Quaternion.Lerp(this.transform.rotation, targetRotation,Time.deltaTime * trunSpeed);
            //  this.transform.rotation = lookRotation.eulerAngles;
            // this.transform.rotation = Quaternion.Euler(0f, eulerRotation.y, 0f);

            //ȸ��+�̵�
            //Ÿ�� ���� ���ϱ�
          //  Vector3 dir = target.position - this.transform.position;
            //���� ���ͷκ��� ���� ������ �ٶ󺸴� ȸ���� ���ϱ�
           // this.transform.rotation = Quaternion.LookRotation(dir);

            //this.transform.Translate(dir.normalized * Time.deltaTime * moveSpeed, Space.World);
        

        
        }
    }
}