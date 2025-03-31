using UnityEngine;

namespace Sample
{
    public class RotateTest : MonoBehaviour
    {
        //필드
        private float x;


        //회전속도
        public float trunSpeed = 5f;

        //이동속도
        public float moveSpeed = 5f;


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            this.transform.rotation = Quaternion.Euler(90f, 0f, 0f); //x축 회적
            this.transform.rotation = Quaternion.Euler(0f, 90f, 0f); //y축 회전
            this.transform.rotation = Quaternion.Euler(0f, 0f, 90f); //z축 회전
        }

        // Update is called once per frame
        void Update()
        {
             x += 1;

            //y축 기준으로 +회전
            //  this.transform.rotation = Quaternion.Euler(0f, x, 0f);
            //x축 기준으로 +회전
            // this.transform.rotation = Quaternion.Euler(x, 0f, 0f);
            //z축 기준으로 +회전
            // this.transform.rotation = Quaternion.Euler(0f, 0f, x);

            //y축 기준으로 속도 5로 회전하기
            // x += Time.deltaTime * 5;
            // this.transform.rotation = Quaternion.Euler(0f, x, 0f);

            //y축 기준으로 속도 5로 회전하기
            // this.transform.Rotate(Vector3.up * Time.deltaTime * Time.turnSpeed);

            //타겟 방향으로 회전하기
            // Vector3 dir = target.position - this.transform.position;

            //방향 벡터로 부터 그쪽 방향을 바라보는 회전값 구하기
            //  Quaternion targetRotation = Quaternion.LookRotation(dir);

            //  Quaternion lookRotation = Quaternion.Lerp(this.transform.rotation, targetRotation,Time.deltaTime * trunSpeed);
            //  this.transform.rotation = lookRotation.eulerAngles;
            // this.transform.rotation = Quaternion.Euler(0f, eulerRotation.y, 0f);

            //회전+이동
            //타겟 방향 구하기
          //  Vector3 dir = target.position - this.transform.position;
            //방향 벡터로부터 그쪽 방향을 바라보는 회전값 구하기
           // this.transform.rotation = Quaternion.LookRotation(dir);

            //this.transform.Translate(dir.normalized * Time.deltaTime * moveSpeed, Space.World);
        

        
        }
    }
}