using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KabeOut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // このスクリプトがアタッチされたオブジェクト当たったら、GameOverメソッドを呼ぶ
    private void OnCollisionEnter(Collision collision) {

        GameObject.Find("Master").GetComponent<GameMaster>().GameOver("完");
    }
}
