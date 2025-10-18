using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppManager : MonoBehaviour
{
    [Header("Main Screen Components")]
    public GameObject mainMenu;
    public GameObject coachHiringScreen;
    public GameObject coachDetailsScreen;

    [Header("Navigation Buttons")]
    public Button viewOffenseCoachButton;
    public Button fireOffenseCoachButton;
    public Button viewDefenseCoachButton;
    public Button fireDefenseCoachButton;
    public Button hiringCoachMarketButton;
    public Button performanceButton;
    public Button historyButton;

    private void Start()
    {
        // Assigning button clicks to corresponding screens
        viewOffenseCoachButton.onClick.AddListener(() => ShowScreen(coachDetailsScreen));
        fireOffenseCoachButton.onClick.AddListener(() => Debug.Log("Fire offence coach button was clicked"));
        viewDefenseCoachButton.onClick.AddListener(() => ShowScreen(coachDetailsScreen));
        fireDefenseCoachButton.onClick.AddListener(() => Debug.Log("Fire deffence coach button was clicked"));
        hiringCoachMarketButton.onClick.AddListener(() => ShowScreen(coachHiringScreen));
        performanceButton.onClick.AddListener(() => Debug.Log("Performance button was clicked"));
        historyButton.onClick.AddListener(() => Debug.Log("Hristory button was clicked"));

        ShowScreen(mainMenu); // Default starting screen
    }

    private void ShowScreen(GameObject targetScreen)
    {
        // Deactivate all
        mainMenu.SetActive(false);
        coachHiringScreen.SetActive(false);
        coachDetailsScreen.SetActive(false);

        // Activate the one you want
        if (targetScreen != null)
            targetScreen.SetActive(true);
    }
}

//     // Start is called before the first frame update
//     void Start()
//     {
//         // Assigning button clicks to different menus
//         hireCoachButton.onClick.AddListener(ShowCoachHiringScreen);
//         viewOffenseCoachButton.onClick.AddListener(ShowOffenseCoachDetails);
//         viewDefenseCoachButton.onClick.AddListener(ShowDefenseCoachDetails);
//         hiringCoachMarketButton.onClick.AddListener(ShowHiringMarket);
//         performanceButton.onClick.AddListener(ShowPerformanceScreen);
//         historyButton.onClick.AddListener(ShowHistoryScreen);

//         ShowMainMenu();
//     }

//     public void ShowMainMenu()
//     {
//         mainMenu.SetActive(true);
//         coachHiringScreen.SetActive(false);
//     }

//     public void ShowCoachHiringScreen()
//     {
//         mainMenu.SetActive(false);
//         coachHiringScreen.SetActive(true);
//     }

//     public void ShowOffenseCoachDetails()
//     {
//         mainMenu.SetActive(false);
//         CoachProfilePopulator coachProfilePopulator = FindObjectOfType<CoachProfilePopulator>();

//         // Load coach
//         if (coachProfilePopulator != null)
//         {
//             // coachProfilePopulator.coach.LoadCoachProfile("offense");
//         }
//         coachDetailsScreen.SetActive(true);
//     }

//     public void ShowDefenseCoachDetails()
//     {
//         mainMenu.SetActive(false);
//         CoachProfilePopulator coachProfilePopulator = FindObjectOfType<CoachProfilePopulator>();

//         // Load coach
//         if (coachProfilePopulator != null)
//         {
//             // coachProfilePopulator.coach.LoadCoachProfile("defense");
//         }
//         coachDetailsScreen.SetActive(true);
//     }

//     public void ShowHiringMarket()
//     {
//         mainMenu.SetActive(false);
//         coachHiringScreen.SetActive(true);
//     }

//     public void ShowPerformanceScreen()
//     {
//         mainMenu.SetActive(false);
//         coachDetailsScreen.SetActive(true);

//         // Populate the coach details UI
//     }

//     public void ShowHistoryScreen()
//     {
//         mainMenu.SetActive(false);
//         coachDetailsScreen.SetActive(true);

//         // Populate the coach details UI
//     }
// }