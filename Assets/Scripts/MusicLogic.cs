using UnityEngine;

public class MusicLogic : MonoBehaviour
{
    [SerializeField] AudioSource music;
    [SerializeField] AudioSource pit;
    [SerializeField] AudioSource shatter;
    [SerializeField] AudioSource elevator;

    private void OnEnable()
    {
        PlayerCollision.PlayerFallsInPit += PitSounds;
        SoulLogic.SoulShattered += ShatterSounds;
        SoulLogic.SoulInElevator += ElevatorSounds;
    }

    private void OnDisable()
    {
        PlayerCollision.PlayerFallsInPit -= PitSounds;
        SoulLogic.SoulShattered -= ShatterSounds;
        SoulLogic.SoulInElevator -= ElevatorSounds;
    }

    private void PitSounds()
    {
        music.Stop();
        pit.Play();
    }

    private void ShatterSounds()
    {
        music.Stop();
        shatter.Play();
    }

    private void ElevatorSounds()
    {
        music.Stop();
        elevator.Play();
    }


}
