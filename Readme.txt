Date: 8 october 2023
Name: Manpreet kaur
Student Id: 0812152

My assigment first is on doll which I started by creating new project.
Firstly, I added my readme and also add github repository.
Afterthat I followed all the steps of part1 for my project and run my project.

In the part I add controller and changed its name by HelloworldConroller.

Date:9 october 2023
I updated welcome method as shown in tutorail and run my project.

In the next section in HelloWorldController class I replace my index method with the another code provided in section.
 I add a new folder under views folder with the name HelloWorld and then I add a new item index.cshtml under helloworld 
 in the next step i updated my content with the given code in tutorial.

 part 3 - I updated my  title index and  footer of the project with the new name and run my app after that in the Views/HelloWorld/Index.cshtml ,
 in the next step i change my index and h2 with Doll List.
 
 In HelloWorldController.cs, I changed the Welcome method to add a Message and NumTimes value to the ViewData dictionary.Afterthat I added new file under view/helloworld named welcome.cshtml
 and change the code then test my app .

Date:10 october 2023 (adding a model)
I am working on my part-4th in which I am adding a model firstly I add a model class under model folder and name the file as Doll.cs then
I updated  the code of my file according to the tutorial also I  add new characteritics and attributes
such as : Brand,Price,Id as my products requirement. add using statem,ents and examinbe

In the following step,I added NuGetPackages from the tools menu.
I selected Package Manager Console from the NuGet Package Manager then I run the command. 
 
 surprisingly it shows an error when i run command in my PMC at that point I was totally upset but then I rember our class lecture in which we faced same problem so
 I followed the steps as we done before in the class and install new package version 3.1.0.

 In the next step i added new folder name data and add new item called MvcDollContext.cs 
 after that i changed the code but it is showing an error .....
 I am wording on solving the error and finally,
 wow..... its sloved by adding new public class.

 Further I add using statements at the top of Startup.cs:
 Furthermore,i updated the code in  Startup.ConfigureServices: also updated its name as my product name.

 (examine the database connection string)
 In the appsettings.json file i added a connection string.

 (Scaffold Doll page)
 In the solution explorer ,I added new Scaffolded Item under controllers folder .Also,in Scaffold dialog I selected  MVC Controller with views, using Entity Framework > and select add.
 afterthat I completed the add controller dialog steps.further , in the PMC by using EF core migrations features I created and updated the database to the data model.

  Date-12 october 2023
 (Seed the database)-I created a class called SeedData and added the data of my application in it.
 After that i updated the startup.cs file and program.cs file and test the app
 when i clicked the link to see the index page of data it shows an error and the error is about your DollContext is not defined then I examined my MVCDollContext.cs file then I noticed 
 that there is Movie on one place that I never changed that with my product name  and i completed the next step with this mistake, which was i created a controller file and scaffolding item with that.
 So I again did  my previous steps , deleted my migrations as well as DoolsController.cs page because my error was based on that 
 steps so I created them again and after updating that pages I run my browser again then it worked .......happy after solving error wow......

 part-6 (controller action and views)
 I examined controller methods and views and continue working on my further steps.

 part-7 (Add Search)
 I updated the index method inside Controllers/DollsController.cs, the index action method creates a LINQ query to select the dolls by creating a lambda expression.
 Further,I added a form inside Views/Dolls/Index.cshtml file.This HTML form tag uses the form tag helper so whenever we submit the form it will filter the string and save the changes and filter.
 Afterthat,I added a class under model folder by name DollBrandViewModel.cs and made changes I updated my index method in DollsController.cs to search with the Brand column of my app
 in that also I updated index.cshtml under Views/Dolls which will search the data by the brand column also.

 I added [httpPost] index method and also added get method in views/Dolls/Index.cshtml.

 part-8 (add a new field)
 Date: 13 october 2023

 Firstly, I added a new Rating field in Model/Doll.cs afterthat I updated bind for both create and edit action in Dolls/Controller.cs.Moreover,I also update Rating field in all my templates inside views/Dolls
 then I changed my seeddata class so that it provides a value for new column in each new Doll .I also added migrations for new Rating column and run the browser to check the app and upto this its working well...............

 part-9 (Add validation)
 After adding validations rules to my Doll.cs file i run my app and try to create a link to add a new Doll and fill the form as invalides values which shows an error message.

 part-10(Modifications)
 I added new page name it as: About us,inside home page.In this i created view under the home folded and added file in it.Moreover,I modify the page and give a discription about my company.Afterthat I updated HomeController.cs
 with new view then I run my app and it is working well............It shows the result of my About us page.

 I added css to make  web pages more attractive........




 





