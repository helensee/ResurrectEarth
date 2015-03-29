using UnityEngine;
using System.Collections;


namespace llamaStatus{
	public class llamaStatus : MonoBehaviour {

		public int totalWater { get; set; }
		public int totalDirt { get; set; }

		public llamaStatus(int totalWater, int totalDirt){
			totalWater = 0;
			totalDirt = 0;
		}

		void Start(){
		}

	}
}
