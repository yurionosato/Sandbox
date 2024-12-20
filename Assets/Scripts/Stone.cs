using UnityEngine;

public class Stone : MonoBehaviour
{
    // 石が消滅したときに呼び出されるイベント
    public static event System.Action OnStoneDestroyed;
    public GameObject gameobject;


    private void Start()
    {
        gameobject = GameObject.Find("countobj");
    }

    private void OnTriggerEnter(Collider other)
    {
        // プレイヤーにぶつかった場合のみ消滅
        if (other.CompareTag("Player"))
        {
            gameobject.GetComponent<StoneCount>().counter();

            // 石が消えたことを通知
            OnStoneDestroyed?.Invoke();

            // 石オブジェクトを消滅させる
            Destroy(gameObject);

        }
    }
}

//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class Stone : MonoBehaviour
//{
//    // シーン名の配列
//    public string[] sceneNames; // Inspectorで設定可能にするためpublicに

//    // 配列からロードしたいシーンのインデックス
//    public int targetSceneIndex = 0;


//    // トリガーに衝突したときに呼ばれるメソッド
//    private void OnTriggerEnter(Collider other)
//    {
//        // プレイヤーが接触したときのみシーンをランダムで切り替える
//        if (other.CompareTag("Player"))
//        {
//            Debug.Log("!!!");
//            // シーン名の配列からランダムに選択
//            int randomIndex = Random.Range(0, sceneNames.Length);
//            string selectedScene = sceneNames[randomIndex];

//            // 選択したシーンをロード
//            SceneManager.LoadScene(selectedScene);
//        }
//    }
//}