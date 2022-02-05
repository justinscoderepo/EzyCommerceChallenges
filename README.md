Author:     Justine Jose <justnshalom@gmail.com>\
AuthorDate: Sat Feb 5 2022

**Please answer the questions to the best of your ability. Feel free to google, but please let us know on each question. Also please state how long time you spent on each question. Submit the answers and solutions as a downloadable link (not zip in email).**

## Task 1
Two separate .NET systems are set up to validate MD5 keys (or SHA1 etc) from a database. The MD5 keys are generated from a list of employee names. The validation is matching 100% on one system, but only 95% on the other system. What is the most probable reason for this?

----

### The Problem-Solving Process
- Searched in stack overflow by filtering using tags like md5 and C# with some keywords like inconsistency.
- I got 2 reasons for it.
#### Reasons
 - Non ASCII character issue : 
 There is a chance for getting non ASCII character in the string and it will not be properly validated in a Linux Machine.
A chance for  version control Git messes up with non-ascii characters on Linux.
For example, string contains a character like £ which corresponds to the Windows-1252 encoding. In Linux system displays � because it is not a valid UTF-8 encoding.
Solution : We should configure Visual Studio to use UTF-8 instead of Windows-1252.
- Size if the data and system performance: 
The MD5 hash of some data will be exactly the same as a second MD5 hash of exactly the same data, regardless of the size of that data. The only problem with MD5 for large files is that, in some cases, you might get the same hash for two different files.
#### Spent Time - 30 Minutes

----

## Task 2
The code below is used in an ASP.NET application where ”GreetingService.CurrentGreeting” is fetched at the following times: 08, 12 and 16. Which message is returned on each run?

----
### The Problem-Solving Process
Its a logical question and easy to come to the output.

#### Answer
- 08 - Good morning
- 12 - Good evening
- 16 - Good evening
#### Spent Time - 5 Minutes
----
## Task 3
Entity Framework is used to fetch data from a table in a database and display the result with a text header that shows the total number of rows returned in the result. Which of the following versions would you suggest, and why?

## Task 4 (optional for backend position)
Take a look at the following badly written page. Please rewrite this with similar functionality but in a modern way. Focus is on a good and modern structure rather then replicating the functionality exactly.

##
## Task 5
Create a web page with a button. When you click on the button the application should retrieve the currency rates for USD and EUR and display them on the page. Please use *dotnet core* for backend and a modern JS framework for frontend. Please think of how you structure your code on both backend and frontend.

Currency rates feeds can be found on: 

<http://www.floatrates.com/daily/usd.xml>

<https://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml>

<https://www.tcmb.gov.tr/kurlar/today.xml>

Or other feed you can find would work.


Use: good practices and architecture, clean solution, dotnet backend, async calls, VueJS (or Angular/React to bind data)
