using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private Animator animator;
    public bool IsMoving { private get; set; }
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isRunning", IsMoving);
    }
}
