# csharpwebdeveloper

A simple contextual project to help the team access your brilliance. The solution is designed to help us get a quick insight into what you love about bulding great software.

## The scenario

We recently acquired a new customer in the Acme Zoo. They had a very interesting request. They asked us to build an animal library that they could plug into an existing system.
The library is required for the creation of animals in the larger system.
Example
```
var dog = Zoo.AnimalMaker.Make("Dog");
```

Given all their systems are running in .Net they have decided it makes sense to create a simple library they can reuse throughout their stack.

### The library should.

* Create animals.
* Comply to reasonable software development practices.
* Be testable in isolation.
* The solution must be buidable and testable using [Rake](http://rake.rubyforge.org/) as this is the customers preferred CI task toolset.
* Be totally portable, if we cannot suck it down and build it from the command line dont bother.

### What will your future team mates be looking for in your response.
* Fix any bugs you find.
* Simple yet innovative improvements.
* Refactoring for the better.
* Attempts to improve quality of the existing code base.
* Tidy code.
* A sound understanding of efficient developer workflow or TDD.
* Improved documentation, be it commented code or valuable test suite.

### What next?
* Please fork or clone the repo and make any changes.
* Once you are done please reply to the email that sent you here with a link to your repo on GitHub.
* Feel free to capture any comments or notes in the readme.md.
* Do not email the solution back, create a repo and we will clone it.
* Have fun!!

### In closing.

No tricks, no monkey business. A plain and transparent exercise that we believe you should enjoy completing. Note this is not a real problem
nor is it real software. We are not looking at solving a real problem just trying assess how you construct solutions.


## Improvements

### Assumptions
1.  The client requires the Animal Maker to generate animal objects based on a type name string. The assumption is based on the description of the task in the readme file.
2.	The client requires the Animal Maker method to be accessible using a static function call. This assumption is based on the description of the task in the readme file.
3.	The system is not performance sensitive, which permits the use of reflection for automatically registering animal types.
4.	There has been no request to assign an individual id to each animal to differentiate animals of the same type from one another.

### Changes
1.  Refactored the animal maker to more closely follow the SOLID principles by allowing clients to easily extend the number of animal types the factory can handle.
2.	Added unit tests to test error handling and type extension.
3.	Added code comments for interfaces and publicly available classes and functions.
4.	Removed the IMaker interface as the assumption was that client wants to access the functionality through a static method call. I would otherwise I would have implemented the interface, which would allow the client to replace or mock the factory in their own solution.
5.	Cleaned up the animal classes to avoid using hardcoded strings to generate type names.
6.	Removed setters for the IAnimal interface until there is a reason for allowing the animal object properties to be set externally.
7.	Created an AnimalMaker exception class to let clients handle library specific exceptions.
