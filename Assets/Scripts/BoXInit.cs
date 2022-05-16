using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoXInit : MonoBehaviour {

    // ゲームオブジェクト型の変数を定義
    public GameObject boxObjPrefab;
    public GameObject boxesObj;

    // Startよりも早く呼ばれるイベント変数
    void Awake() {
        // 横8*縦5にBoxのPrefabをインスタンス化
        for (int x = 0; x < 8; x++) {
            for (int y = 0; y < 5; y++) {
                // 一旦"g"というGameObject型の変数を作りその中にPrefabをインスタンス化
                GameObject g = Instantiate(boxObjPrefab, boxesObj.transform);
                // 変数"g"にインスタンス化して入れられたゲームオブジェクトのtransform.positionの値をfor文を使って個々の座標に移動させる
                g.transform.position = new Vector3((2f + (1f * y)), 0.4f, (-4.2f + (1.2f * x)));
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
