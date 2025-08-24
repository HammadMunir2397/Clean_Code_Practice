using UnityEngine;

public class Testing : MonoBehaviour
{
    public Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        if (!PlayerPrefs.HasKey(PrefsKeys.HighScore))
            PlayerPrefs.SetInt(PrefsKeys.HighScore, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Tags.Player))
            Debug.Log("Player entered!");
        animator.SetTrigger(AnimParams.Jump);
        if (other.CompareTag(Tags. Enemy))
            Debug.Log("Enemy detected!");
        animator.SetBool(AnimParams.IsRunning, true); 
    }
      
}
