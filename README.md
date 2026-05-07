# Wack-A-Mole Project
>The objective of this project is to design and develop a small wack-a-mole style feature-complete prototype game on unity that simulates the classic core mechanic of wacking for  points. The game will also integrate essential gameplay systems such as player movement, camera control, dialogue interactions, menus, and a basic saving/loading system.
### Team Members
1. Sophie as the director and author
2. Tylor as the core game developer
3. Lacklan as the GUI/UI and HUD developer
### Branching Naming Conventions
When working with GitHub, using consistent naming conventions for branches can improve collaboration and maintain clarity in your version control workflow. Here are some commonly followed naming conventions for branches:

### Feature Branch
Format: - feature/{feature-name}
Example: - feature/user-authentication

### Bugfix Branches
Format: - bugfix/{bug-description}
Example: - bugfix/fix-login-error

### Release Branches
Format: - release/{version-number}
Example: - release/v1.2.0

### Commit names
**Every <ins>github commit</ins> should start with one of the following words:**

1. Modification: when a new code is added or removed. Designate the file and the purpose of the modification.
2. Fix: when a specific bug is fixed.
3. File change: if files are added or removed.
4. Refactor: improved code without changing its behaviour
5. UI: Add or modify UI Elements

## Features

### Main Menu
- [ ] Allows the player to Start New Game or Exit.
- [ ] Display a Title and Players current High Score.

### High Score Save and Load 
- [ ] save the players highest score.

### Game Over Screen & Restart 
- [ ] A game over screen that shows the players final score as well as the current high score.
- [ ] The game over screen appears when the countdown timmer reaches 0.
- [ ] The player is given the option to play again or to return to the main menu. 
- [ ] Game over screen highlights with new high score.

### Mole Pop-Up System 
- [ ] Moles randomly appear from a grid of holes displayed on screen 
- [ ] Each mole is visible for a short duration of time before disapearing into the hole 
- [ ] Only one mole active at a time 
- [ ] Number of active moles increase with the difficulty 
- [ ] Pop-up timing is randomized to remain unpredictable to the player 
### Player Click and Hit Detection 
- [ ] Player interacts with the game by clicking on visible moles by using the mouse 
- [ ] A successful hit is when the player clicks the mole before it has retreated
- [ ] Visual feedback for when you have had a successful hit
### Score System 
- [ ] Successful hit adds points to the players running score 
- [ ] Current score is displayed on screen 
- [ ] Bonus points are rewarded for faster reactions 
- [ ] Missed moles are tracked for difficulty scaling

### Countdown Timer 
- [ ] Visible countdown timer that starts with a new game 
- [ ] The timer countsdown from a set duration 
### Difficulty Scaling 
- [ ] The speed of the moles increases the further into t he game a player gets
- [ ] The number of simultaneously active moles increases at set time intervals 
- [ ] Visual or Audio cue signifying difficulty rising 
- [ ] A high number of missed moles decreases the difficulty
### Hole Grid Layout & Visual Feedback 
- [ ] Grid of moles are clearly displayed on screen 
- [ ] Each hole has an idle and active state that visually indicates when a mole is present
- [ ] The game is styles after an arcade game 
- [ ] Visual representation of visual hits or misses 
