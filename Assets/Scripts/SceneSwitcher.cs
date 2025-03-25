using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // シーン名の配列
    public string[] sceneNames; // Inspectorで設定可能にするためpublicに

    // 配列からロードしたいシーンのインデックス
    public int targetSceneIndex = 0;


    // トリガーに衝突したときに呼ばれるメソッド
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("------------------!!!");
        // プレイヤーが接触したときのみシーンをランダムで切り替える
        if (other.CompareTag("Player"))
        {
            // シーン名の配列からランダムに選択
            //int randomIndex = Random.Range(0, sceneNames.Length);
            string selectedScene = sceneNames[0];

            // 選択したシーンをロード
            SceneManager.LoadScene(selectedScene);
        }
    }

    // トリガーに衝突したときに呼ばれるメソッド
    //private void OnTriggerEnter(Collider other)
    //{
    //    // プレイヤーが接触したときのみシーンを切り替える
    //    if (other.CompareTag("Player"))
    //    {
    //        // インデックスが配列の範囲内にあるかを確認
    //        if (targetSceneIndex >= 0 && targetSceneIndex < sceneNames.Length)
    //        {
    //            // 配列からシーン名を取得してシーンをロード
    //            SceneManager.LoadScene(sceneNames[targetSceneIndex]);
    //        }
    //        else
    //        {
    //            Debug.LogWarning("指定されたシーンインデックスが無効です。");
    //        }
    //    }
    //}
}
