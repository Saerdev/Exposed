using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D {
	[RequireComponent(typeof(PlatformerCharacter2D))]
	public class Platformer2DUserControl : MonoBehaviour {
		private PlatformerCharacter2D m_Character;
		private bool m_Jump;
		private bool crouch;

		private void Awake() {
			m_Character = GetComponent<PlatformerCharacter2D>();
		}

		private void Update() {
			m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
			crouch = Input.GetKey(KeyCode.LeftControl);
			float h = CrossPlatformInputManager.GetAxisRaw("Horizontal");
			float v = CrossPlatformInputManager.GetAxisRaw("Vertical");

			m_Character.Move(h, crouch, m_Jump, v);
		}
	}
}
