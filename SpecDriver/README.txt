
Automating RyanAir flight selection up to payment.

First of all apologies for taking my time with this task. 
Reason was SAT for client lasting 3 weeks and my recent news of my girlfriend being pregnant. :)
I just simply had other matters I had to devote my time.

I based my work on SpecDriver by Alister Scott for reusability. 

Testing works on 3 levels:
1. Defining features - business scenarios in gherkin language
2. Step definitions - providing navigation and reusability on pages
3. Page models - an abstract for pages with Web Elements.

Specflow translates gherkin scenarios to Step definitions and runs them on page models. 

I used RemoteWebDriver for chrome driver as I had much better experience on it. Test itself does not pass as I did left last page unfinished.
This is unfortunately due to time constraints that I currently have and I cannot devote more of my time for activities for which I do not get any reimbursements.
However, as a base for my thinking I left comments and provided ample reasoning for automation approach.
My previous experience with test automation was about a year ago, but I believe we used a different approach for handling pages. 
Instead of the one used here, we extended default constructor using Invoke method to create pages on the fly.
I have commented out some of the assertions (mainly for checking if we are currently on the right page).
Packages.config should be helpfull for determining dependencies. Everything was developed in VS2015 community edition.

*Running the test:*
I do not have the knowledge how Mac will handle C# .bin but I believe Mono can run it.
Please Use Release/RyanAirBookFlight.dll for that.

after downloading nUnit files use following:
mono nunit-console.exe RyanAirBookFlight.dll 
in Release dir. 

*Test results:*
Sample test result You can find in TestResults directory.

I hope this will be sufficient. Please let me know what You think and provide feedback - welcome as always. 

Have a nice day!
Piotr Kula

