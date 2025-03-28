using UnityEngine;

namespace MyDefence
{
    public class Enemy : MonoBehaviour
    {

        //�ʵ�

        #region Field
        private float speed = 10f;

        private Vector3 targetPosition;
        private int wayPointIndex = 0;
        #endregion

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //�ʱ�ȭ
            wayPointIndex = 0;
            targetPosition = WayPoints.wayPoints[wayPointIndex].position;
        }

        // Update is called once per frame
        void Update()
        {
            //�̵�����
            Vector3 dir = targetPosition - this.transform.position;
            transform.Translate(dir.normalized * Time.deltaTime * speed,Space.World);

            //Ÿ���������̼� ��������
            float distance = Vector3.Distance(targetPosition, this.transform.position);
            if(distance <=0.1f)
            {

                //  Debug.Log("����");

                //���� Ÿ�� ����
                GetNextTargetPostion();

                //targetPosition = WayPoints.wayPoints[1].position;
                //wayPointIndex++;
                //targetPosition = WayPoints.wayPoints[wayPointIndex].position;

               //float
                if(distance <= 0.1f)
                {
                    //���� Ÿ�� ����
                    GetNextTargetPostion();

                    // targetPosition = new Vector3(-7.48f, 1f, -10.5f);
                }
                
            }

            void GetNextTargetPostion()
            {

                if(wayPointIndex ==WayPoints.wayPoints.Length - 1)
                {
                    Debug.Log("��������");
                    Destroy(this.gameObject);

                }



               // wayPointIndex++;
               // targetPosition = WayPoints.wayPoints[wayPointIndex].position;

                //Debug.Log($" wayPointIndex: {wayPointIndex}");
            }
        }
    }
}