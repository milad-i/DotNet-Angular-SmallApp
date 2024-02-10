# Project Title
DotNet-Angular-SmallApp

## Description
This is a small APP developed using .NET 6 and Angular 17.

## Dependencies
* Dot Net 6
* Angular 17

## Details

### 1- Back-End (.NET) :

Simple Web Api that contains Book Model (Entity) and a Controller to serve the books data.<br>
The Book data are static and no DataBase used.<br>


### 2- Front-End (Angular) : 

There are 3 components called Home, Data, Event.<br>
Home Component displays welcome message to user.<br>
Event Component has a button to display alert in the event of click.<br>
Data Component is using a "service" and a "model(Interface)" to fetch data from the API and display them into a html table using a loop.<br>

All route wrote in a seperate file called app.routes.<br>
There is a navigation menu to use Angular routing to switch between  the component.<br>

This APP is using pure css for Styling.
