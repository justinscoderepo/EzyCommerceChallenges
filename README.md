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
 - Non-ASCII character issue : 
 There is a chance for getting a non-ASCII character in the string and it is not properly validated in a Linux Machine.
A chance for version control Git messes up with non-ASCII characters on Linux.
For example, a string contains a character like £ which corresponds to the Windows-1252 encoding. In Linux system displays � because it is not a valid UTF-8 encoding.
Solution: We should configure Visual Studio to use UTF-8 instead of Windows-1252.
- Size of the data and system performance: 
The MD5 hash of some data will be exactly the same as a second MD5 hash of exactly the same data, regardless of the size of that data. The only problem with MD5 for large files is that, in some cases, you might get the same hash for two different files.
#### Spent Time - 30 Minutes

----

## Task 2
The code below is used in an ASP.NET application where ”GreetingService.CurrentGreeting” is fetched at the following times: 08, 12 and 16. Which message is returned on each run?

----
### The Problem-Solving Process
It's a logical question and was easy to come to the output.

#### Answer
- 08 - Good morning
- 12 - Good evening
- 16 - Good evening
#### Spent Time - 5 Minutes
----
## Task 3
Entity Framework is used to fetch data from a table in a database and display the result with a text header that shows the total number of rows returned in the result. Which of the following versions would you suggest, and why?

### The Problem-Solving Process
I already have experience with entity framework LINQ and used IQueryable Count and List Count.
IQueryable count is executing and taking count from the database server itself ( `SELECT * FROM MyTable` ). But when we call toList, it will do the execution on the database server-side and return the results as rows, then C# will materialize all the resulting entities as a list of .Net objects. After that, the count execution is happening in the C# side using the LINQ list.

In the case of performance, toList will take all data to the client-side, and performing count method execution needs extra code execution and it will make issues in performance in the case of large data.
But if execute it on the database side, it will be faster and we no need to fetch the entire result and the returned response data size is also too low(it will be Int32 with the number of rows).

#### Answer
Obviously, if you are only looking for a count of myTable then I would suggest **version 2**, here don't need to call toList because it requires more resources.
#### Spent Time - 10 Minutes
----

## Task 4 (optional for backend position)
Take a look at the following badly written page. Please rewrite this with similar functionality but in a modern way. Focus is on a good and modern structure rather then replicating the functionality exactly.
#### Process
Started reading Vue.js documentation for 1 hour and started creating frontend using Vue.js and tailwind.

Code available in https://github.com/justinscoderepo/EzyCommerceChallenges/tree/main/ReadListVueJS
#### Spent Time - 3 Hours
----
##
## Task 5
Create a web page with a button. When you click on the button the application should retrieve the currency rates for USD and EUR and display them on the page. Please use *dotnet core* for backend and a modern JS framework for frontend. Please think of how you structure your code on both backend and frontend.

Currency rates feeds can be found on: 

<http://www.floatrates.com/daily/usd.xml>

<https://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml>

<https://www.tcmb.gov.tr/kurlar/today.xml>

Or other feed you can find would work.


Use: good practices and architecture, clean solution, dotnet backend, async calls, VueJS (or Angular/React to bind data)

#### Process
Implemented the backend using .Net Core C#.
its running in port 5000.
Code available in https://github.com/justinscoderepo/EzyCommerceChallenges/tree/main/CurrencyRateApplication/BE
#### Spent Time - 8 Hours

Implemented the backend using VueJS and tailwind.
Instead of get results button, I used a currency filter( commented the button ).
Code available in https://github.com/justinscoderepo/EzyCommerceChallenges/tree/main/CurrencyRateApplication/FE
#### Spent Time - 8 Hours