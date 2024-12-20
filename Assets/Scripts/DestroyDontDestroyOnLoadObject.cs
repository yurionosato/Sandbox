using UnityEngine;
using System.Collections;

public class DelayedDestroyDontDestroyOnLoadObject : MonoBehaviour
{
    public string targetObjectName; // 削除したいオブジェクトの名前を指定
    public float delayTime = 0.5f; // 削除までの遅延時間（秒）

    void Start()
    {
        // 遅延処理を開始
        StartCoroutine(DestroyAfterDelay());
    }

    IEnumerator DestroyAfterDelay()
    {
        // 指定時間を待つ
        yield return new WaitForSeconds(delayTime);

        // 指定された名前のオブジェクトを検索
        GameObject targetObject = GameObject.Find(targetObjectName);

        if (targetObject != null)
        {
            // オブジェクトが見つかった場合は削除
            Destroy(targetObject);
            Debug.Log(targetObjectName + " オブジェクトを削除しました。");
        }
        else
        {
            Debug.LogWarning(targetObjectName + " オブジェクトが見つかりませんでした。");
        }
    }
}