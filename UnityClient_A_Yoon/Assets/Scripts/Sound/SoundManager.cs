using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;        //Audio ���� ��� �߰� 

[System.Serializable]
public class Sound                  //���� Ŭ���� ���� 
{
    public string name;         //������ �̸�
    public AudioClip clip;      //���� Ŭ��
    
    [Range(0f, 1f)]                 //0�� 1���̰����� ���� �����ϰ�
    public float volume = 1f;       //���� ����

    [Range(0.1f, 3f)]
    public float pitch = 1f;        //���� ��ġ
    public bool loop;               //�ݺ� ��� ����
    public AudioMixerGroup mixerGroup;          //����� �ͼ� �׷�

    public AudioSource source;          //����� �ҽ�
}

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;            //�̱��� (��𼭵� ���� �����ϰ�)

    public List<Sound> sounds = new List<Sound>();  //���� ����Ʈ ����
    public AudioMixer audioMixer;                   //����� �ͼ� ����

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);                  //Scene�� �̵��ǵ� �ı� ���� �ʰ� �ϱ� ���ؼ� 
        }
        else
        {
            Destroy(gameObject);
        }

        foreach(Sound sound in sounds) 
        {
            sound.source = gameObject.AddComponent<AudioSource>();
            sound.source.clip = sound.clip;
            sound.source.volume = sound.volume;
            sound.source.pitch = sound.pitch;
            sound.source.loop = sound.loop;
            sound.source.outputAudioMixerGroup = sound.mixerGroup;  //����� �ͼ� �׷� ���� 
        }
        
    }

    public void PlaySound(string name)      //���� ��� �Լ� 
    {
        Sound soundToPlay = sounds.Find(sound => sound.name == name);   //���� ����Ʈ���� �μ��� �޾ƿ� �̸��� ���� ���带 ã�´�.
                                                                        
        if (soundToPlay != null) 
        {
            soundToPlay.source.Play();
        }
        else
        {
            Debug.LogWarning("���� " + name + " ã�� �� �����ϴ�.");
        }
                                                                    
    }

}
