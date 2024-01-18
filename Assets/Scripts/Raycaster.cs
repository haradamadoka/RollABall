using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Raycaster : MonoBehaviour
{
    // カメラへのアクセス
    public Camera usedCamera;

    // このレイキャストの対象となるレイヤー
    public LayerMask layers;

    // キャストの最大距離
    public float raycastDistance = 10.0f;

    // スクリプトが有効になった際に毎回呼び出される
    public void OnEnable()
    {
        if (!usedCamera)
        {
            usedCamera = Camera.main;
        }
    }

    // 毎フレーム呼び出される
    public void DrawRay(Vector3 clickPosition)
    {
        // mousePositionからレイを作成
        Ray ray = usedCamera.ScreenPointToRay(clickPosition);

        // Rayと一致する線を描画
        Debug.DrawRay(ray.origin, ray.direction);
    }



    // タッチを引数として使うUnityEvent
    [System.Serializable]
    public class StringUnityEvent : UnityEvent<string> { }

    // トラッキングしている指が画面に触れたときに呼び出される
    public StringUnityEvent hitDetected;

    // …クラスに既存のその他メソッド… 
    // レイキャストを実行し、レスポンスとしてイベントを送信
    public void Raycast(Vector3 clickPosition)
    {
        RaycastHit hit;
        Ray ray = usedCamera.ScreenPointToRay(clickPosition);

        if (Physics.Raycast(ray, out hit, raycastDistance, layers))
        {
            hitDetected.Invoke(hit.transform.name);
        }

}
public void Update()
    {
        Raycast(Input.mousePosition);
    }
}
