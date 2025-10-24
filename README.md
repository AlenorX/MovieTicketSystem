# MovieTicketSystem
MovieTicketSystem is a simulator for purchasing tickets to a movie screening.
## MovieTicketSystem состоит из:
1) SQLite is the main database that stores user data
2) Flask is a micro-framework. It is used as an API for data exchange
3) Programming languages: C# and Python

## The principle of operation
1) API and PurchaseProgram are launched
2) All actions are performed in the program (Login, Register, Select the number of tickets to purchase, and make a payment)
3) Json is sent via API. Later, the data is transferred to the QueryScript module. This module makes requests to the database

If you consider further development of the project, you can use WSGI to interact with Flask. It is also possible to migrate the database from SQLite to MYSQL

# !REMINDER!
## This project is a simulator of buying tickets for a movie show in a cinema, where interactions with APIs and databases are used.
