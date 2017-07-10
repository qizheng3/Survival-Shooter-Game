Name: Qi Zheng
Email: qzheng61@gatech.edu
GT Account: qzheng61


All three requirements have been completed.

Task 1
My Name has been added to the HUD (2D heads-up-display) of the game as shown in Figure 1.

Task 2
Modification 1: A Health Level bar has been created and added to the right lower corner of the scene to reflect the player’s real time health condition. Also, the color will be adjusted according to the player’s health condition. If health level drops = 60, the bar turns yellow (Figure 2). If the health level further drops = 30, the bar turns red (Figure 3).  A C# script file named HealthScoreManager.cs has been added to Scripts/Managers folder to reflect this change.

Modification 2: This game has been modified to give the player an option to exchange 100 scores for an increase of 20 health level if the player’s current health level is below 30. This action is envoked when the player press the Space key.
The following codes have been added to  void Update () in the PlayerHealth.cs  script.

if (ScoreManager.score > 100 && currentHealth < 30) {
	if (Input.GetKeyDown (KeyCode.Space)) {
		currentHealth += 20;
		ScoreManager.score -= 100;
	}
}

Task 3
The size of the 3D gameobject player will shrink to half of its original size when the health level drops below 50. This change can be viewed by comparing Figure 1 with 2 and 3. 
A Boolean variable has been added to the  PlayerHealth.cs  script.
private bool flag = true;
The following codes have been added to void Update ()

if (currentHealth < 50 && flag) {
	transform.localScale -= new Vector3 (0.5f, 0.5f, 0.5f);
	flag = false;
}


Summary
All three requirements/tasks have been done. Please feel free to play around with the game. There is no special installation required or any additional asset bundles that need to be downloaded.

Suggested Steps for Running/Grading the Game
1. Level 01 is the main sence.
2. Open the game, use "AWSD" keys for left-forward-backward-right movement.
3. Press left mouse for firing the gun.
4. Check the "Score" and "Health Level" texts for real-time sores and health conditions. Attention that the health level bar will change color according to the health condition.
5. When the player's health condition drops below 50, it will shrink to 50% of its original size.
6. Try to score more than 100 points, then wait until the player was damaged to a health level less than 30. Press the space key to exchange 100 score points for an increase of 20 health points. Note that when your health level drops below 50, there is no way to get back to more than 50, so the size of the player (character) will never get back to its original size.