using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LoadProgress0 : MonoBehaviour
{

    public Slider progressSlider;
    public Text progressText;
    private float SliderLoadSpeed = 1;
    // 场景加载类的对象
    private AsyncOperation operation;
    // 加载进度(由于加载进度不能为 1，所以需要此变量在加载进度大于某一个值时让加载进度变为1)
    private float targetValue;

    private void Start()
    {
        // 初始化进度条
        progressSlider.value = 0.0f;

        if (SceneManager.GetActiveScene().name == "LoadScene0")
        {
            // 启动协程
            StartCoroutine(AsyncLoading());
        }
    }

    private void Update()
    {
        // operation.progress 加载进度
        targetValue = operation.progress;

        if (operation.progress >= 0.9f)
        {
            // operation.progress的值最大为0.9
            targetValue = 1.0f;
        }

        if (targetValue != progressSlider.value)
        {
            // 插值运算（进度条向当前加载进度趋近）
            progressSlider.value = Mathf.Lerp(progressSlider.value, targetValue, Time.deltaTime * SliderLoadSpeed);
            // 避免插值运算一直进行
            if (Mathf.Abs(progressSlider.value - targetValue) < 0.01f)
            {
                progressSlider.value = targetValue;
            }
        }
        // 显示加载百分比
        progressText.text = ((int)(progressSlider.value * 100)).ToString() + "%";

        // 当进度条完成 100% 时，加载场景
        if ((int)(progressSlider.value * 100) == 100)
        {
            //允许异步加载完毕后自动切换场景
            operation.allowSceneActivation = true;
        }
    }

    IEnumerator AsyncLoading()
    {
        // 异步加载场景
        operation = SceneManager.LoadSceneAsync("IntroScene");
        // 阻止当加载完成自动切换
        operation.allowSceneActivation = false;

        yield return operation;
    }
}
