using UnityEngine;

namespace Sample
{
    public class MoveTest : MonoBehaviour
    {

        //필드
        //이동속도
        private float speed = 5f;
        
        
        //이동 목표 지점



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
            //플레이어의 위치를 앞으로 이동하라

            //this.transform.position = this.transform.position + new Vector3(0f,0f,1f);

            //뒤 좌 우 위 아래

            //  this.transform.position += Vector3.forward;
            // this.transform.position += Vector3.right;

            //속도
            //앞 방향으로 1초에 1unit 만큼 이동
            //  this.transform.position += new Vector3(0f, 0f, 1f) * Time.deltaTime;

            //앞 방향으로 1초에 speed(5)unit 만큼 이동
            // this.transform.position += Vector3.forward * Time.deltaTime * speed;

            this.transform.Translate(Vector3.forward * Time.deltaTime * speed);

            //Translate : 이동 함수
            //방향 : 앞방향
            //Time.deltaTime : 동일한 시간에 동일한 거리를 이동하게 해준다
            //speed : 이동속도 - 초당 이동하는 거리
            //Vector3 * float * float => Vector3
            //this.transform.Translate(Vector3.right * Time.deltaTime * speed)

            //이동 방향 구하기 : (목표위치 - 현재위치)
            //dir.magnitude : 벡터의 크기, 길이
            //dir.normalized : 길이가 1인 벡터, 정규화된 벡터, 단위벡터
            // Vector3 dir = targetposition - this.transform.position;
            // transform.Translate(dir.normalized * Time.deltaTime * speed);

           // transform.Translate(Vector3.forward * Time.deltaTime *speed,Space.World);
           transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.Self);


        }
    }
}

/*
 n프레임 : 초당n번 실행하기(보여주기)
20프레임 : 1프레임 보여주는데 0.05초 걸린다
FPS : 1초에 (실행) 보여주는데 프레임 갯수

//unity
Time.deltaTime : 1프레임을 실행하는데 걸리는 시간

PC1 : 성능이 좋은 컴
10프레임 - 1초 10만큼 이동
Time.deltaTime 값 : 0.1f
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

PC2 : 성능이 나쁜 컴
2프레임 - 1초 2만큼 이동
Time.deltaTime 값 : 0.5f
this.transform.position += new Vector3(0f , 0f , 1f) * Time.deltaTime * 20;
this.transform.position += new Vector3(0f , 0f , 1f) * Time.deltaTime * 20;
 




1. 앞,뒤,좌,우로 이동하기
2. 5의 속도로 이동하기
3. 목표지점( 7,1,8 )
  4.목표지점 도착 판정
  
 
 */