Feature: FooSpeaks
	In order for foo to be existing
	foo should be able to speak and when it speaks
	foo says foobar

@FooSpeaks
Scenario: Foo speaks
	Given is Foo
	When Foo says something
	Then foo should say 'foobar'