using Math.DivisorHelper
using System.Collections.Generic;

namespace Games.NumbersGame
{
    // Alice and Bob take turns playing a game, with Alice starting first.
    // Initially, there is a number n on the chalkboard. On each player's turn, 
    // that player makes a move consisting of:
    // Choosing any x with 0 < x < n and n % x == 0.
    // Replacing the number n on the chalkboard with n - x.
    // Also, if a player cannot make a move, they lose the game.
    // Return true if and only if Alice wins the game, assuming both players play optimally.

    // Example 1:
    // Input: n = 2
    // Output: true
    // Explanation: Alice chooses 1, and Bob has no more moves.

    // Example 2:
    // Input: n = 3
    // Output: false
    // Explanation: Alice chooses 1, Bob chooses 1, and Alice has no more moves.
    
    // Constraints:
    // 1 <= n <= 1000
    public class DivisorGame
    {
        // Returns true if the first player whens the game
        // Time Complexity: O(1) – The solution only checks if the number is even, which is a constant-time operation.
        // Space Complexity: O(1) – The space used is constant as no additional data structures are required.
        public bool DivisorGame(int n) {
            // Alice wins if n is even, because she can always subtract 1 and leave an odd number for Bob.
            // If n is odd, Alice loses because any move will leave an even number for Bob.
            return n % 2 == 0;
        }
    }
}