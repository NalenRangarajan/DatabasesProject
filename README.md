Our project is called GameTrack.
This is build in a single Visual Studio Solution called GameTracking using 2 Visual Studio projects called GameApplication and GameTracking.

GameApplication:

The GameApplication project houses all code to do with user interaction and GUI functionality.
The project has 6 views, and a custom control.


GameTracking:

The GameTracking project houses all code that has to do with accessing our database.

Inside the Models folder we have a C# class representation of each table in our relational database.

The Sql folder is the bulk of our data.

The Database Creation Procedures folder houses all the procedures that insert data into our tables.
There is a seperate procedure for each table.

The Procedures folder then holds all the procedures necessary for our application. 
This is broken up into different folder to aid readability.
It holds the Aggregating Procedures folder, the Creation Procedures folder, the Entire Procedures folder, the Fetch Procedures folder,
the Get By Unique Procedures folder, the Get Through Relationship Table folder, and the Searching Procedures folder.

First, we have the Aggregating Procedures folder. This holds the four procedures that deal with aggregating data.

Next, we have the Creation Procedures folder. This holds procedures to create and insert rows into our database for the corresponding table.

Next, we have the Entire Procedures folder. This holds the procedures that operate on an entire table.

Next, we have the Fetch Procedures folder. This holds the procedures that get a row based upon their primary key constraint.

Next, we have the Get By Unique Procedures folder. This holds the procedures that get a row based upon their unique key constraints.

Next, we have the Get Through Relationship Table folder. This holds the procedures that involve getting information through a relationship table.

Finally, we have the Searching Procedures folder. This holds the procedures that search through our games based on certain conditions specified by the user.

With that, our Procedures folder is finished.

Our next folder is the Schemas folder. This hold a single sql file describing our GameTrack schema.

Finally we have the Tables folder. This holds the sql files that describe each table in our database, along with a drop tables file.

Outside the Sql folder, we have a CreateDatabase ps1 and sql file to create our database, and a DropDatabase ps1 file to drop our database.

We then have Repository classes with their corresponding interfaces. These classes house methods that allow our GameApplication project
to interact with our database. The corresponding interfaces enforce that the required methods are present.

Finally, outside both our GameApplication and GameTracking project we have a RebuildDatabase ps1 file. This file will rebuild our entire database.
It does this by dropping the database, creating the database, dropping the tables, creating the schema, creating all tables, creating all stored procedures, and finally inserting our table data.

This should be a full description of the structure of our GameTracking Application.

Created by: Calvin Beechner, Max Shafer, and Nalen Rangarajan.
