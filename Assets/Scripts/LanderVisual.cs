using UnityEngine;

public class LanderVisual : MonoBehaviour
{

    [SerializeField] private ParticleSystem leftThrusterParticleSystem;
    [SerializeField] private ParticleSystem middleThrusterParticleSystem;
    [SerializeField] private ParticleSystem rightThrusterParticleSystem;

    private void Start()
    {
        ParticleSystem.EmissionModule emissionModule = leftThrusterParticleSystem.emission;
        emissionModule.enabled = false;
    }


}
