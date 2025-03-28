using UnityEngine;

namespace MyDefence
{
    public class Enemy : MonoBehaviour
    {

        //필드

        #region Field
        private float speed = 10f;

        private Vector3 targetPosition;
        private int wayPointIndex = 0;
        #endregion

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //초기화
            wayPointIndex = 0;
            targetPosition = WayPoints.wayPoints[wayPointIndex].position;
        }

        // Update is called once per frame
        void Update()
        {
            //이동구현
            Vector3 dir = targetPosition - this.transform.position;
            transform.Translate(dir.normalized * Time.deltaTime * speed,Space.World);

            //타겟포스테이션 도착판정
            float distance = Vector3.Distance(targetPosition, this.transform.position);
            if(distance <=0.1f)
            {

                //  Debug.Log("도착");

                //다음 타겟 셋팅
                GetNextTargetPostion();

                //targetPosition = WayPoints.wayPoints[1].position;
                //wayPointIndex++;
                //targetPosition = WayPoints.wayPoints[wayPointIndex].position;

               //float
                if(distance <= 0.1f)
                {
                    //다음 타겟 셋팅
                    GetNextTargetPostion();

                    // targetPosition = new Vector3(-7.48f, 1f, -10.5f);
                }
                
            }

            void GetNextTargetPostion()
            {

                if(wayPointIndex ==WayPoints.wayPoints.Length - 1)
                {
                    Debug.Log("종점도착");
                    Destroy(this.gameObject);

                }



               // wayPointIndex++;
               // targetPosition = WayPoints.wayPoints[wayPointIndex].position;

                //Debug.Log($" wayPointIndex: {wayPointIndex}");
            }
        }
    }
}