using UnityEngine;
using System.Collections;
using VRStandardAssets.Utils;

namespace VRStandardAssets.Intro
{
    // The intro scene takes users through the basics
    // of interacting through VR in the other scenes.
    // This manager controls the steps of the intro
    // scene.
    public class IntroManager : MonoBehaviour
    {
        [SerializeField] private Reticle m_Reticle;                         // The scene only uses SelectionSliders so the reticle should be shown.
        [SerializeField] private SelectionRadial m_Radial;                  // Likewise, since only SelectionSliders are used, the radial should be hidden.

        [SerializeField] private UIFader m_HowToUseFader;                   // This fader controls the UI showing how to use SelectionSliders.
        [SerializeField] private SelectionSlider m_HowToUseSlider;          // This is the slider that is used to demonstrate how to use them.

        [SerializeField] private UIFader m_HowToUseConfirmFader;            // Afterwards users are asked to confirm how to use sliders in this UI.
        [SerializeField] private SelectionSlider m_HowToUseConfirmSlider;   // They demonstrate this using this slider.




		[SerializeField] private SelectionSlider m_QOneSliderSelectA;     // SELECTS THE SLIDER TO USE
		[SerializeField] private UIFader m_QOneFadera;						//FADES OUT THE SCENE

		[SerializeField] private SelectionSlider m_QTwoSliderSelect;
		[SerializeField] private UIFader m_QTEOFader;

		[SerializeField] private SelectionSlider m_QThreeSliderSelect;
		[SerializeField] private UIFader m_QTHREEFader;

		[SerializeField] private SelectionSlider m_QFourSliderSelect;
		[SerializeField] private UIFader m_QFourFader;

		[SerializeField] private SelectionSlider m_QFiveSliderSelect;
		[SerializeField] private UIFader m_QFiveFader;

		[SerializeField] private SelectionSlider m_QSixSliderSelect;
		[SerializeField] private UIFader m_QSixFader;

		[SerializeField] private SelectionSlider m_QSevenSliderSelect;
		[SerializeField] private UIFader m_QSevenFader;

		[SerializeField] private SelectionSlider m_QEightSliderSelect;
		[SerializeField] private UIFader m_QEightFader;

		[SerializeField] private SelectionSlider m_QNineSliderSelect;
		[SerializeField] private UIFader m_QNineFader;

		[SerializeField] private SelectionSlider m_QTenSliderSelect;
		[SerializeField] private UIFader m_QTenFader;

	


        [SerializeField] private UIFader m_ReturnFader;                     // The final instructions are controlled using this fader.



        private IEnumerator Start ()
        {
            m_Reticle.Show ();
            
            m_Radial.Hide ();

            // In order, fade in the UI on how to use sliders, wait for the slider to be filled then fade out the UI.
            yield return StartCoroutine (m_HowToUseFader.InteruptAndFadeIn ());
            yield return StartCoroutine (m_HowToUseSlider.WaitForBarToFill ());
            yield return StartCoroutine (m_HowToUseFader.InteruptAndFadeOut ());
		

            // In order, fade in the UI on confirming the use of sliders, wait for the slider to be filled, then fade out the UI.
            yield return StartCoroutine(m_HowToUseConfirmFader.InteruptAndFadeIn());
            yield return StartCoroutine(m_HowToUseConfirmSlider.WaitForBarToFill());
            yield return StartCoroutine(m_HowToUseConfirmFader.InteruptAndFadeOut());


			//1
			yield return StartCoroutine (m_QOneFadera.InteruptAndFadeIn ());
			yield return StartCoroutine (m_QOneSliderSelectA.WaitForBarToFill ());
			yield return StartCoroutine (m_QOneFadera.InteruptAndFadeOut());



			//2
			yield return StartCoroutine (m_QTEOFader.InteruptAndFadeIn ());
			yield return StartCoroutine ( m_QTwoSliderSelect.WaitForBarToFill ());
			yield return StartCoroutine (m_QTEOFader.InteruptAndFadeOut());



		//3
			yield return StartCoroutine (m_QTHREEFader.InteruptAndFadeIn ());
			yield return StartCoroutine ( m_QThreeSliderSelect.WaitForBarToFill ());
			yield return StartCoroutine (m_QTHREEFader.InteruptAndFadeOut());

			//4
			yield return StartCoroutine (m_QFourFader.InteruptAndFadeIn ());
			yield return StartCoroutine ( m_QFourSliderSelect.WaitForBarToFill ());
			yield return StartCoroutine (m_QFourFader.InteruptAndFadeOut());

			//5
			yield return StartCoroutine (m_QFiveFader.InteruptAndFadeIn ());
			yield return StartCoroutine ( m_QFiveSliderSelect.WaitForBarToFill ());
			yield return StartCoroutine (m_QFiveFader.InteruptAndFadeOut());

			//6
			yield return StartCoroutine (m_QSixFader.InteruptAndFadeIn ());
			yield return StartCoroutine ( m_QSixSliderSelect.WaitForBarToFill ());
			yield return StartCoroutine (m_QSixFader.InteruptAndFadeOut());

			//7
			yield return StartCoroutine (m_QSevenFader.InteruptAndFadeIn ());
			yield return StartCoroutine ( m_QSevenSliderSelect.WaitForBarToFill ());
			yield return StartCoroutine (m_QSevenFader.InteruptAndFadeOut());

			//8
			yield return StartCoroutine (m_QEightFader.InteruptAndFadeIn ());
			yield return StartCoroutine ( m_QEightSliderSelect.WaitForBarToFill ());
			yield return StartCoroutine (m_QEightFader.InteruptAndFadeOut());

			//9
			yield return StartCoroutine (m_QNineFader.InteruptAndFadeIn ());
			yield return StartCoroutine ( m_QNineSliderSelect.WaitForBarToFill ());
			yield return StartCoroutine (m_QNineFader.InteruptAndFadeOut());

			//10
			yield return StartCoroutine (m_QTenFader.InteruptAndFadeIn ());
			yield return StartCoroutine ( m_QTenSliderSelect.WaitForBarToFill ());
			yield return StartCoroutine (m_QTenFader.InteruptAndFadeOut());



            // Fade in the final UI.
            yield return StartCoroutine (m_ReturnFader.InteruptAndFadeIn ());
        }
    }
}