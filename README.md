# C# Coding Challenge #5: Pac-Man

Tracking five moving targets on your own can be quite tedious. It's good that for a computer it's a piece of cake. Or not?

Can you prove it?

![](https://github.com/AndreyM-DXC/CsPacmanChallenge/blob/main/banner.png?raw=true)

**Task:** Stay uncaught for as long as possible!

**Rules:**
* There is a classic Pac-Man level
* Eat all the dots placed in the maze
* Avoid four colored ghosts
   * 🟥 Hunter - constantly follows the player
   * 🟩 Stranger - wanders through the maze in random directions
   * 🟦 Guard - strives for the middle of all uncollected points
   * 🟪 Ambush - tries to intercept a player on the opposite side of the Hunter
* The bot that scores the most points wins
* The best solution will be rewarded with **loyalty points!**

**How to play:**

You can find the source code of Pac-Man game on GitHub:
[https://github.com/AndreyM-DXC/CsPacmanChallenge](https://github.com/AndreyM-DXC/CsPacmanChallenge)

It contains all the game logics and two sample bots:
* `RandomPlayer` - minimal bot example.
* `KeyboardPlayer` - not a bot, but human interface, so you can try to play by your own to feel the game.

**Goal:**

Implement the `IPlayer` interface so that the bot can play on its own and finish the game in reasonable time.

Feel free to use external libraries, but keep in mind that bot should be simple to assemble. 🤓

Please, share your solution with us via the mail (You can either attach an archive with the source code or share a link to public GitHub repository).

You can submit solutions till 19th of February EOD.