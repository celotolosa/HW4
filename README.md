# HW4
## Devlog
In this project, the model-view control pattern is utilized in this project to keep the code decoupled from other systems with the use of events and a locator. The events are essentially "subscribed" to by other classes, and methods are called when invoked. The player class defines the control side of the pattern, everytime the player triggers the counter barrier (which is what I called it), other classes (UI, Audio) are viewing this side of the pattern and responding. 

Events and singletons are used in my code to ensure the view and control aspects of my game are decoupled by only invoking an event, and having other classes "subscribe" to it. For example in the UI class, in the start method, I wrote "Locator.Player.Point += HandPlayerPass; In doing this, everytime the player's method gets called with the invoke signature, the haldplayerpass method within UI will be called as well.

## Open-Source Assets
If you added any other assets, list them here!
- [Brackey's Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - sound effects
- [2D pixel art seagull sprites](https://elthen.itch.io/2d-pixel-art-seagull-sprites) - seagull sprites