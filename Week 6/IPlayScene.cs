using System;
using System.Threading.Tasks;

namespace echo_main.user_controls.playscene
{
    public interface IPlayScene
    {
        event EventHandler Finish;
        /// <summary>
        /// Start the playscene, mostly start the stopwatch
        /// </summary>
        void Start();

        /// <summary>
        /// Stop the scene (game)
        /// </summary>
        void Stop();

        /// <summary>
        /// Check if the input is correct and execute the equivalent effect
        /// </summary>
        /// <param name="input">Player's input</param>
        /// <param name="answer">The correct answer</param>
        void Check(string input, string answer);

        /// <summary>
        /// Move to the next question. Return false if not available. This method should be awaited
        /// </summary>
        Task<bool> Next();

        /// <summary>
        /// Add text (mostly special symbol) to the answer textbox
        /// </summary>
        /// <param name="text">The additional text</param>
        void AddTextToAnswer(string text);
    }
}
