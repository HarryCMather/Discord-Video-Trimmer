using Discord.Video.Trimmer.Views.Components;

namespace Discord.Video.Trimmer.Unit.Tests.Views.Components;

[TestFixture]
public class ConditionalContentViewTests
{
    private static Label CreateTestLabel(string text)
    {
        return new Label
        {
            Text = text
        };
    }
    
    [Test]
    [TestCase(true, "True text")]
    [TestCase(false, "False text")]
    public void Condition_GivenConditionMatchesView_DisplaysConditionContent(bool condition, string expectedText)
    {
        // Arrange:
        Label trueLabel = CreateTestLabel("True text");
        Label falseLabel = CreateTestLabel("False text");

        ConditionalContentView conditionalView = new()
        {
            True = trueLabel,
            False = falseLabel,
            Condition = condition
        };

        // Act:
        string displayedLabelText = (conditionalView.Content as Label)?.Text;

        // Assert:
        Assert.That(displayedLabelText, Is.EqualTo(expectedText));
    }
}
