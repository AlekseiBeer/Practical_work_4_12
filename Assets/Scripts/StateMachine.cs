
using UnityEngine;

public class StateMachine : MonoBehaviour
{

    [SerializeField] private GameObject _firstScreen;
    [SerializeField] private GameObject _secondScreen;

    private GameObject _currentScreen;
    void Start()
    {
        _firstScreen.SetActive(true);
        _currentScreen = _firstScreen;
    }

    // Update is called once per frame
    public void ChangeState(GameObject state)
    {
        if (_currentScreen != null)
        {
            _currentScreen.SetActive(false);
            state.SetActive(true);
            _currentScreen = state;
        }
    }
}
