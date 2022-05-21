using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Masterオブジェクトが格納される変数
    public gameObject masterObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 当たり判定が何かしらあったときに呼ばれるイベント関数
    // 当たってきたオブジェクト情報が collision に代入される
    private void OnCollisionEnter(Collision collision) {
        
        // GameMasterという自作コンポーネントのboxNumをマイナス1
        masterObj.GetComponent<GameMaster>().boxNum--;
        Destroy(gameObject);
    }
}
