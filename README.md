# CurrencyToWordConverterApp

Application is intended to do a currency to word converter.

# Development tech stack:
API: i have used VS 2017 (dotnetcore) in order to develop the service api.
Client: A small angular 4 based client with the help of bootstrap css
Test: Microsoft test framework

# How to run the solution

## Web API:

Step 1: Open solution (CurrencyConverterApp.sln) using visual studio 2017 and Right click and solution and click "Restore nuget packages".
Step 2: Hit F5 (Or right click the CurrencyConverterService project and debug -> start new instance)
You should see a brower with a UI says that "Currency to word converter service is running".
(Note, for any problem, please install dontnetcore runtime. By default vs 2017 supports dotnetcore though)

## Client:

Step1: Need to setup the environment for angular 4. Please install node from (https://nodejs.org/en/download/)
Step2: After installing node, open your command prompt and run "npm install -g @angular/cli"
That is enough to start with our angular client. Please see "https://angular.io/guide/quickstart" for any further details

Step3: Navigate to the folder: "App\ConverterApp" from windows explorer and open command prompt here.
Step4: run these commands one by one:
>> npm install (It will take a bit to download all necessary modules)
>> ng serve --open (It will build the client and automatically open the browser)

Now you should see the client UI. I have added proper validation in client. It will only allows for the valid input.
Please make sure the service is running already, before proceeding the client.

Cheers !!




