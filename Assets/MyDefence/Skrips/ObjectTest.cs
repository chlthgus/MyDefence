using UnityEngine;



namespace Sample
{
    public class ObjectTest : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //this.transform
            //ObjectTest�� �پ��ִ� ���ӿ�����Ʈ�� Transform�� �ν��Ͻ�(��ü)
            Debug.Log(this.transform.ToString());

            //this.gameObject:
            //ObjectTest�� �پ��ִ� ���ӿ�����Ʈ�� GameObject�� �ν��Ͻ�(��ü)
            Debug.Log(this.gameObject.ToString());

            //this.gameObject.transform == this.gameObject
            //this.gameObject.transform == this.transform
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}