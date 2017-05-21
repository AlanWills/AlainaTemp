using UnityEngine;
using System.Collections;
using VRStandardAssets.Utils;
using System;

namespace VRStandardAssets.Intro
{
    // The intro scene takes users through the basics
    // of interacting through VR in the other scenes.
    // This manager controls the steps of the intro
    // scene.
    public class IntroManager : MonoBehaviour
    {
        [SerializeField]
        private Reticle m_Reticle;                         // The scene only uses SelectionSliders so the reticle should be shown.
        [SerializeField]
        private SelectionRadial m_Radial;                  // Likewise, since only SelectionSliders are used, the radial should be hidden.

        [SerializeField]
        private UIFader m_HowToUseFader;                   // This fader controls the UI showing how to use SelectionSliders.
        [SerializeField]
        private SelectionSlider m_HowToUseSlider;          // This is the slider that is used to demonstrate how to use them.

        [SerializeField]
        private UIFader m_HowToUseConfirmFader;            // Afterwards users are asked to confirm how to use sliders in this UI.
        [SerializeField]
        private SelectionSlider m_HowToUseConfirmSlider;   // They demonstrate this using this slider.




        [SerializeField]
        private SelectionSlider m_questionOneLeftSlider;
        [SerializeField]
        private SelectionSlider m_questionOneRightSlider;
        [SerializeField]
        private UIFader m_questionOneFader;
        
        [SerializeField]
        private SelectionSlider m_questionTwoLeftSlider;
        [SerializeField]
        private SelectionSlider m_questionTwoRightSlider;
        [SerializeField]
        private UIFader m_questionTwoFader;

        [SerializeField]
        private SelectionSlider m_questionThreeLeftSlider;
        [SerializeField]
        private SelectionSlider m_questionThreeRightSlider;
        [SerializeField]
        private UIFader m_questionThreeFader;

        [SerializeField]
        private SelectionSlider m_questionFourLeftSlider;
        [SerializeField]
        private SelectionSlider m_questionFourRightSlider;
        [SerializeField]
        private UIFader m_questionFourFader;

        [SerializeField]
        private SelectionSlider m_questionFiveLeftSlider;
        [SerializeField]
        private SelectionSlider m_questionFiveRightSlider;
        [SerializeField]
        private UIFader m_questionFiveFader;

        [SerializeField]
        private SelectionSlider m_questionSixLeftSlider;
        [SerializeField]
        private SelectionSlider m_questionSixRightSlider;
        [SerializeField]
        private UIFader m_questionSixFader;

        [SerializeField]
        private SelectionSlider m_questionSevenLeftSlider;
        [SerializeField]
        private SelectionSlider m_questionSevenRightSlider;
        [SerializeField]
        private UIFader m_questionSevenFader;

        [SerializeField]
        private SelectionSlider m_questionEightLeftSlider;
        [SerializeField]
        private SelectionSlider m_questionEightRightSlider;
        [SerializeField]
        private UIFader m_questionEightFader;

        [SerializeField]
        private SelectionSlider m_questionNineLeftSlider;
        [SerializeField]
        private SelectionSlider m_questionNineRightSlider;
        [SerializeField]
        private UIFader m_questionNineFader;

        [SerializeField]
        private SelectionSlider m_questionTenLeftSlider;
        [SerializeField]
        private SelectionSlider m_questionTenRightSlider;
        [SerializeField]
        private UIFader m_questionTenFader;

        [SerializeField]
        private UIFader m_ReturnFader;                     // The final instructions are controlled using this fader.



