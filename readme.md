nUnit fundamentals practice solution
---

We have a class library project, MyLib with MyClass.
Objective: Create a test project with some basic tests and test setup.

1. What is the name convention for:
	a. a test assembly
	b. a test class
	c. a test method
2. Create a test assembly for MyLib
	a. what should be the name?
	b. add nunit to the assembly
3. Create a test fixture - for MyClass
	a. what the name should be
	b. what attribute do you apply?
	c. add instance field to keep MyClass
4. What is constraint vs classic model for assert - overview.
5. Add single unit test for Add(): 1+2=3
	a. what the name should be?
	b. test it
6. Test setup and tear down - for each test
	a. simple name conventions
	b. public/private? instance/static? async?
	c. add methods that will be called before and after each test
	Create an instance of MyClass and set it to null.
	d. Is the tear down method guaranteed to run?
7. The same for one-time setup and tear-down, leave them empty.
8. Add the second test, for divide, e.g. 10/2 = 5
9. Expected exceptions: Add a test method that checks that:
	a. when you Divide() by zero, you get ArgumentException
	b. the ArgumentException should have ParamName == "b"
	c. how do you catch exactly the specified exception type and how any of derived exceptions
Add some description to this test:  "When the divisor is zero the method should throw ArgumentException with the b argument specified in it."
10. Make any of the test ignored, with the reason "Suspended until issue #123 resolved."
	a. how do you ignore the whole test fixture?
