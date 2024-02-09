using Xunit;

namespace GreetingLibrary.Test
{
	public class GreetingGeneratorTests
	{
		[Theory]
		[InlineData("Mr.", "Corey", 0, "Good night Mr. Corey")]
		[InlineData("Mr.", "Corey", 1, "Good night Mr. Corey")]
		[InlineData("Mr.", "Corey", 2, "Good night Mr. Corey")]
		[InlineData("Mr.", "Corey", 3, "Good night Mr. Corey")]
		[InlineData("Mr.", "Corey", 4, "Good night Mr. Corey")]
		[InlineData("Mr.", "Corey", 5, "Good night Mr. Corey")]
		[InlineData("Mr.", "Corey", 6, "Good morning Mr. Corey")]
		[InlineData("Mr.", "Corey", 7, "Good morning Mr. Corey")]
		[InlineData("Mr.", "Corey", 8, "Good morning Mr. Corey")]
		[InlineData("Mr.", "Corey", 9, "Good morning Mr. Corey")]
		[InlineData("Mr.", "Corey", 10, "Good morning Mr. Corey")]
		[InlineData("Mr.", "Corey", 11, "Good morning Mr. Corey")]
		[InlineData("Mrs.", "Corey", 12, "Good afternoon Mrs. Corey")]
		[InlineData("Mrs.", "Corey", 13, "Good afternoon Mrs. Corey")]
		[InlineData("Mrs.", "Corey", 14, "Good afternoon Mrs. Corey")]
		[InlineData("Mrs.", "Corey", 15, "Good afternoon Mrs. Corey")]
		[InlineData("Mrs.", "Corey", 16, "Good afternoon Mrs. Corey")]
		[InlineData("Mrs.", "Corey", 17, "Good afternoon Mrs. Corey")]
		[InlineData("Mr.", "Corey", 18, "Good evening Mr. Corey")]
		[InlineData("Mr.", "Corey", 19, "Good evening Mr. Corey")]
		[InlineData("Mr.", "Corey", 20, "Good evening Mr. Corey")]
		[InlineData("Mr.", "Corey", 21, "Good evening Mr. Corey")]
		[InlineData("Mr.", "Corey", 22, "Good evening Mr. Corey")]
		[InlineData("Mr.", "Corey", 23, "Good evening Mr. Corey")]
		public void GreetingGeneratorTest(string prefix, string lastName, int hourOfDay, string expected)
		{
			// Arrange
			GreetingGenerator greetings = new GreetingGenerator();

			// Act
			string actual = greetings.GenerateGreeting(prefix, lastName, hourOfDay);

			// Assert
			Assert.Equal(expected, actual);
		}
	}
}
