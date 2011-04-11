using Bddify.Core;
using NUnit.Framework;

namespace StoryDemo
{
    [Story(
        "Calculator can do the four main functions",
        "As a second grader",
        "I want a calculator with four main functions",
        "So I do not have to learn to calculate!!")]
    public class CalculatorStory
    {
        [Test]
        public void Execute()
        {
            this.Bddify();
        }
    }
}