        private IEnumerator Start()
        {
            m_Reticle.Show();

            m_Radial.Hide();

            // In order, fade in the UI on how to use sliders, wait for the slider to be filled then fade out the UI.
            yield return StartCoroutine(m_HowToUseFader.InteruptAndFadeIn());
            yield return StartCoroutine(m_HowToUseSlider.WaitForBarToFill());
            yield return StartCoroutine(m_HowToUseFader.InteruptAndFadeOut());

            // In order, fade in the UI on confirming the use of sliders, wait for the slider to be filled, then fade out the UI.
            yield return StartCoroutine(m_HowToUseConfirmFader.InteruptAndFadeIn());
            yield return StartCoroutine(m_HowToUseConfirmSlider.WaitForBarToFill());
            yield return StartCoroutine(m_HowToUseConfirmFader.InteruptAndFadeOut());

            //1
            yield return StartCoroutine(m_questionOneFader.InteruptAndFadeIn());
            yield return StartCoroutine(WaitForBarToFill(m_questionOneLeftSlider, m_questionOneRightSlider));
            yield return StartCoroutine(m_questionOneFader.InteruptAndFadeOut());

            //2
            yield return StartCoroutine(m_questionTwoFader.InteruptAndFadeIn());
            yield return StartCoroutine(WaitForBarToFill(m_questionTwoLeftSlider, m_questionTwoRightSlider));
            yield return StartCoroutine(m_questionTwoFader.InteruptAndFadeOut());

            //3
            yield return StartCoroutine(m_questionThreeFader.InteruptAndFadeIn());
            yield return StartCoroutine(WaitForBarToFill(m_questionThreeLeftSlider, m_questionThreeRightSlider));
            yield return StartCoroutine(m_questionThreeFader.InteruptAndFadeOut());

            //4
            yield return StartCoroutine(m_questionFourFader.InteruptAndFadeIn());
            yield return StartCoroutine(WaitForBarToFill(m_questionFourLeftSlider, m_questionFourRightSlider));
            yield return StartCoroutine(m_questionFourFader.InteruptAndFadeOut());
            
            //5
            yield return StartCoroutine(m_questionFiveFader.InteruptAndFadeIn());
            yield return StartCoroutine(WaitForBarToFill(m_questionFiveLeftSlider, m_questionFiveRightSlider));
            yield return StartCoroutine(m_questionFiveFader.InteruptAndFadeOut());

            //6
            yield return StartCoroutine(m_questionSixFader.InteruptAndFadeIn());
            yield return StartCoroutine(WaitForBarToFill(m_questionSixLeftSlider, m_questionSixRightSlider));
            yield return StartCoroutine(m_questionSixFader.InteruptAndFadeOut());

            //7
            yield return StartCoroutine(m_questionSevenFader.InteruptAndFadeIn());
            yield return StartCoroutine(WaitForBarToFill(m_questionSevenLeftSlider, m_questionSevenRightSlider));
            yield return StartCoroutine(m_questionSevenFader.InteruptAndFadeOut());

            //8
            yield return StartCoroutine(m_questionEightFader.InteruptAndFadeIn());
            yield return StartCoroutine(WaitForBarToFill(m_questionEightLeftSlider, m_questionEightRightSlider));
            yield return StartCoroutine(m_questionEightFader.InteruptAndFadeOut());

            //9
            yield return StartCoroutine(m_questionNineFader.InteruptAndFadeIn());
            yield return StartCoroutine(WaitForBarToFill(m_questionNineLeftSlider, m_questionNineRightSlider));
            yield return StartCoroutine(m_questionNineFader.InteruptAndFadeOut());

            //10
            yield return StartCoroutine(m_questionTenFader.InteruptAndFadeIn());
            yield return StartCoroutine(WaitForBarToFill(m_questionTenLeftSlider, m_questionTenRightSlider));
            yield return StartCoroutine(m_questionTenFader.InteruptAndFadeOut());

            // Fade in the final UI.
            yield return StartCoroutine (m_ReturnFader.InteruptAndFadeIn ());
        }

        private IEnumerator WaitForBarToFill(SelectionSlider leftSlider, SelectionSlider rightSlider)
        {
            while (!leftSlider.BarFilled && !rightSlider.BarFilled)
            {
                yield return null;
            }
        }
    }
}