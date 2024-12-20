using UnityEngine;
using UnityEngine.SceneManagement;

public class SequentialSceneSwitcher : MonoBehaviour
{
    public string[] sceneNames; // 遷移対象のシーン名の配列
    public float minSwitchTime = 10f; // 最小遷移時間（秒）
    public float maxSwitchTime = 30f; // 最大遷移時間（秒）

    private float timer;
    private float targetTime;
    private int currentIndex = 0; // 現在のシーンのインデックス

    void Start()
    {
        SetRandomSwitchTime(); // ランダムな遷移時間を設定
        timer = 0f; // タイマーを初期化

        // 現在のシーンのインデックスを特定
        string currentSceneName = SceneManager.GetActiveScene().name;
        for (int i = 0; i < sceneNames.Length; i++)
        {
            if (sceneNames[i] == currentSceneName)
            {
                currentIndex = i;
                break;
            }
        }
    }

    void Update()
    {
        // タイマーを進める
        timer += Time.deltaTime;

        // 指定された時間が経過したら次のシーンに切り替える
        if (timer >= targetTime)
        {
            SwitchToNextScene();
            timer = 0f; // タイマーをリセット
            SetRandomSwitchTime(); // 次の遷移時間を再設定
        }
    }

    void SetRandomSwitchTime()
    {
        // 10秒から30秒の間でランダムな時間を設定
        targetTime = Random.Range(minSwitchTime, maxSwitchTime);
    }

    void SwitchToNextScene()
    {
        if (sceneNames.Length == 0)
        {
            Debug.LogWarning("シーン名の配列が空です。");
            return;
        }

        // 次のシーンのインデックスを計算
        currentIndex = (currentIndex + 1) % sceneNames.Length;
        string nextScene = sceneNames[currentIndex];

        // シーンを切り替える
        SceneManager.LoadScene(nextScene);
    }
}
