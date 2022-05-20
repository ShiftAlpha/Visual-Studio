README
-----------------------------------------------------------------------------

Testing Info:

The populated data dates are 15/06/2020, 16/06/2020, 17/06/2020.

The cities populated with data are: DURBAN, JOHANNESBURG, CAPE TOWN

The users favourite cities are: user - DURBAN, CAPE TOWN
				user2 - (No pre-populated favourites)

-----------------------------------------------------------------------------

Login Info

Admin user:

(Admins are recognized by a 1)

Username: Admin
Password: p

General user:

(General users are recognized by a 0)

Username: user
Password: p

Username: user2
Password: p


Note: usernames and passwords are case-sensitive.
-----------------------------------------------------------------------------

General Comments:

Reports for the Multi-City view are saved under MultiCityReport.txt
Reports for the Single City view are saved under SingleCityReport.txt

Forecast information is written to and read from Forecasts.txt

City names are written to and read from Cities.txt

Login information is stored in LoginInfo.txt

User information is stored in UserInfo.txt

Dates are stored and written in the format of dd/MM/yyyy

user2 will be able to go to the View Forecast form, but will not see 
any forecast data as they have no favourite cities. This is to show 
that they system can handle a user with no favourite cities. If you
add a city to user2's favourites list, you will not be able to get 
back to a point where user2 has no favourites during that runtime
instance. This is because a user must always have at least one 
favourite city to use the application properly. 

-----------------------------------------------------------------------------

Thank you for reading
Callum Simpson
19010230