using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource musicSource;       // Аудиоисточник для музыки
    public AudioSource[] soundSources;    // Массив аудиоисточников для звуков

    private bool isMuted;

    public GameObject muteButton;         // Кнопка отключения звука
    public GameObject unmuteButton;       // Кнопка включения звука

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);  // Не уничтожать объект при переходе между сценами
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // Проверяем сохраненный статус звука в PlayerPrefs
        if (PlayerPrefs.HasKey("Muted"))
        {
            isMuted = PlayerPrefs.GetInt("Muted") == 1;
        }
        else
        {
            isMuted = false;
        }

        ApplyMuteStatus();
        UpdateButtons();  // Обновляем кнопки в зависимости от статуса звука
        Debug.Log("Sound status on start: " + (isMuted ? "Muted" : "Unmuted"));
    }

    // Метод для отключения звука и музыки
    public void MuteAll()
    {
        isMuted = true;
        PlayerPrefs.SetInt("Muted", 1);
        ApplyMuteStatus();
        UpdateButtons();  // Обновляем кнопки при изменении звука
        Debug.Log("Muted all sounds");
    }

    // Метод для включения звука и музыки
    public void UnmuteAll()
    {
        isMuted = false;
        PlayerPrefs.SetInt("Muted", 0);
        ApplyMuteStatus();
        UpdateButtons();  // Обновляем кнопки при изменении звука
        Debug.Log("Unmuted all sounds");
    }

    // Применяем текущий статус звука ко всем аудиоисточникам
    private void ApplyMuteStatus()
    {
        float volume = isMuted ? 0 : 1;  // Если выключено - громкость 0, иначе - 1

        musicSource.volume = volume;

        foreach (AudioSource soundSource in soundSources)
        {
            soundSource.volume = volume;
        }
    }

    // Обновляем состояние кнопок на основе статуса звука
    private void UpdateButtons()
    {
        if (isMuted)
        {
            muteButton.SetActive(false);   // Скрываем кнопку отключения звука
            unmuteButton.SetActive(true);  // Показываем кнопку включения звука
        }
        else
        {
            muteButton.SetActive(true);    // Показываем кнопку отключения звука
            unmuteButton.SetActive(false); // Скрываем кнопку включения звука
        }
    }

    // Метод для тестирования звуков
    public void PlaySound(int index)
    {
        if (index >= 0 && index < soundSources.Length)
        {
            soundSources[index].Play();
            Debug.Log("Playing sound " + index);
        }
    }
}



