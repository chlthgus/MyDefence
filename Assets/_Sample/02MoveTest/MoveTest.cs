using UnityEngine;

namespace Sample
{
    public class MoveTest : MonoBehaviour
    {

        //�ʵ�
        //�̵��ӵ�
        private float speed = 5f;
        
        
        //�̵� ��ǥ ����



        Vector3 targetposition = new Vector3(7f,1f,8f);



        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //this.transform.position = new Vector3(7f,1f,8f);

            this.transform.position = targetposition;
            Debug.Log(this.transform.position);
        }

        // Update is called once per frame
        void Update()
        {
            //�÷��̾��� ��ġ�� ������ �̵��϶�

            //this.transform.position = this.transform.position + new Vector3(0f,0f,1f);

            //�� �� �� �� �Ʒ�

            //  this.transform.position += Vector3.forward;
            // this.transform.position += Vector3.right;

            //�ӵ�
            //�� �������� 1�ʿ� 1unit ��ŭ �̵�
            //  this.transform.position += new Vector3(0f, 0f, 1f) * Time.deltaTime;

            //�� �������� 1�ʿ� speed(5)unit ��ŭ �̵�
            // this.transform.position += Vector3.forward * Time.deltaTime * speed;

            this.transform.Translate(Vector3.forward * Time.deltaTime * speed);

            //Translate : �̵� �Լ�
            //���� : �չ���
            //Time.deltaTime : ������ �ð��� ������ �Ÿ��� �̵��ϰ� ���ش�
            //speed : �̵��ӵ� - �ʴ� �̵��ϴ� �Ÿ�
            //Vector3 * float * float => Vector3
            //this.transform.Translate(Vector3.right * Time.deltaTime * speed)

            //�̵� ���� ���ϱ� : (��ǥ��ġ - ������ġ)
            //dir.magnitude : ������ ũ��, ����
            //dir.normalized : ���̰� 1�� ����, ����ȭ�� ����, ��������
            // Vector3 dir = targetposition - this.transform.position;
            // transform.Translate(dir.normalized * Time.deltaTime * speed);

           // transform.Translate(Vector3.forward * Time.deltaTime *speed,Space.World);
           transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.Self);


        }
    }
}

/*
 n������ : �ʴ�n�� �����ϱ�(�����ֱ�)
20������ : 1������ �����ִµ� 0.05�� �ɸ���
FPS : 1�ʿ� (����) �����ִµ� ������ ����

//unity
Time.deltaTime : 1�������� �����ϴµ� �ɸ��� �ð�

PC1 : ������ ���� ��
10������ - 1�� 10��ŭ �̵�
Time.deltaTime �� : 0.1f
this.transform.position += new Vector3(0f , 0f , 1f) * Time.deltaTime * 20;
this.transform.position += new Vector3(0f , 0f , 1f) * Time.deltaTime * 20;
this.transform.position += new Vector3(0f , 0f , 1f) * Time.deltaTime * 20;
this.transform.position += new Vector3(0f , 0f , 1f) * Time.deltaTime * 20;
this.transform.position += new Vector3(0f , 0f , 1f) * Time.deltaTime * 20;
this.transform.position += new Vector3(0f , 0f , 1f) * Time.deltaTime * 20;
this.transform.position += new Vector3(0f , 0f , 1f) * Time.deltaTime * 20;
this.transform.position += new Vector3(0f , 0f , 1f) * Time.deltaTime * 20;
this.transform.position += new Vector3(0f , 0f , 1f) * Time.deltaTime * 20;
this.transform.position += new Vector3(0f , 0f , 1f) * Time.deltaTime * 20;

PC2 : ������ ���� ��
2������ - 1�� 2��ŭ �̵�
Time.deltaTime �� : 0.5f
this.transform.position += new Vector3(0f , 0f , 1f) * Time.deltaTime * 20;
this.transform.position += new Vector3(0f , 0f , 1f) * Time.deltaTime * 20;
 




1. ��,��,��,��� �̵��ϱ�
2. 5�� �ӵ��� �̵��ϱ�
3. ��ǥ����( 7,1,8 )
  4.��ǥ���� ���� ����
  
 
 */