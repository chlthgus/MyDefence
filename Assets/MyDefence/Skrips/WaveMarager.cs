using System.Threading;
using UnityEngine;

public class WaveMarager : MonoBehaviour
{

    #region

    public GameObject enemyPrefab;

    public Transform startPoint;


    #endregion
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //시작 지점에 enemy 한마리 스폰
        SpawnEnemy();
    }



    // Update is called once per frame
    void Update()
    {
       // countdown += Time.deltaTime;
      // if(Countdown >= 5f)
       // {
       //     SpawnEnemy();
       // }
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, startPoint.position, Quaternion.identity);
    }
}
