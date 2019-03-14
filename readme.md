nUnitConsolePractice
---

Adding nUnit console support to a solution.

You have NUnitConsolePractice.Tests with some working unit tests. The goal is to run the tests with the console runner.

1. Install the nUnit console runner. To which project? What if multiple?
2. Create a testConfig.nunit config file with NUnitConsolePractice.Tests. Where?
- can you run the nunit console without config, just for the specified dlls - overview?
- where are test results put by default?
3. Make the testResults folder ignored in .gitignore
4. Create runTests.bat that runs the console runner, publish tests to testResults\testResults.xml
5. What are the console runner result codes: (a) for success, (b) when tests fail, (c) when the whole console runner fails?
6. Running only selected test categories:
- mark InvoiceGeneratorTests with the "Integration" category
- how can you avoid "magic strings" with a category name - overview?
- configure runTests.bat to execute all tests **without** Integration category

7. Running tests with the service integration (i.e. you run WCF client-side tests connecting with a service host that is run for the duration of the test) - how to overview?

8. CI integration overview:
- how do you run nUnit tests in Jenkins? Breaking the build vs marking as unstable.
- how do you integrate test results into the build results? Plugin needed? What happens if some tests fail?
- running tests with the service integration in Jenkins - how to overview?
