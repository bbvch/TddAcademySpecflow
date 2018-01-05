namespace TddAcademy.Specs
{
    using FluentAssertions;

    using TechTalk.SpecFlow;

    [Binding]
    public class FooSpeaksSteps
    {
        private Foo foo;
        private string actual;

        [Given(@"is Foo")]
        public void GivenIsFoo()
        {
            this.foo = new Foo(new Bar());
        }
        
        [When(@"Foo says something")]
        public void WhenFooSaysSomething()
        {
            this.actual = this.foo.Say();
        }
        
        [Then(@"foo should say '(.*)'")]
        public void ThenFooShouldSay(string expected)
        {
            this.actual.Should().Be(expected);
        }
    }
}
