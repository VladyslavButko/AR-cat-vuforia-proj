using UnityEngine;
using UnityEngine.UI;

public class PlayerInput : MonoBehaviour
{
    private Animator animator;

    public Button idleButton;
    public Button walkButton;
    public Button runButton;

    private Color defaultColor = new Color(0.83f, 0.83f, 0.83f);
    private Color activeColor = new Color(0.64f, 0.79f, 0.66f);  

    private void Start()
    {
        animator = GetComponent<Animator>();

        SetIdle();
    }

    public void SetIdle()
    {
        SetAnimationState(0, "Idle", idleButton);
    }

    public void SetWalk()
    {
        SetAnimationState(1, "Walk", walkButton);
    }

    public void SetRun()
    {
        SetAnimationState(2, "Run", runButton);
    }

    private void SetAnimationState(int state, string animationName, Button activeButton)
    {
        animator.SetInteger("State", state);
        animator.CrossFade(animationName, 0.1f);

        ResetButtonColors();
        activeButton.image.color = activeColor;
    }

    private void ResetButtonColors()
    {
        idleButton.image.color = defaultColor;
        walkButton.image.color = defaultColor;
        runButton.image.color = defaultColor;
    }
}
