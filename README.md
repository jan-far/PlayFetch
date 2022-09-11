# Unity

### Challenge 2 - Play Fetch

Use your array and random number generation skills to program this challenge where balls are randomly falling from the sky and you have to send your dog out to catch them before they hit the ground. To complete this challenge, you will have to make sure your variables are assigned properly, your if-statements are programmed correctly, your collisions are being detected perfectly, and that objects are being generated randomly.

### Solution to the Play Fetch Challenge

- A random ball (of 3) is generated at random intervals at random x position above the screen
- When the user presses spacebar, a dog is spawned and runs to catch the ball
- User cannot spam the screen with dogs, have to wait for random seconds
- If the dog collides with the ball, the ball is destroyed
- If the ball hits the ground, a “Game Over” debug message is displayed
- The dogs and balls are removed from the scene when they leave the screen
