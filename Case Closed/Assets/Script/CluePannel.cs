using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CluePannel : MonoBehaviour
{
    [SerializeField] Button dropdownBtn, hideDropdownBtn;
    Animator animator;

    public void OnClickDropdownPannel()
    {
        animator.SetBool("isClosing", false);
        animator.SetBool("isOpening", true);
        Debug.Log("show clicked");
        dropdownBtn.gameObject.SetActive(false);
        hideDropdownBtn.gameObject.SetActive(true);
    }

    public void OnClickHideDropdownPannel()
    {
        animator.SetBool("isOpening", false);
        animator.SetBool("isClosing", true);
        Debug.Log("hide clicked");
        hideDropdownBtn.gameObject.SetActive(false);
        dropdownBtn.gameObject.SetActive(true);
    }

    void Awake()
    {
        dropdownBtn.onClick.AddListener(OnClickDropdownPannel);
        hideDropdownBtn.onClick.AddListener(OnClickHideDropdownPannel);
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
