# Eventual Web Application

Eventual Event Finder is an application for managing and searching various types of concerts and social events. Users can filter event searches by location and tags. In addition, users can add events to their favorites, view event information, and locations on interactive maps. The application allows users to behave like administrators by creating new events and managing their own events. Users interact through a client-side application which consumes web services, that provide business logic and access to a database.

## Environment / Technologies 
ASP.NET Web API, SQL Server, C#, ADO.NET Entity Framework, .NET, ASP.NET

>---
> ## Developers:
> ### Summer Wilken                       - snwilken<br/>
> ### Mike Furlow                         - mfurlow<br/>
>---

## End Points
<table>

<tr>
<th>HTTP VERB</th>
<th>ENDPOINT URI</th>
<th>DESCRIPTION</th>
</tr>

<tr>
<td>DELETE</td>
<td>api/users/deleteuser/id</td>
<td>Delete specific user</td>
</tr>

<tr>
<td>PUT</td>
<td>api/users/putuser/id/{userEmail}/{password}</td>
<td>Update user</td>
</tr>

<tr>
<td>GET</td>
<td>api/events/searchevents/{keyword}</td>
<td>Search based on title and event type</td>
</tr>

<tr>
<td>GET</td>
<td>api/users/getusersevents/{id}/{userEmail}/{password}</td>
<td>Returns all rsvp’d, saved, and past events</td>
</tr>

<tr>
<td>POST</td>
<td>api/users/signupuser/</td>    
<td>[FROM BODY - User] Create new user</td>
</tr>

<tr>
<td>POST</td>
<td>api/users/saveevent/{userID}/{eventID}/{userEmail}/{password}</td>
<td>Save event to specific user</td>
</tr>

<tr>
<td>POST</td>
<td>api/login/login/</td>
<td>Login user</td>
</tr>

<tr>
<td>POST</td>
<td>api/users/registerevent/{userID}/{eventID}/{userEmail}/{password}</td>
<td>RSVP event to user</td>
</tr>

<tr>
<td>DELETE</td>
<td>api/users/DropRegisteredEvent/{userID}/{registeredEvent}/{userEmail}/{password}</td>
<td>Delete event from user’s list of events</td>
</tr>

<tr>
<td>DELETE</td>
<td>api/users/DropSavedEvent/{userID}/{savedEvent}/{userEmail}/{userPassword}</td>
<td>Delete saved event user’s list of events</td>
</tr>

<tr>
<td>GET</td>
<td>api/users/getusers/</td>
<td>Returns all users in database</td>
</tr>

<tr>
<td>GET</td>
<td>api/users/getuser/{id}/{userPassword}/{userEmail}</td>
<td>Gets specific user information</td>
</tr>

<tr>
<td>GET</td>
<td>api/events/getevents/</td>
<td>Gets all events</td>
</tr>

<tr>
<td>GET</td>
<td>api/events/getevent/{id}</td>
<td>Gets specific event</td>
</tr>
<table>
